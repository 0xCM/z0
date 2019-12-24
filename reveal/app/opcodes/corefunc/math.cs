//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class zfoc
    {

        public static Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
            => Math128.sub(a,b);

        public static void sub_128u_b(in ulong a, in ulong b, ref ulong c)
            => Math128.sub(a,b, ref c);

            

        public static void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
            => Math128.mul(in src, ref dst);

        public static Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.add(a,b);

        public static Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.xor(a,b);

        public static Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.xnor(a,b);

        public static Pair<ulong> negate_128u(Pair<ulong> a)
            => Math128.negate(a);


        public static ref Pair<ulong> inc_128u(ref Pair<ulong> a)
            => ref Math128.inc(ref a);

        public static Pair<ulong> srl_128u(Pair<ulong> a, int offset)
            => Math128.srl(a, offset);

        public static Pair<ulong> sll_128u(Pair<ulong> a, int offset)
            => Math128.sll(a, offset);

        public static bit same_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.same(a,b);

        public static bit lt_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.lt(a,b);

        public static bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
            => Math128.gteq(a,b);

        public static void mul_32u(Pair<uint> src, ref Pair<uint> dst)
            => Math128.mul(src, ref dst);

        public static uint mod_const_16(uint a)
            => Mod16.mod(a);

        public static uint div_const_16(uint a)
            => Mod16.div(a);

        public static uint mod_const_25(uint a)
            => Mod25.mod(a);

        public static uint div_const_25(uint a)
            => Mod25.div(a);

        public static uint mod_const_32(uint a)
            => Mod32.mod(a);

        public static uint div_const_32(uint a)
            => Mod32.div(a);
    }

}