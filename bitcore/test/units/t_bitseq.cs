//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bitseq : t_bitcore<t_bitseq>
    {
        public void bitseq_8u()
            => bitseq_check(z8);

        public void bitseq_8i()
            => bitseq_check(z8i);

        public void bitseq_16u()
            => bitseq_check(z16);

        public void bitseq_16i()
            => bitseq_check(z16i);

        public void bitseq_32()
            => bitseq_check(z32);

        public void bitseq_32i()
            => bitseq_check(z32i);

        public void bitseq_64u()
            => bitseq_check(z64);

        public void bitseq_64i()
            => bitseq_check(z64i);

        public void bitseq_32f()
            => bitseq_check(z32f);

        public void bitseq_64f()
            => bitseq_check(z64f);

        void bitseq_check<T>(T t = default)
            where T : unmanaged
        {
            Span<byte> s0 = stackalloc byte[bitsize<T>()];
            Span<byte> s1 = stackalloc byte[bitsize<T>()];
            ReadOnlySpan<byte> s2 = default;
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<T>();
                gbits.storeseq(a,s0);
                gbits.storeseq(a,s1);
                s2 = gbits.storeseq(a);
                Claim.numeq(s0, s1);
                Claim.numeq(s1, s2);
            }
        }
    }
}