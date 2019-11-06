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
        public static void nor<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nor(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.nor(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.nor(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.nor(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void nor(in byte rA, in byte rB, ref byte rDst)
            => content(math.nor(content(rA), content(rB)), ref rDst);

    //     [MethodImpl(Inline)]
    //     public static void nor<T>(in T rA, in T rB, ref T rDst)
    //         where T : unmanaged
    //     {
    //         if(typeof(T) == typeof(byte))
    //            nor(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
    //         else if(typeof(T) == typeof(ushort))
    //            nor(in uint16(in rA), in uint16(in rB), ref uint16(ref rDst));
    //         else if(typeof(T) == typeof(uint))
    //            nor(in uint32(in rA), in uint32(in rB), ref uint32(ref rDst));
    //         else if(typeof(T) == typeof(ulong))
    //            nor(in uint64(in rA), in uint64(in rB), ref uint64(ref rDst));
    //         else
    //             throw unsupported<T>();
    //     }

    //     [MethodImpl(Inline)]
    //     static unsafe void nor(in byte rA, in byte rB, ref byte rDst)
    //         => content(math.nor(content(rA), content(rB)), ref rDst);

    //     [MethodImpl(Inline)]
    //     static void nor(in ushort rA, in ushort rB, ref ushort rDst)
    //         => ginx.vnor(n, in rA, in rB, ref rDst);
        
    //     [MethodImpl(Inline)]
    //     static void nor(in uint rA, in uint rB, ref uint rDst)
    //     {
    //         const int segments = 4;
    //         const int segsize = 8;
    //         for(int i=0, offset = 0; i < segments; i++, offset += segsize)
    //             ginx.vnor(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
    //     }

    //     [MethodImpl(Inline)]
    //     static void nor(in ulong rA, in ulong rB, ref ulong rDst)
    //     {
    //         const int segments = 16;
    //         const int segsize = 4;
    //         for(int i=0, offset = 0; i < segments; i++, offset += segsize)
    //             ginx.vnor(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
    //     }

    }
}