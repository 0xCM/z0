//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class inxvoc
    {

        public static Vec256<byte> pattern_lanemerge_8u()            
            => Vec256Pattern.LaneMerge<byte>();

        public static Vec256<ushort> pattern_lanemerge_16u()            
            => Vec256Pattern.LaneMerge<ushort>();

    }

}