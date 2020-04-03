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

    using static Seed;
    using static refs;

    [ApiHost,SuppressUnmanagedCodeSecurity]
    public static unsafe class Buffers
    {
        const string Kernel32 = "kernel32.dll";

        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline)]
        public static BufferAllocation native(int length)
            => BufferAllocation.Own((liberate(Marshal.AllocHGlobal(length), length), length));        

        /// <summary>
        /// Allocates a span-predicated T-stack
        /// </summary>
        /// <param name="capacity">The T-cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static SpanStack<T> stack<T>(int capacity)
            where T : unmanaged
                => new SpanStack<T>(new T[capacity]);


        /// <summary>
        /// Covers a span with a stack buffer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanStack<T> stack<T>(Span<T> src)
            where T : unmanaged
                => new SpanStack<T>(src);

        /// <summary>
        /// Allocates a span-predicated T-ring buffer
        /// </summary>
        /// <param name="capacity">The T-cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static RingBuffer<T> ring<T>(int capacity)
            where T : unmanaged
                => new RingBuffer<T>(new T[capacity]);

        /// <summary>
        /// Covers a span with a ring buffer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RingBuffer<T> ring<T>(Span<T> src)
            where T : unmanaged
                => new RingBuffer<T>(src);

        /// <summary>
        /// Allocates a span-predicated S/T ring buffer
        /// </summary>
        /// <param name="capacity">The segment count</param>
        /// <typeparam name="S">The segmented type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static PartRing<S,T> parts<S,T>(int capacity)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(new S[capacity]);

        /// <summary>
        /// Covers an S-span with an S/T ring buffer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The segmented type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static PartRing<S,T> parts<S,T>(Span<S> src)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(src);

        /// <summary>
        /// Deallocates a native allocation
        /// </summary>
        /// <param name="handle">The allocation handle</param>
        [MethodImpl(Inline)]
        public static void release(IntPtr handle)
            => Marshal.FreeHGlobal(handle);

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
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        static IntPtr Liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)Unsafe.AsPointer(ref src);
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return buffer;
        }

        [MethodImpl(Inline)]
        static IntPtr Liberate(ReadOnlySpan<byte> src)
            => Liberate(ref edit(in head(src)), src.Length);

        [MethodImpl(Inline)]
        static IntPtr Liberate(Span<byte> src)
            => Liberate(ref head(src), src.Length);
 
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