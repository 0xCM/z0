//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_vor : t_vinx<t_vor>
    {
        public void vor_128x8i()
            => vor_check<sbyte>(n128);

        public void vor_128x8u()
            => vor_check<byte>(n128);            

        public void vor_128x16i()
            => vor_check<short>(n128);

        public void vor_128x16u()
            => vor_check<ushort>(n128);

        public void vor_128x32i()
            => vor_check<int>(n128);

        public void vor_128x32u()
            => vor_check<uint>(n128);            

        public void vor_128x64i()
            => vor_check<long>(n128);            

        public void vor_128x64u()
            => vor_check<ulong>(n128);            

        public void vor_256x8i()
            => vor_check<sbyte>(n256);

        public void vor_256x8u()
            => vor_check<byte>(n256);            

        public void vor_256x16i()
            => vor_check<short>(n256);

        public void vor_256x16u()
            => vor_check<ushort>(n256);

        public void vor_256x32i()
            => vor_check<int>(n256);

        public void vor_256x32u()
            => vor_check<uint>(n256);            

        public void vor_256x64i()
            => vor_check<long>(n256);            

        public void vor_256x64u()
            => vor_check<ulong>(n256);            

        public void vor_blocks_128x8i()
            => vor_blocks_check<sbyte>(n128);

        public void vor_blocks_256x8i()
            => vor_blocks_check<sbyte>(n256);

        public void vor_blocks_128x8u()
            => vor_blocks_check<byte>(n128);

        public void vor_blocks_128x16i()
            => vor_blocks_check<short>(n128);

        public void vor_blocks_128x16u()
            => vor_blocks_check<ushort>(n128);

        public void vor_blocks_128x32i()
            => vor_blocks_check<int>(n128);

        public void vor_blocks_128x32u()
            => vor_blocks_check<uint>(n128);

        public void vor_blocks_128x64i()
            => vor_blocks_check<long>(n128);

        public void vor_blocks_128x64u()
            => vor_blocks_check<ulong>(n128);

        public void vor_blocks_256x8u()
            => vor_blocks_check<byte>(n256);

        public void vor_blocks_256x16i()
            => vor_blocks_check<short>(n256);

        public void vor_blocks_256x16u()
            => vor_blocks_check<ushort>(n256);

        public void vor_blocks_256x32i()
            => vor_blocks_check<int>(n256);

        public void vor_blocks_256x32u()
            => vor_blocks_check<uint>(n256);

        public void vor_blocks_256x64i()
            => vor_blocks_check<long>(n256);

        public void vor_blocks_256x64u()
            => vor_blocks_check<ulong>(n256);

    }
}
