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

    partial class BitPoints
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
        static void nor(in byte rA, in byte rB, ref byte rDst)
            => content(math.nor(content(rA), content(rB)), ref rDst);
    }
}