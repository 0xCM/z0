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
        public static void not<T>(in T rA, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               not(in uint8(in rA), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.not(n, in rA, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.not(n, 4, 8, in rA, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.not(n, 16, 4, in rA, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void not(in byte rA, ref byte rDst)
            => content(math.not(content(rA)), ref rDst);
    }
}