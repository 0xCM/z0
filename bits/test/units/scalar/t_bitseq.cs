//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bitseq : ScalarBitTest<t_bitseq>
    {

        public void bitseq_8u()
            => bitseq_check<byte>();

        public void bitseq_8i()
            => bitseq_check<sbyte>();

        public void bitseq_16u()
            => bitseq_check<ushort>();

        public void bitseq_16i()
            => bitseq_check<short>();

        public void bitseq_32()
            => bitseq_check<uint>();

        public void bitseq_32i()
            => bitseq_check<int>();

        public void bitseq_64u()
            => bitseq_check<ulong>();

        public void bitseq_64i()
            => bitseq_check<long>();

        public void bitseq_32f()
            => bitseq_check<float>();

        public void bitseq_64f()
            => bitseq_check<double>();

        public void bitchars_8u()
            => bitchars_check<byte>();

        public void bitchars_8i()
            => bitchars_check<sbyte>();

        public void bitchars_16u()
            => bitchars_check<ushort>();

        public void bitchars_16i()
            => bitchars_check<short>();

        public void bitchars_32()
            => bitchars_check<uint>();

        public void bitchars_32i()
            => bitchars_check<int>();

        public void bitchars_64u()
            => bitchars_check<ulong>();

        public void bitchars_64i()
            => bitchars_check<long>();

        public void bitchars_32f()
            => bitchars_check<float>();

        public void bitchars_64f()
            => bitchars_check<double>();

        void bitchars_check<T>()
            where T : unmanaged
        {
            Span<char> s0 = stackalloc char[bitsize<T>()];
            ReadOnlySpan<char> s1 = default;
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<T>();
                gbits.bitchars(a,s0);
                s1 = gbits.bitchars(a);
                Claim.eq(s0, s1);

                s0.Reverse();
                var textA = s0.Format();
                var textB = BitString.from(a).Format();
                Claim.eq(textA, textB);
            }
        }

        void bitseq_check<T>()
            where T : unmanaged
        {
            Span<byte> s0 = stackalloc byte[bitsize<T>()];
            Span<byte> s1 = stackalloc byte[bitsize<T>()];
            ReadOnlySpan<byte> s2 = default;
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<T>();
                gbits.bitseq(a,s0);
                gbits.bitseq(a,s1);
                s2 = gbits.bitseq(a);
                Claim.eq(s0, s1);
                Claim.eq(s1, s2);
            }
        }
    }

}