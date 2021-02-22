//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CpuAlgorithmText
    {
        /// <summary>
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control)
        /// bextr r32, r32, r32
        /// </summary>
        public const string _bextr2_u32 = @"
            start := control[7:0]
            len := control[15:8]
            tmp[511:0] := a
            dst[31:0] := ZeroExtend32(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])
        ";

        /// <summary>
        /// unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control)
        /// bextr r64, r64, r64
        /// </summary>
        public const string _bextr2_u64 =@"
            start := control[7:0]
            len := control[15:8]
            tmp[511:0] := a
            dst[63:0] := ZeroExtend64(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])
        ";
    }
}