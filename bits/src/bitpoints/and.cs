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
        static N256 n => n256;

        [MethodImpl(Inline)]
        public static void and<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               and(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.and(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.and(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.and(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void and(in byte rA, in byte rB, ref byte rDst)
            => content(math.and(content(rA), content(rB)), ref rDst);

        // [MethodImpl(Inline)]
        // static void and(in ushort rA, in ushort rB, ref ushort rDst)
        //     => ginx.vand(n, in rA, in rB, ref rDst);
        
        // [MethodImpl(Inline)]
        // static void and(in uint rA, in uint rB, ref uint rDst)
        // {
        //     const int segments = 4;
        //     const int segsize = 8;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vand(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        // }

        // [MethodImpl(Inline)]
        // static void and(in ulong rA, in ulong rB, ref ulong rDst)
        // {
        //     const int segments = 16;
        //     const int segsize = 4;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vand(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        // }

    }
}