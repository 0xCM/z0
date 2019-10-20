//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {
        public static ref ulong mask_1x64u_ref(ref ulong dst, int exp0)
            => ref Bits.mask(ref dst, exp0);        

        public static ref ulong mask_2x64u_ref(ref ulong dst, int exp0, int exp1)
            => ref Bits.mask(ref dst, exp0, exp1);        

        public static ref ulong mask_3x64u_ref(ref ulong dst, int exp0, int exp1, int exp2)
            => ref Bits.mask(ref dst, exp0, exp1, exp2);        

        public static ulong mask_3x64u(ulong src, int exp0, int exp1, int exp2)
            => Bits.mask(src, exp0, exp1, exp2);

        public static ref ulong mask_4x64u_ref(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
            => ref Bits.mask(ref dst, exp0, exp1, exp2, exp3);        

    }

}