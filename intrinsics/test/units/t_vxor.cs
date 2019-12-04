//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_vxor : t_vinx<t_vxor>
    {
        public void vxor_128x8i()
            => vxor_check<sbyte>(n128);

        public void vxor_128x8u()
            => vxor_check<byte>(n128);            

        public void vxor_128x16i()
            => vxor_check<short>(n128);

        public void vxor_128x16u()
            => vxor_check<ushort>(n128);

        public void vxor_128x32i()
            => vxor_check<int>(n128);

        public void vxor_128x32u()
            => vxor_check<uint>(n128);            

        public void vxor_128x64i()
            => vxor_check<long>(n128);            

        public void vxor_128x64u()
            => vxor_check<ulong>(n128);            

        public void vxor_256x8i()
            => vxor_check<sbyte>(n256);

        public void vxor_256x8u()
            => vxor_check<byte>(n256);            

        public void vxor_256x16i()
            => vxor_check<short>(n256);

        public void vxor_256x16u()
            => vxor_check<ushort>(n256);

        public void vxor_256x32i()
            => vxor_check<int>(n256);

        public void vxor_256x32u()
            => vxor_check<uint>(n256);            

        public void vxor_256x64i()
            => vxor_check<long>(n256);            

        public void vxor_256x64u()
            => vxor_check<ulong>(n256);            

        public void vxor_blocks_128x8i()
            => vxor_blocks_check<sbyte>(n128);

        public void vxor_blocks_256x8i()
            => vxor_blocks_check<sbyte>(n256);

        public void vxor_blocks_128x8u()
            => vxor_blocks_check<byte>(n128);

        public void vxor_blocks_128x16i()
            => vxor_blocks_check<short>(n128);

        public void vxor_blocks_128x16u()
            => vxor_blocks_check<ushort>(n128);

        public void vxor_blocks_128x32i()
            => vxor_blocks_check<int>(n128);

        public void vxor_blocks_128x32u()
            => vxor_blocks_check<uint>(n128);

        public void vxor_blocks_128x64i()
            => vxor_blocks_check<long>(n128);

        public void vxor_blocks_128x64u()
            => vxor_blocks_check<ulong>(n128);

        public void vxor_blocks_256x8u()
            => vxor_blocks_check<byte>(n256);

        public void vxor_blocks_256x16i()
            => vxor_blocks_check<short>(n256);

        public void vxor_blocks_256x16u()
            => vxor_blocks_check<ushort>(n256);

        public void vxor_blocks_256x32i()
            => vxor_blocks_check<int>(n256);

        public void vxor_blocks_256x32u()
            => vxor_blocks_check<uint>(n256);

        public void vxor_blocks_256x64i()
            => vxor_blocks_check<long>(n256);

        public void vxor_blocks_256x64u()
            => vxor_blocks_check<ulong>(n256);

        public void vxor_bench_256x32u()
            => vxor_bench<uint>(n256);

        public void vxor_bench_256x8u()
            => vxor_bench<byte>(n256);

        public void vxor_bench_256x64u()
            => vxor_bench<ulong>(n256);

    }
}
