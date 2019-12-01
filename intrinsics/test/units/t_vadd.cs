//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vadd : IntrinsicTest<t_vadd>
    {
        public void add_128x8i()
            => add128_check<sbyte>();

        public void add_128x8u()
            => add128_check<byte>();

        public void add_128x16u()
            => add128_check<ushort>();

        public void add_128x16i()
            => add128_check<short>();

        public void add_128x32i()
            => add128_check<int>();

        public void add_128x32u()
            => add128_check<int>();

        public void add_128x64u()
            => add128_check<ulong>();

        public void and_128x64i()
            => add128_check<long>();

        public void add_256x8i()
            => add256_check<sbyte>();

        public void add_256x8u()
            => add256_check<byte>();

        public void add_256x16u()
            => add256_check<ushort>();

        public void add_256x16i()
            => add256_check<short>();

        public void add_256x32i()
            => add256_check<int>();

        public void add_256x32u()
            => add256_check<int>();

        public void add_256x64u()
            => add256_check<ulong>();

        public void and_256x64i()
            => add256_check<long>();

        public void add_blocks_128x8i()
            => add_blocks_check<sbyte>(n128);

        public void add_blocks_128x8u()
            => add_blocks_check<byte>(n128);

        public void add_blocks_128x16i()
            => add_blocks_check<short>(n128);

        public void add_blocks_128x16u()
            => add_blocks_check<ushort>(n128);

        public void add_blocks_128x32i()
            => add_blocks_check<int>(n128);

        public void add_blocks_128x32u()
            => add_blocks_check<uint>(n128);

        public void add_blocks_128x64i()
            => add_blocks_check<long>(n128);

        public void add_blocks_128x64u()
            => add_blocks_check<ulong>(n128);

        public void add_blocks_256x8i()
            => add_blocks_check<sbyte>(n256);

        public void add_blocks_256x8u()
            => add_blocks_check<byte>(n256);

        public void add_blocks_256x16i()
            => add_blocks_check<short>(n256);

        public void add_blocks_256x16u()
            => add_blocks_check<ushort>(n256);

        public void add_blocks_256x32i()
            => add_blocks_check<int>(n256);

        public void add_blocks_256x32u()
            => add_blocks_check<uint>(n256);

        public void add_blocks_256x64i()
            => add_blocks_check<long>(n256);

        public void add_blocks_256x64u()
            => add_blocks_check<ulong>(n256);

 
    }

}