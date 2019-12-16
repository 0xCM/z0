//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vnegate : t_vinx<t_vnegate>
    {
        public void vnegate_128x8i()
            => vnegate_check<sbyte>(n128,z8i);

        public void vnegate_128x16i()
            => vnegate_check<short>(n128,z16i);

        public void vnegate_128x16u()
            => vnegate_check<ushort>(n128,z16);

        public void vnegate_128x32i()
            => vnegate_check<int>(n128,z32i);

        public void vnegate_128x32u()
            => vnegate_check<uint>(n128);

        public void vnegate_128x64i()
            => vnegate_check<long>(n128);

        public void vnegate_128x64u()
            => vnegate_check<ulong>(n128);

        public void vnegate_128x32f()
            => vnegate_check<float>(n128);

        public void vnegate_128x64f()
            => vnegate_check<double>(n128);

        public void vnegate_256x8i()
            => vnegate_check<sbyte>(n256);

        public void vnegate_256x8u()
            => vnegate_check<byte>(n256);

        public void vnegate_256x16i()
            => vnegate_check<short>(n256);

        public void vnegate_256x16u()
            => vnegate_check<ushort>(n256);

        public void vnegate_256x32i()
            => vnegate_check<int>(n256);

        public void vnegate_256x32u()
            => vnegate_check<uint>(n256);

        public void vnegate_256x64i()
            => vnegate_check<long>(n256);

        public void vnegate_256x64u()
            => vnegate_check<ulong>(n256);

        public void vnegate_256x32f()
            => vnegate_check<float>(n256);

        public void vnegate_256x64f()
            => vnegate_check<double>(n256);

        public void vnegate_blocks_128x8i()
            => vnegate_blocks_check<sbyte>(n128);

        public void vnegate_blocks_128x8u()
            => vnegate_blocks_check<byte>(n128);

        public void vnegate_blocks_128x16i()
            => vnegate_blocks_check<short>(n128);

        public void vnegate_blocks_128x16u()
            => vnegate_blocks_check<ushort>(n128);

        public void vnegate_blocks_128x32i()
            => vnegate_blocks_check<int>(n128);

        public void vnegate_blocks_128x32u()
            => vnegate_blocks_check<uint>(n128);

        public void vnegate_blocks_128x64i()
            => vnegate_blocks_check<long>(n128);

        public void vnegate_blocks_128x64u()
            => vnegate_blocks_check<ulong>(n128);

        public void vnegate_blocks_256x8i()
            => vnegate_blocks_check(n256,z8i);

        public void vnegate_blocks_256x8u()
            => vnegate_blocks_check<byte>(n256);

        public void vnegate_blocks_256x16i()
            => vnegate_blocks_check<short>(n256);

        public void vnegate_blocks_256x16u()
            => vnegate_blocks_check<ushort>(n256);

        public void vnegate_blocks_256x32i()
            => vnegate_blocks_check<int>(n256);

        public void vnegate_blocks_256x32u()
            => vnegate_blocks_check<uint>(n256);

        public void vnegate_blocks_256x64i()
            => vnegate_blocks_check<long>(n256);

        public void vnegate_blocks_256x64u()
            => vnegate_blocks_check<ulong>(n256);
   }
}