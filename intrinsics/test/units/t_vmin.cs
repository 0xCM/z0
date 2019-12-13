//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vmin : t_vinx<t_vmin>
    {
        public void min_128x8i()
            => vmin_check<sbyte>(n128);

        public void min_128x8u()
            => vmin_check<byte>(n128);

        public void min_128x16i()
            => vmin_check<short>(n128);

        public void min_128x16u()
            => vmin_check<ushort>(n128);

        public void min_128x32i()
            => vmin_check<int>(n128);

        public void min_128x32u()
            => vmin_check<uint>(n128);

        public void min_128x64i()
            => vmin_check<long>(n128);

        public void min_128x64u()
            => vmin_check<ulong>(n128);

        public void min_256x8i()
            => vmin_check<sbyte>(n256);

        public void min_256x8u()
            => vmin_check<byte>(n256);

        public void min_256x16i()
            => vmin_check<short>(n256);

        public void min_256x16u()
            => vmin_check<ushort>(n256);

        public void min_256x32i()
            => vmin_check<int>(n256);

        public void min_256x32u()
            => vmin_check<uint>(n256);

        public void min_256x64i()
            => vmin_check<long>(n256);

        public void min_256x64u()
            => vmin_check<ulong>(n256);

        public void min_block_28x8i()
            => vmin_block_check<sbyte>(n128);

        public void min_block_128x8u()
            => vmin_block_check<byte>(n128);

        public void min_block_128x16i()
            => vmin_block_check<short>(n128);

        public void min_block_128x16u()
            => vmin_block_check<ushort>(n128);

        public void min_block_128x32i()
            => vmin_block_check<int>(n128);

        public void min_block_128x32u()
            => vmin_block_check<uint>(n128);

        public void min_block_128x64i()
            => vmin_block_check<long>(n128);

        public void min_block_128x64u()
            => vmin_block_check<ulong>(n128);

        public void min_block_128x32f()
            => vmin_block_check<float>(n128);

        public void min_block_128x64f()
            => vmin_block_check<double>(n128);

        public void min_block_256x8i()
            => vmin_block_check<sbyte>(n256);

        public void min_block_256x8u()
            => vmin_block_check<byte>(n256);

        public void min_block_256x16i()
            => vmin_block_check<short>(n256);

        public void min_block_256x16u()
            => vmin_block_check<ushort>(n256);

        public void min_block_256x32i()
            => vmin_block_check<int>(n256);

        public void min_block_256x32u()
            => vmin_block_check<uint>(n256);

        public void min_block_256x64i()
            => vmin_block_check<long>(n256);

        public void min_block_256x64u()
            => vmin_block_check<ulong>(n256);

        public void min_block_256x32f()
            => vmin_block_check<float>(n256);

        public void min_block_256x64f()
            => vmin_block_check<double>(n256);
    }
}