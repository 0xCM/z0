//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_bitchars : t_sb<t_sb_bitchars>
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
    }

}