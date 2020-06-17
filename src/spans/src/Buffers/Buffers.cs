//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    /// <summary>
    /// Api for managing native buffers
    /// </summary>
    [ApiHost, SuppressUnmanagedCodeSecurity]
    public static unsafe class Buffers
    {
        const string Kernel32 = "kernel32.dll";

        /// <summary>
        /// Creates an array of tokens that identify a squence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static BufferToken[] tokenize(IntPtr @base, int size, int count)
        {
            var tokens = new BufferToken[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, size*i), size); 
            return tokens;
        }

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> content<T>(IBufferToken src)
            where T : unmanaged
                => Imagine.cover((byte*)src.Handle.ToPointer(), src.Size).As<T>();

        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The executable code</param>
        [MethodImpl(Inline), Op]
        public static byte* Liberate(Span<byte> src)
            => Liberate<byte>((byte*)ptr<byte>(ref head(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The executable code</param>
        [MethodImpl(Inline), Op]
        public static byte* Liberate(ref byte src, int length)
            => Liberate<byte>((byte*)ptr<byte>(ref src), length);

        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline), Op]
        public static BufferAllocation native(int length)
            => BufferAllocation.Own((liberate(Marshal.AllocHGlobal(length), length), length));        

        /// <summary>
        /// Deallocates a native allocation
        /// </summary>
        /// <param name="handle">The allocation handle</param>
        [MethodImpl(Inline), Op]
        public static void release(IntPtr handle)
            => Marshal.FreeHGlobal(handle);

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> fill<T>(ReadOnlySpan<T> src, IBufferToken dst)
            where T : unmanaged
        {
            var srcBytes = bytes(src);
            var dstBytes = content<byte>(dst);
            if(srcBytes.Length <= dst.Size)
            {
                if(srcBytes.Length < dst.Size)
                    dstBytes.Clear();

                srcBytes.CopyTo(dstBytes);
            }
            else
                srcBytes.Slice(dst.Size).CopyTo(dstBytes);  

            return content<T>(dst);         
        }

        [MethodImpl(Inline), Op]
        public static void clear(IBufferToken src)
            => content<byte>(src).Clear();

        /// <summary>
        /// Enables an executable memory segment
        /// </summary>
        /// <param name="src">The leading cell pointer</param>
        /// <param name="length">The length of the segment, in bytes</param>
        [MethodImpl(Inline)]
        static IntPtr liberate(IntPtr src, int length)
        {
            if (!VirtualProtectEx(CurrentProcess.Handle, src, (UIntPtr)(ulong)length, 0x40, out uint _))
                ThrowLiberationError(src, length);
            return src;
        }

        /// <summary>
        /// Enables en executable memory segment
        /// </summary>
        /// <param name="src">The leading cell reference</param>
        /// <param name="length">The length of the segment, in bytes</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        static IntPtr Liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            var pSrc = Unsafe.AsPointer(ref src);
            IntPtr buffer = (IntPtr)pSrc;
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return buffer;
        }

        // [MethodImpl(Inline)]
        // static IntPtr Liberate(ReadOnlySpan<byte> src)
        //     => Liberate(ref edit(in head(src)), src.Length);
 
        static void ThrowLiberationError(IntPtr pCode, int Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;            
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");     
        }

        /// <summary>
        /// Windows API that applies memory protection attributes
        /// </summary>
        [DllImport(Kernel32)]
        static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags); 

        [MethodImpl(Inline)]
        static T* Liberate<T>(T* pBuffer, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pBuffer;
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return pBuffer;
        }             
    }
}