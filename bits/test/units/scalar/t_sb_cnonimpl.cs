//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
 
    public class t_sb_cnonimpl : t_sb<t_sb_cnonimpl>
    {

        public void sb_cnonimpl_8u()
            => sb_cnonimpl_check<byte>();

        public void sb_cnonimpl_16u()
            => sb_cnonimpl_check<ushort>();

        public void sb_cnonimpl_32u()
            => sb_cnonimpl_check<uint>();

        public void sb_cnonimpl_64u()
            => sb_cnonimpl_check<ulong>();

    }
}