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
            => sb_bitseq_check<byte>();

        public void bitseq_8i()
            => sb_bitseq_check<sbyte>();

        public void bitseq_16u()
            => sb_bitseq_check<ushort>();

        public void bitseq_16i()
            => sb_bitseq_check<short>();

        public void bitseq_32()
            => sb_bitseq_check<uint>();

        public void bitseq_32i()
            => sb_bitseq_check<int>();

        public void bitseq_64u()
            => sb_bitseq_check<ulong>();

        public void bitseq_64i()
            => sb_bitseq_check<long>();

        public void bitseq_32f()
            => sb_bitseq_check<float>();

        public void bitseq_64f()
            => sb_bitseq_check<double>();
    }
}