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
            => sub_check<sbyte>(n128);

        public void vsub_128x8u()
            => sub_check<byte>(n128);            

        public void vsub_128x16i()
            => sub_check<short>(n128);            

        public void vsub_128x16u()
            => sub_check<ushort>(n128);            

        public void vsub_128x32i()
            => sub_check<int>(n128);            

        public void vsub_128x32u()
            => sub_check<uint>(n128);            

        public void vsub_128x64i()
            => sub_check<long>(n128);

        public void vsub_128x64u()
            => sub_check<ulong>(n128);

        public void vsub_256x8i()
            => sub_check<sbyte>(n256);

        public void vsub_256x8u()
            => sub_check<byte>(n256);

        public void vsub_256x16i()
            => sub_check<short>(n256);

        public void vsub_256x16u()
            => sub_check<ushort>(n256);

        public void vsub_256x32i()
            => sub_check<int>(n256);            

        public void vsub_256x32u()
            => sub_check<uint>(n256);            

        public void vsub_256x64i()
            => sub_check<long>(n256);

        public void vsub_256x64u()
            => sub_check<ulong>(n256);

        public void sub_block_256x8u()
            => sub_block_check<byte>(n256);

        public void sub_block_256x64i()
            => sub_block_check<long>(n256);

        public void sub_block_256x32i()
            => sub_block_check<int>(n256);
    }
}