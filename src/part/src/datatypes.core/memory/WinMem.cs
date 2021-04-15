//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.IO;
    using System.Diagnostics;

    using Windows;

    using static Part;
    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost]
    public readonly unsafe struct WinMem
    {
        [Op]
        public static Index<MemoryPageInfo> snapshot()
            => pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryPageInfo> snapshot(int procid)
            => pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryPageInfo> snapshot(Process src)
            => pages(MemoryNode.snapshot(src.Id).Describe());

        [MethodImpl(Inline)]
        public static unsafe bool liberate(ReadOnlySpan<byte> src, out byte* pDst)
        {
            var size = (ulong)src.Length;
            ref var cell = ref edit(first(src));
            var pCell = pointer(ref cell);
            if(liberate(pCell, size))
            {
                pDst = pCell;
                return true;
            }
            else
            {
                pDst = default;
                return false;
            }
        }

        [MethodImpl(Inline)]
        public static unsafe bool liberate<T>(T* pSrc, ulong size)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pSrc;
            if (!VirtualProtect(buffer, (UIntPtr)size, PageProtection.ExecuteReadWrite, out PageProtection _))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static NativeCellToken<F>[] tokenize<F>(IntPtr @base, uint size, uint count)
            where F : unmanaged, IDataCell
        {
            var tokens = new NativeCellToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = new NativeCellToken<F>(IntPtr.Add(@base, (int)size*i), size);
            return tokens;
        }

        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static NativeCells<F> cells<F>(byte count)
            where F : unmanaged, IDataCell
        {
            var bufferSize = (uint)default(F).Size;
            var totalSize = count*(bufferSize);
            var allocated = NativeBuffer.alloc(totalSize);
            return new NativeCells<F>(allocated, count, bufferSize, totalSize);
        }

        const string Kernel = "kernel32.dll";

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern int VirtualQueryEx(IntPtr process, IntPtr address, out BasicMemoryInfo lpBuffer, uint dwLength);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool VirtualProtectEx(IntPtr process, IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [DllImport(Kernel, SetLastError = true), Free]
        public static extern bool VirtualProtect(IntPtr address, UIntPtr size, PageProtection protect, out PageProtection prior);

        [MethodImpl(Inline)]
        public static T* VirtualAlloc<T>(ulong size, MemAllocType type, PageProtection protection)
            where T : unmanaged
                => (T*)VirtualAlloc(UIntPtr.Zero, (UIntPtr)size, type, protection);

        [MethodImpl(Inline)]
        public static bool VirtualFree<T>(T* pSrc, ulong size, MemFreeType type)
            where T : unmanaged
                => VirtualFree((void*)pSrc, (UIntPtr)size, type);

        [DllImport(Kernel, SetLastError = true), Free]
        static extern UIntPtr VirtualAlloc(UIntPtr address, UIntPtr size, MemAllocType type, PageProtection protect);

        [DllImport(Kernel, SetLastError = true), Free]
        static unsafe extern bool VirtualFree(void* pAddress, UIntPtr sizeToFree, MemFreeType type);

        static Index<MemoryPageInfo> pages(ReadOnlySpan<MemorySegInfo> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<MemoryPageInfo>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                fill(skip(src,i), out seek(dst,i));
            return buffer;
        }

        static ref MemoryPageInfo fill(in MemorySegInfo src, out MemoryPageInfo dst)
        {
            var identity = src.Owner;
            if(text.nonempty(identity))
            {
                dst.FullIdentity = identity;
                if(identity.EndsWith(".exe") || identity.EndsWith(".dll"))
                    dst.Identity = Path.GetFileName(identity);
                else
                    dst.Identity = "?";
            }
            else
            {
                dst.Identity = EmptyString;
                dst.FullIdentity = EmptyString;
            }
            dst.StartAddress = src.StartAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
            dst.Protection = src.Protection;
            dst.Type = src.Type;
            dst.State = src.State;
            return ref dst;
        }
    }
}