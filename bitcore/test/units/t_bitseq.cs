//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bitseq : t_bitcore<t_bitseq>
    {
        public void sb_bitseq_8u()
            => sb_bitseq_check<byte>();

        public void sb_bitseq_8i()
            => sb_bitseq_check<sbyte>();

        public void sb_bitseq_16u()
            => sb_bitseq_check<ushort>();

        public void sb_bitseq_16i()
            => sb_bitseq_check<short>();

        public void sb_bitseq_32()
            => sb_bitseq_check<uint>();

        public void sb_bitseq_32i()
            => sb_bitseq_check<int>();

        public void sb_bitseq_64u()
            => sb_bitseq_check<ulong>();

        public void sb_bitseq_64i()
            => sb_bitseq_check<long>();

        public void sb_bitseq_32f()
            => sb_bitseq_check<float>();

        public void sb_bitseq_64f()
            => sb_bitseq_check<double>();
    }
}