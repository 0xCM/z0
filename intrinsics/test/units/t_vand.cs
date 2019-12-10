//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vand : t_vinx<t_vand>
    {
        public void vand_128x8i()
            => vand_check<sbyte>(n128);

        public void vand_128x8u()
            => vand_check<byte>(n128);            

        public void vand_128x16i()
            => vand_check<short>(n128);

        public void vand_128x16u()
            => vand_check<ushort>(n128);

        public void vand_128x32i()
            => vand_check<int>(n128);

        public void vand_128x32u()
            => vand_check<uint>(n128);            

        public void vand_128x64i()
            => vand_check<long>(n128);            

        public void vand_128x64u()
            => vand_check<ulong>(n128);            

        public void vand_256x8i()
            => vand_check<sbyte>(n256);

        public void vand_256x8u()
            => vand_check<byte>(n256);            

        public void vand_256x16i()
            => vand_check<short>(n256);

        public void vand_256x16u()
            => vand_check<ushort>(n256);

        public void vand_256x32i()
            => vand_check<int>(n256);

        public void vand_256x32u()
            => vand_check<uint>(n256);            

        public void vand_256x64i()
            => vand_check<long>(n256);            

        public void vand_256x64u()
            => vand_check<ulong>(n256);            

        public void and_blocks_128x8i()
            => and_blocks_check<sbyte>(n128);

        public void and_blocks_128x8u()
            => and_blocks_check<byte>(n128);

        public void and_blocks_128x16i()
            => and_blocks_check<short>(n128);

        public void and_blocks_128x16u()
            => and_blocks_check<ushort>(n128);

        public void and_blocks_128x32i()
            => and_blocks_check<int>(n128);

        public void and_blocks_128x32u()
            => and_blocks_check<uint>(n128);

        public void and_blocks_128x64i()
            => and_blocks_check<long>(n128);

        public void and_blocks_128x64u()
            => and_blocks_check<ulong>(n128);

        public void and_blocks_256x8i()
            => and_blocks_check<sbyte>(n256);

        public void and_blocks_256x8u()
            => and_blocks_check<byte>(n256);

        public void and_blocks_256x16i()
            => and_blocks_check<short>(n256);

        public void and_blocks_256x16u()
            => and_blocks_check<ushort>(n256);

        public void and_blocks_256x32i()
            => and_blocks_check<int>(n256);

        public void and_blocks_256x32u()
            => and_blocks_check<uint>(n256);

        public void and_blocks_256x64i()
            => and_blocks_check<long>(n256);

        public void and_blocks_256x64u()
            => and_blocks_check<ulong>(n256);
    }

}