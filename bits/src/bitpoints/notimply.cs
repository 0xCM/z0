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
        public static void notimply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               notimply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.notimply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.notimply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.notimply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void notimply(in byte rA, in byte rB, ref byte rDst)
            => content(math.notimply(content(rA), content(rB)), ref rDst);
    }
}