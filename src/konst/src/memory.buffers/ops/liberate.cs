//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Windows.Kernel32;

    unsafe partial struct Buffers
    {
        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static byte* liberate(Span<byte> src)
            => liberate((byte*)z.pointer(ref z.first(src)), src.Length);

        /// <summary>
        /// This may not be the best idea to solve your problem
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline)]
        public static unsafe byte* liberate(ReadOnlySpan<byte> src)
            => Buffers.liberate<byte>(ref z.edit(z.first(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static byte* liberate(ref byte src, int length)
            => liberate((byte*)z.pointer(ref src), length);

        [MethodImpl(Inline)]
        public static ref readonly BinaryCode liberate(in BinaryCode src)
        {
            liberate<byte>(src.Ref);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static unsafe ref readonly Ref<T> liberate<T>(in Ref<T> src)
            where T : unmanaged
        {
            Buffers.liberate((T*)src.Location, (int)src.DataSize);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static T* liberate<T>(T* pSrc, int length)
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
        static IntPtr liberate(IntPtr src, int length)
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
                Buffers.ThrowLiberationError(buffer, length);
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