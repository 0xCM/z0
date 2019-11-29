//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class inxoc
    {
        public static Vector128<byte> ones_128x8u()
            => ginx.vpones<byte>(n128);

        public static Vector128<ulong> ones_128x64u()
            => ginx.vpones<ulong>(n128);

        public static Vector256<byte> ones_256x8u()
            => ginx.vpones<byte>(n256);

        public static Vector256<ulong> ones_256x64u()
            => ginx.vpones<ulong>(n256);

        public static Vector256<double> ones_256x64f()
            => ginx.vpones<double>(n256);

        public static Vector256<byte> pattern_lanemerge_256x8u()            
            => ginx.vplanemerge<byte>();

        public static Vector256<ushort> pattern_lanemerge_256x16u()            
            => ginx.vplanemerge<ushort>();


    }

}