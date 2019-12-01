//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vmax : IntrinsicTest<t_vmax>
    {
        public void max_128x8i()
            => max_check<sbyte>(n128);

        public void max_128x8u()
            => max_check<byte>(n128);

        public void max_128x16i()
            => max_check<short>(n128);

        public void max_128x16u()
            => max_check<ushort>(n128);

        public void max_128x32i()
            => max_check<int>(n128);

        public void max_128x32u()
            => max_check<uint>(n128);

        public void max_128x64i()
            => max_check<long>(n128);

        public void max_128x64u()
            => max_check<ulong>(n128);

        public void max_128x32f()
            => max_check<float>(n128);

        public void max_128x64f()
            => max_check<double>(n128);

        public void max_256x8i()
            => max_check<sbyte>(n256);

        public void max_256x8u()
            => max_check<byte>(n256);

        public void max_256x16i()
            => max_check<short>(n256);

        public void max_256x16u()
            => max_check<ushort>(n256);

        public void max_256x32i()
            => max_check<int>(n256);

        public void max_256x32u()
            => max_check<uint>(n256);

        public void max_256x64i()
            => max_check<long>(n256);

        public void max_256x64u()
            => max_check<ulong>(n256);

        public void max_256x32f()
            => max_check<float>(n256);

        public void max_256x64f()
            => max_check<double>(n256);


        public void max_block_28x8i()
            => max_block_check<sbyte>(n128);

        public void max_block_128x8u()
            => max_block_check<byte>(n128);

        public void max_block_128x16i()
            => max_block_check<short>(n128);

        public void max_block_128x16u()
            => max_block_check<ushort>(n128);

        public void max_block_128x32i()
            => max_block_check<int>(n128);

        public void max_block_128x32u()
            => max_block_check<uint>(n128);

        public void max_block_128x64i()
            => max_block_check<long>(n128);

        public void max_block_128x64u()
            => max_block_check<ulong>(n128);

        public void max_block_128x32f()
            => max_block_check<float>(n128);

        public void max_block_128x64f()
            => max_block_check<double>(n128);

        public void max_block_256x8i()
            => max_block_check<sbyte>(n256);

        public void max_block_256x8u()
            => max_block_check<byte>(n256);

        public void max_block_256x16i()
            => max_block_check<short>(n256);

        public void max_block_256x16u()
            => max_block_check<ushort>(n256);

        public void max_block_256x32i()
            => max_block_check<int>(n256);

        public void max_block_256x32u()
            => max_block_check<uint>(n256);

        public void max_block_256x64i()
            => max_block_check<long>(n256);

        public void max_block_256x64u()
            => max_block_check<ulong>(n256);

        public void max_block_256x32f()
            => max_block_check<float>(n256);

        public void max_block_256x64f()
            => max_block_check<double>(n256);
    }

}