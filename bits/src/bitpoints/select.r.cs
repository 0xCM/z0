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
        public static unsafe void select<T>(in T rA, in T rB, in T rC, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               select(in uint8(in rA), in uint8(in rB), in uint8(in rC), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
               select(in uint16(in rA), in uint16(in rB), in uint16(in rC), ref uint16(ref rDst));
            else if(typeof(T) == typeof(uint))
               select(in uint32(in rA), in uint32(in rB), in uint32(in rC), ref uint32(ref rDst));
            else if(typeof(T) == typeof(ulong))
               select(in uint64(in rA), in uint64(in rB), in uint64(in rC), ref uint64(ref rDst));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void select(in byte rA, in byte rB, in byte rC, ref byte rDst)
            => content(gmath.select(content(rA), content(rB), content(rC)), ref rDst);

        [MethodImpl(Inline)]
        static void select(in ushort rA, in ushort rB, in ushort rC, ref ushort rDst)
            => ginx.vselect(n, in rA, in rB, in rC, ref rDst);
        
        [MethodImpl(Inline)]
        static void select(in uint rA, in uint rB, in uint rC, ref uint rDst)
        {
            const int segments = 4;
            const int segsize = 8;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vselect(n, in skip(in rA, offset), in skip(in rB, offset), in skip(in rC, offset), ref seek(ref rDst, offset));
        }

        [MethodImpl(Inline)]
        static void select(in ulong rA, in ulong rB, in ulong rC, ref ulong rDst)
        {
            const int segments = 16;
            const int segsize = 4;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vselect(n, in skip(in rA, offset), in skip(in rB, offset), in skip(in rC, offset), ref seek(ref rDst, offset));
        }

    }
}