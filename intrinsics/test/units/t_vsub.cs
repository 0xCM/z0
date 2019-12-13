//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class tv_sub : t_vinx<tv_sub>
    {        
        public void vsub_128x8i()
            => vsub_check<sbyte>(n128);

        public void vsub_128x8u()
            => vsub_check<byte>(n128);            

        public void vsub_128x16i()
            => vsub_check<short>(n128);            

        public void vsub_128x16u()
            => vsub_check<ushort>(n128);            

        public void vsub_128x32i()
            => vsub_check<int>(n128);            

        public void vsub_128x32u()
            => vsub_check<uint>(n128);            

        public void vsub_128x64i()
            => vsub_check<long>(n128);

        public void vsub_128x64u()
            => vsub_check<ulong>(n128);

        public void vsub_256x8i()
            => vsub_check<sbyte>(n256);

        public void vsub_256x8u()
            => vsub_check<byte>(n256);

        public void vsub_256x16i()
            => vsub_check<short>(n256);

        public void vsub_256x16u()
            => vsub_check<ushort>(n256);

        public void vsub_256x32i()
            => vsub_check<int>(n256);            

        public void vsub_256x32u()
            => vsub_check<uint>(n256);            

        public void vsub_256x64i()
            => vsub_check<long>(n256);

        public void vsub_256x64u()
            => vsub_check<ulong>(n256);

        public void sub_block_256x8u()
            => vsub_block_check<byte>(n256);

        public void sub_block_256x64i()
            => vsub_block_check<long>(n256);

        public void sub_block_256x32i()
            => vsub_block_check<int>(n256);
    }
}