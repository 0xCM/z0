//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_zerohi : t_bitcore<t_sb_zerohi>
    {    
        public void sb_zerohi_8u()
            => sb_zerohi_check<byte>();

        public void sb_zerohi_16u()
            => sb_zerohi_check<ushort>();

        public void sb_zerohi_32u()
            => sb_zerohi_check<uint>();

        public void sb_zerohi_64u()
            => sb_zerohi_check<ulong>();
    }
}
