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

    unsafe partial struct Buffers
    {
        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static byte* liberate(Span<byte> src)
            => liberate((byte*)z.ptr(ref z.first(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static byte* liberate(ref byte src, int length)
            => liberate((byte*)z.ptr(ref src), length);

        [MethodImpl(Inline)]
        public static T* liberate<T>(T* pSrc, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pSrc;
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
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
            if (!VirtualProtectEx(CurrentProcess.Handle, src, (UIntPtr)(ulong)length, 0x40, out uint _))
                ThrowLiberationError(src, length);
            return src;
        }

        internal static void ThrowLiberationError(IntPtr pCode, int Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;            
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");     
        }

        /// <summary>
        /// Windows API that applies memory protection attributes
        /// </summary>
        [DllImport(Kernel32)]
        internal static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags); 
    }
}