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

    [OpCodeProvider]
    public static class vpattern
    {
        public static Vector128<byte> ones_128x8u()
            => VPattern.vones<byte>(n128);

        public static Vector128<ulong> ones_128x64u()
            => VPattern.vones<ulong>(n128);

        public static Vector256<byte> ones_256x8u()
            => VPattern.vones<byte>(n256);

        public static Vector256<ulong> ones_256x64u()
            => VPattern.vones<ulong>(n256);

        public static Vector256<double> ones_256x64f()
            => VPattern.vones<double>(n256);

        public static Vector256<byte> pattern_lanemerge_256x8u()            
            => CpuVector.vlanemerge<byte>();

        public static Vector256<ushort> pattern_lanemerge_256x16u()            
            => CpuVector.vlanemerge<ushort>();

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