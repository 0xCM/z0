//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Windows;
    using static Windows.Kernel32;
    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static unsafe ref readonly SegRef<T> liberate<T>(in SegRef<T> src)
            where T : unmanaged
        {
            liberate(src.BaseAddress.Pointer<T>(), (int)src.Length);
            return ref src;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BinaryCode liberate(in BinaryCode src)
        {
            liberate<byte>(src.Ref);
            return ref src;
        }

        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(Span<byte> src)
            => liberate((byte*)pointer(ref first(src)), src.Length);

        /// <summary>
        /// Can this ever be a good way to solve your problem?
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static Span<char> liberate(ReadOnlySpan<char> src)
            => cover(first(edit(src)),src.Length);

        /// <summary>
        /// This may not be the best idea to solve your problem
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline)]
        public static unsafe byte* liberate(ReadOnlySpan<byte> src)
            => liberate<byte>(ref edit(first(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(ref byte src, int length)
            => liberate((byte*)pointer(ref src), length);

        /// <summary>
        /// Enables execution over a specified memory range
        /// </summary>
        /// <param name="range">The range to liberate</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(MemoryRange range)
            => liberate(range.Min.Pointer<byte>(), range.Size);

        [MethodImpl(Inline)]
        public static unsafe T* liberate<T>(T* pSrc, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pSrc;
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(buffer, (ulong)length);
            return pSrc;
        }


        /// <summary>
        /// Enables en executable memory segment
        /// </summary>
        /// <param name="src">The leading cell reference</param>
        /// <param name="length">The length of the segment, in bytes</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            var pSrc = Unsafe.AsPointer(ref src);
            IntPtr buffer = (IntPtr)pSrc;
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(buffer, (ulong)length);
            return (T*)pSrc;
        }

        /// <summary>
        /// Enables an executable memory segment
        /// </summary>
        /// <param name="src">The leading cell pointer</param>
        /// <param name="length">The length of the segment, in bytes</param>
        [MethodImpl(Inline)]
        public static IntPtr liberate(IntPtr src, int length)
        {
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, src, (UIntPtr)(ulong)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(src, (ulong)length);
            return src;
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress liberate(MemoryAddress src, ulong length)
             => VirtualProtectEx(CurrentProcess.ProcessHandle, src, (UIntPtr)(ulong)length, PageProtection.ExecuteReadWrite, out var _) ? src : MemoryAddress.Zero;

        internal static void ThrowLiberationError(IntPtr pCode, ulong Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");
        }
    }
}