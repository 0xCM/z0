//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct Addressable
    {
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

        /// <summary>
        /// Enables en executable memory segment
        /// </summary>
        /// <param name="src">The leading cell reference</param>
        /// <param name="length">The length of the segment, in bytes</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe IntPtr liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            var pSrc = Unsafe.AsPointer(ref src);
            IntPtr buffer = (IntPtr)pSrc;
            if (!Buffers.VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                Buffers.ThrowLiberationError(buffer, length);
            return buffer;
        }

        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline)]
        public static unsafe byte* liberate(Span<byte> src)
            => Buffers.liberate((byte*)Root.ptr(ref As.first(src)), src.Length);

        /// <summary>
        /// This may not be the best idea to solve your problem
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline)]
        public static unsafe IntPtr liberate(ReadOnlySpan<byte> src)
            => liberate<byte>(ref As.edit(As.first(src)), src.Length); 
    }
}