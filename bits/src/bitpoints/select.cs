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
                gparts.select(n, in rA, in rB, in rC, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.select(n, 4, 8, in rA, in rB, in rC, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.select(n, 16, 4, in rA, in rB, in rC, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void select(in byte rA, in byte rB, in byte rC, ref byte rDst)
            => content(gmath.select(content(rA), content(rB), content(rC)), ref rDst);

    }
}