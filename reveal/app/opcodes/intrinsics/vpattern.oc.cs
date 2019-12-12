//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [OpCodeHost]
    public static class vpattern
    {
        public static Vector128<byte> ones_128x8u()
            => ginx.vones<byte>(n128);

        public static Vector128<ulong> ones_128x64u()
            => ginx.vones<ulong>(n128);

        public static Vector256<byte> ones_256x8u()
            => ginx.vones<byte>(n256);

        public static Vector256<ulong> ones_256x64u()
            => ginx.vones<ulong>(n256);

        public static Vector256<double> ones_256x64f()
            => ginx.vones<double>(n256);

        public static Vector256<byte> pattern_lanemerge_256x8u()            
            => ginx.vplanemerge<byte>();

        public static Vector256<ushort> pattern_lanemerge_256x16u()            
            => ginx.vplanemerge<ushort>();

        public static Vector128<byte> makemask_128x8u(BitVector16 src)
            => dinx.vmakemask(src);

        public static Vector128<byte> makemask_128x8u_literal()
            => dinx.vmakemask(0xFCFC);

        public static Vector256<byte> makemask_256x8u(BitVector32 src)
            => dinx.vmakemask(src);

        public static Vector256<byte> makemask_256x8u_literal()
            => dinx.vmakemask(0xF0F0F0C0u);

        public static Vector128<byte> makemask_g128x8u(BitVector16 src)
            => ginx.vmakemask<byte>(src);

        public static Vector128<ushort> makemask_g128x16u(BitVector16 src)
            => ginx.vmakemask<ushort>(src);

        public static Vector256<uint> makemask_g256x32u(BitVector32 src)
            => ginx.vmakemask<uint>(src);


    }

}