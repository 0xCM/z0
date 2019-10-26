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

    partial class inxvoc
    {
        public static Vector128<byte> ones_128x8u()
            => ginx.vpOnes<byte>(n128);

        public static Vector128<ulong> ones_128x64u()
            => ginx.vpOnes<ulong>(n128);

        public static Vector256<byte> ones_256x8u()
            => ginx.vpOnes<byte>(n256);

        public static Vector256<ulong> ones_256x64u()
            => ginx.vpOnes<ulong>(n256);

        public static Vector256<double> ones_256x64f()
            => ginx.vpOnes<double>(n256);

        public static Vector256<byte> pattern_lanemerge_256x8u()            
            => ginx.vpLaneMerge<byte>();

        public static Vector256<ushort> pattern_lanemerge_256x16u()            
            => ginx.vpLaneMerge<ushort>();


    }

}