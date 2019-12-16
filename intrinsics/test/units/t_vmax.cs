//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vmax : t_vinx<t_vmax>
    {
        public void max_128x8i()
            => vmax_check<sbyte>(n128,z8i);

        public void max_128x8u()
            => vmax_check<byte>(n128,z8);

        public void max_128x16i()
            => vmax_check<short>(n128,z16i);

        public void max_128x16u()
            => vmax_check<ushort>(n128,z16);

        public void max_128x32i()
            => vmax_check<int>(n128,z32i);

        public void max_128x32u()
            => vmax_check<uint>(n128);

        public void max_128x64i()
            => vmax_check<long>(n128);

        public void max_128x64u()
            => vmax_check<ulong>(n128);

        public void max_128x32f()
            => vmax_check<float>(n128);

        public void max_128x64f()
            => vmax_check<double>(n128);

        public void max_256x8i()
            => vmax_check<sbyte>(n256);

        public void max_256x8u()
            => vmax_check<byte>(n256);

        public void max_256x16i()
            => vmax_check<short>(n256);

        public void max_256x16u()
            => vmax_check<ushort>(n256);

        public void max_256x32i()
            => vmax_check<int>(n256);

        public void max_256x32u()
            => vmax_check<uint>(n256);

        public void max_256x64i()
            => vmax_check<long>(n256);

        public void max_256x64u()
            => vmax_check<ulong>(n256);

        public void max_256x32f()
            => vmax_check<float>(n256);

        public void max_256x64f()
            => vmax_check<double>(n256);


        public void max_block_28x8i()
            => vmax_block_check<sbyte>(n128);

        public void max_block_128x8u()
            => vmax_block_check<byte>(n128);

        public void max_block_128x16i()
            => vmax_block_check<short>(n128);

        public void max_block_128x16u()
            => vmax_block_check<ushort>(n128);

        public void max_block_128x32i()
            => vmax_block_check<int>(n128);

        public void max_block_128x32u()
            => vmax_block_check<uint>(n128);

        public void max_block_128x64i()
            => vmax_block_check<long>(n128);

        public void max_block_128x64u()
            => vmax_block_check<ulong>(n128);

        public void max_block_128x32f()
            => vmax_block_check<float>(n128);

        public void max_block_128x64f()
            => vmax_block_check<double>(n128);

        public void max_block_256x8i()
            => vmax_block_check<sbyte>(n256);

        public void max_block_256x8u()
            => vmax_block_check<byte>(n256);

        public void max_block_256x16i()
            => vmax_block_check<short>(n256);

        public void max_block_256x16u()
            => vmax_block_check<ushort>(n256);

        public void max_block_256x32i()
            => vmax_block_check<int>(n256);

        public void max_block_256x32u()
            => vmax_block_check<uint>(n256);

        public void max_block_256x64i()
            => vmax_block_check<long>(n256);

        public void max_block_256x64u()
            => vmax_block_check<ulong>(n256);

        public void max_block_256x32f()
            => vmax_block_check<float>(n256);

        public void max_block_256x64f()
            => vmax_block_check<double>(n256);
    }
}