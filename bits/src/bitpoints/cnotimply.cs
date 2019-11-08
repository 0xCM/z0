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
        public static void cnotimply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cnotimply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.cnotimply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.cnotimply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.cnotimply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void cnotimply(in byte rA, in byte rB, ref byte rDst)
            => content(math.cnotimply(content(rA), content(rB)), ref rDst);

   }
}