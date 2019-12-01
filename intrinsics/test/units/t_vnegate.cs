//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vnegate : IntrinsicTest<t_vnegate>
    {
        public void negate_128x8i()
            => negate_check<sbyte>(n128);

        public void negate_128x16i()
            => negate_check<short>(n128);

        public void negate_128x16u()
            => negate_check<ushort>(n128);

        public void negate_128x32i()
            => negate_check<int>(n128);

        public void negate_128x32u()
            => negate_check<uint>(n128);

        public void negate_128x64i()
            => negate_check<long>(n128);

        public void negate_128x64u()
            => negate_check<ulong>(n128);

        public void negate_128x32f()
            => negate_check<float>(n128);

        public void negate_128x64f()
            => negate_check<double>(n128);

        public void negate_256x8i()
            => vnegate_check<sbyte>(n256);

        public void negate_256x8u()
            => vnegate_check<byte>(n256);

        public void negate_256x16i()
            => vnegate_check<short>(n256);

        public void negate_256x16u()
            => vnegate_check<ushort>(n256);

        public void negate_256x32i()
            => vnegate_check<int>(n256);

        public void negate_256x32u()
            => vnegate_check<uint>(n256);

        public void negate_256x64i()
            => vnegate_check<long>(n256);

        public void negate_256x64u()
            => vnegate_check<ulong>(n256);

        public void negate_256x32f()
            => vnegate_check<float>(n256);

        public void negate_256x64f()
            => vnegate_check<double>(n256);

        public void negate_blocks_128x8i()
            => vnegate_blocks_check<sbyte>(n128);

        public void negate_blocks_128x8u()
            => vnegate_blocks_check<byte>(n128);

        public void negate_blocks_128x16i()
            => vnegate_blocks_check<short>(n128);

        public void negate_blocks_128x16u()
            => vnegate_blocks_check<ushort>(n128);

        public void negate_blocks_128x32i()
            => vnegate_blocks_check<int>(n128);

        public void negate_blocks_128x32u()
            => vnegate_blocks_check<uint>(n128);

        public void negate_blocks_128x64i()
            => vnegate_blocks_check<long>(n128);

        public void negate_blocks_128x64u()
            => vnegate_blocks_check<ulong>(n128);

        public void negate_blocks_256x8i()
            => vnegate_blocks_check<sbyte>(n256);

        public void negate_blocks_256x8u()
            => vnegate_blocks_check<byte>(n256);

        public void negate_blocks_256x16i()
            => vnegate_blocks_check<short>(n256);

        public void negate_blocks_256x16u()
            => vnegate_blocks_check<ushort>(n256);

        public void negate_blocks_256x32i()
            => vnegate_blocks_check<int>(n256);

        public void negate_blocks_256x32u()
            => vnegate_blocks_check<uint>(n256);

        public void negate_blocks_256x64i()
            => vnegate_blocks_check<long>(n256);

        public void negate_blocks_256x64u()
            => vnegate_blocks_check<ulong>(n256);
   }
}