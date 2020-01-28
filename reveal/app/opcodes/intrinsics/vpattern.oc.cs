//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static VectorKind vkind_128x32u()
            => Classifiers.vector<N128,uint>();

        public static VectorKind vkind_256x32u()
            => Classifiers.vector<N256,uint>();

        public static BlockKind bkind_256x32u()
            => Classifiers.block<N256,uint>();

        public static NumericKind pkind_8u()
            => Classifiers.primal<byte>();

        public static NumericKind pkind_32u()
            => Classifiers.primal<uint>();

        public static NumericKind pkind_32i()
            => Classifiers.primal<int>();

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


        public static Vector128<byte> makemask_d128x8u(ushort src)
            => dinx.vmakemask(src);

        public static Vector256<byte> makemask_d256x8u(uint src)
            => dinx.vmakemask(src);

        public static Vector128<byte> maskmask_d128x8u_index4(ushort src)
            => dinx.vmakemask(src, 4);

        public static Vector256<byte> maskmask_d256x8u_index3(uint src)
            => dinx.vmakemask(src, 3);

        public static Vector128<byte> makemask_d128x8u_FCFC()
            => dinx.vmakemask(0xFCFC);

        public static Vector256<byte> makemask_d256x8u_FAFAFAFA()
            => dinx.vmakemask(0xFAFAFAFAu);

    }

}