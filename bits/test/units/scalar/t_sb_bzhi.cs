//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_bzhi : t_sb<t_sb_bzhi>
    {    
        public void bzhi_8u_check()
            => bzhi_check<byte>();

        public void bzhi_16u_check()
            => bzhi_check<ushort>();

        public void bzhi_32u_check()
            => bzhi_check<uint>();

        public void bzhi_64u_check()
            => bzhi_check<ulong>();
    }
}
