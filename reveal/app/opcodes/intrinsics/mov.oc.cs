//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    [OpCodeProvider]
    public static class vmov
    {
        public static Vector128<byte> vmov_idx3_128x8u(byte src,  Vector128<byte> dst)
            => ginx.vputcell(src, 3, dst);

        public static Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
            => ginx.vputcell(src, 4, dst);

        public static Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
            => ginx.vputcell(src, 2, dst);

        public static Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
            => ginx.vputcell(src, 3, dst);

        public static Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
            => ginx.vputcell(src, 4, dst);

        public static Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
            => ginx.vputcell(src, 2, dst);

        public static Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b,Vector256<uint> dst)
            => ginx.vputcell(b,4,ginx.vputcell(a,2, dst));

        public static Vector128<byte> vmov128x8u(byte src)
            => CpuVector.vscalar(n128,src);

        public static Vector128<ushort> vmov128x16u(ushort src)
            => CpuVector.vscalar(n128, src);

        public static Vector128<uint> vmov128x32u(uint src)
            => CpuVector.vscalar(n128,src);

        public static Vector128<ulong> vmov128x64u(ulong src)
            => CpuVector.vscalar(n128,src);

        public static Vector128<double> vmov128x64u(double src)
            => CpuVector.vscalar(n128,src);

        public static Vector256<byte> vmov256x8u(byte src)
            => CpuVector.vscalar(n256,src);

        public static Vector256<ushort> vmov256x16u(ushort src)
            => CpuVector.vscalar(n256, src);

        public static Vector256<uint> vmov256x32u(uint src)
            => CpuVector.vscalar(n256,src);

        public static Vector256<ulong> vmov256x64u(ulong src)
            => CpuVector.vscalar(n256,src);

        public static Vector256<double> vmov256x64u(double src)
            => CpuVector.vscalar(n256,src);
    }
}