//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Text;

    using static Part;

    partial class SRM
    {
        [ApiHost("srm.nonvirtualstringheap")]
        public struct NonVirtualStringHeap
        {
            [MethodImpl(Inline), Op]
            public static uint GetHeapOffset(StringHandle src)
                => (core.uint32(src) & HeapHandleType.OffsetMask);

            [MethodImpl(Inline), Op]
            public static StringHandle HandleFromOffset(int heapOffset)
                => core.@as<uint,StringHandle>(StringHandleType.String | (uint)heapOffset);

            [MethodImpl(Inline), Op]
            public static char GetTerminator(StringHandle src)
                => src.StringKind() == StringKind.DotTerminated ? '.' : '\0';

            [MethodImpl(Inline), Op]
            public BlobReader GetBlobReader(StringHandle handle)
                => new BlobReader(GetMemoryBlock(handle));

            readonly MemoryBlock Block;

            public MemoryAddress BaseAddress
            {
                [MethodImpl(Inline)]
                get => Block.BaseAddress;
            }

            [MethodImpl(Inline)]
            public NonVirtualStringHeap(MemoryBlock block)
            {
                Block = block;
            }

            public StringHandle FirstHandle
            {
                [MethodImpl(Inline), Op]
                get => GetNextHandle(HandleFromOffset(0));
            }

            [MethodImpl(Inline), Op]
            public StringHandle GetNextHandle(StringHandle src)
            {
                var terminator = Block.IndexOf(0, src.GetHeapOffset());
                if (terminator == -1 || terminator == Block.Length - 1)
                    return default(StringHandle);

                return HandleFromOffset(terminator + 1);
            }

            public uint CountHandles()
            {
                var handle = FirstHandle;
                uint count = 0;
                while(handle.IsNonEmpty())
                {
                    count++;
                    handle = GetNextHandle(handle);
                }
                return count;
            }

            [Op]
            public Span<StringHandle> ReadHandles()
            {
                var dst = root.list<StringHandle>();
                var handle = FirstHandle;
                while(handle.IsNonEmpty())
                {
                    dst.Add(handle);
                    handle = GetNextHandle(handle);
                }
                return dst.EditDeposited();
            }

            public uint ReadHandles(Span<StringHandle> dst)
            {
                var handle = FirstHandle;
                var counter = 0u;
                var last = dst.Length - 1;
                while(handle.IsNonEmpty() && counter < last)
                {
                    core.seek(dst, counter++) = handle;
                    handle = GetNextHandle(handle);
                }
                return counter;
            }

            public string GetString(StringHandle handle, MetadataStringDecoder utf8Decoder)
                => GetString(handle, utf8Decoder, prefixOpt: null);

            public string GetString(StringHandle handle)
                => GetString(handle, MetadataStringDecoder.DefaultUTF8, prefixOpt: null);

            [MethodImpl(Inline), Op]
            public int IndexOf(int offset, AsciCharCode match)
                => Block.Utf8NullTerminatedOffsetOfAsciiChar(offset, (char)match);

            [MethodImpl(Inline), Op]
            public unsafe MemoryBlock GetMemoryBlock(StringHandle handle)
            {
                int bytesRead;
                int offset = handle.GetHeapOffset();
                int length = Block.GetUtf8NullTerminatedLength(offset, out bytesRead, GetTerminator(handle));
                return new MemoryBlock(Block.Pointer + offset, length);
            }


            public unsafe byte[] GetStringBytes(StringHandle handle, byte[] prefix)
            {
                Debug.Assert(handle.StringKind() != StringKind.Virtual);
                var block = GetMemoryBlock(handle);
                var bytes = new byte[prefix.Length + block.Length];
                Buffer.BlockCopy(prefix, 0, bytes, 0, prefix.Length);
                Marshal.Copy((IntPtr)block.Pointer, bytes, prefix.Length, block.Length);
                return bytes;
            }

            /// <summary>
            /// Equivalent to Array.BinarySearch, searches for given raw (non-virtual) handle in given array of ASCII strings.
            /// </summary>
            public int BinarySearch(string[] asciiKeys, StringHandle rawHandle)
                => Block.BinarySearch(asciiKeys, rawHandle.GetHeapOffset());

            string GetString(StringHandle handle, MetadataStringDecoder utf8Decoder, byte[]? prefixOpt)
            {
                int bytesRead;
                char otherTerminator = handle.StringKind() == StringKind.DotTerminated ? '.' : '\0';
                return Block.PeekUtf8NullTerminated(handle.GetHeapOffset(), prefixOpt, utf8Decoder, out bytesRead, otherTerminator);
            }
        }
    }
}