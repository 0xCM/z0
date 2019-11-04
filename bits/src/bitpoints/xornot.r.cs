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
        public static unsafe void xornot<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xornot(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
               xornot(in uint16(in rA), in uint16(in rB), ref uint16(ref rDst));
            else if(typeof(T) == typeof(uint))
               xornot(in uint32(in rA), in uint32(in rB), ref uint32(ref rDst));
            else if(typeof(T) == typeof(ulong))
               xornot(in uint64(in rA), in uint64(in rB), ref uint64(ref rDst));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void xornot(in byte rA, in byte rB, ref byte rDst)
            => content(math.xor(content(in rA), math.not(content(in rB))), ref rDst);

        [MethodImpl(Inline)]
        static void xornot(in ushort rA, in ushort rB, ref ushort rDst)
            => ginx.vstore(ginx.vxornot(n, in rA, in rB), ref rDst);
        
        [MethodImpl(Inline)]
        static void xornot(in uint rA, in uint rB, ref uint rDst)
        {
            const int segments = 4;
            const int segsize = 8;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vxornot(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        }

        [MethodImpl(Inline)]
        static void xornot(in ulong rA, in ulong rB, ref ulong rDst)
        {
            const int segments = 16;
            const int segsize = 4;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vxornot(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        }

    }
}