//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_bitseq : t_sb<t_sb_bitseq>
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
    }
}