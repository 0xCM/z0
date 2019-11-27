//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
        
    public class t_sb_bitview : t_sb<t_sb_bitview>
    {
        public void gsb_bitview_8()
            => sb_bitview_check<byte>();

        public void gsb_bitview_16()
            => sb_bitview_check<ushort>();

        public void gsb_bitview_32()
            => sb_bitview_check<uint>();

        public void gsb_bitview_64()
            => sb_bitview_check<ulong>();
    }
}