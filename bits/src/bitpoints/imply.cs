//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;
    using static As;
    using static AsIn;

    unsafe partial class BitPoints
    {
        [MethodImpl(Inline)]
        public static void imply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               imply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.imply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.imply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.imply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void imply(in byte rA, in byte rB, ref byte rDst)
            => content(math.imply(content(rA), content(rB)), ref rDst);

        // [MethodImpl(Inline)]
        // public static unsafe void imply<T>(in T rA, in T rB, ref T rDst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte))
        //        imply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
        //     else if(typeof(T) == typeof(ushort))
        //        imply(in uint16(in rA), in uint16(in rB), ref uint16(ref rDst));
        //     else if(typeof(T) == typeof(uint))
        //        imply(in uint32(in rA), in uint32(in rB), ref uint32(ref rDst));
        //     else if(typeof(T) == typeof(ulong))
        //        imply(in uint64(in rA), in uint64(in rB), ref uint64(ref rDst));
        //     else
        //         throw unsupported<T>();
        // }

        // [MethodImpl(Inline)]
        // static unsafe void imply(in byte rA, in byte rB, ref byte rDst)
        //     => content(math.imply(content(rA), content(rB)), ref rDst);

        // [MethodImpl(Inline)]
        // static void imply(in ushort rA, in ushort rB, ref ushort rDst)
        //     => ginx.vimply(n, in rA, in rB, ref rDst);
        
        // [MethodImpl(Inline)]
        // static void imply(in uint rA, in uint rB, ref uint rDst)
        // {
        //     const int segments = 4;
        //     const int segsize = 8;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vimply(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        // }

        // [MethodImpl(Inline)]
        // static void imply(in ulong rA, in ulong rB, ref ulong rDst)
        // {
        //     const int segments = 16;
        //     const int segsize = 4;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vimply(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        // }

    }
}