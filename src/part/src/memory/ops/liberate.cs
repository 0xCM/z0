//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Windows.Kernel32;
    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static unsafe ref readonly SegRef<T> liberate<T>(in SegRef<T> src)
            where T : unmanaged
        {
            liberate(src.BaseAddress.Pointer<T>(), (int)src.Length);
            return ref src;
        }

        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(Span<byte> src)
            => liberate((byte*)memory.pointer(ref memory.first(src)), src.Length);

        /// <summary>
        /// This may not be the best idea to solve your problem
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline)]
        public static unsafe byte* liberate(ReadOnlySpan<byte> src)
            => liberate<byte>(ref memory.edit(memory.first(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(ref byte src, int length)
            => liberate((byte*)memory.pointer(ref src), length);

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
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return pSrc;
        }

        /// <summary>
        /// Enables an executable memory segment
        /// </summary>
        /// <param name="src">The leading cell pointer</param>
        /// <param name="length">The length of the segment, in bytes</param>
        [MethodImpl(Inline)]
        public static IntPtr liberate(IntPtr src, int length)
        {
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, src, (UIntPtr)(ulong)length, 0x40, out uint _))
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
        public static unsafe T* liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            var pSrc = Unsafe.AsPointer(ref src);
            IntPtr buffer = (IntPtr)pSrc;
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return (T*)pSrc;
        }

        internal static void ThrowLiberationError(IntPtr pCode, int Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");
        }
    }
}