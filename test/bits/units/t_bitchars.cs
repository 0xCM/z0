//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public class t_bitchars : t_bitcore<t_bitchars>
    {
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

        protected void bitchars_check<T>(T t = default)
            where T : unmanaged
        {
            Span<char> s0 = stackalloc char[bitwidth<T>()];
            ReadOnlySpan<char> s1 = default;
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<T>();
                BitString.bitchars(a,s0);
                s1 = BitString.bitchars(a);
                ClaimPrimalSeq.eq(s0, s1);

                s0.Reverse();
                var textA = s0.Concat();
                var textB = BitString.scalar(a).Format();
                ClaimPrimalSeq.eq(textA, textB);
            }
        }
    }

}