//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vadd : t_vinx<t_vadd>
    {
        public void add_128x8i()
            => add_check<sbyte>(n128);

        public void add_128x8u()
            => add_check<byte>(n128);

        public void add_128x16u()
            => add_check<ushort>(n128);

        public void add_128x16i()
            => add_check<short>(n128);

        public void add_128x32i()
            => add_check<int>(n128);

        public void add_128x32u()
            => add_check<int>(n128);

        public void add_128x64u()
            => add_check<ulong>(n128);

        public void and_128x64i()
            => add_check<long>(n128);

        public void add_256x8i()
            => add_check<sbyte>(n256);

        public void add_256x8u()
            => add_check<byte>(n256);

        public void add_256x16u()
            => add_check<ushort>(n256);

        public void add_256x16i()
            => add_check<short>(n256);

        public void add_256x32i()
            => add_check<int>(n256);

        public void add_256x32u()
            => add_check<int>(n256);

        public void add_256x64u()
            => add_check<ulong>(n256);

        public void and_256x64i()
            => add_check<long>(n256);

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