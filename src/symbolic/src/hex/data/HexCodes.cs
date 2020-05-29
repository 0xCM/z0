//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    using HCL = HexCodeLo;
    using HCU = HexCodeUp;

    partial class SymbolicData
    {        
        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes the hex digits {0..9,A..F}
        /// </summary>
        public static ReadOnlySpan<byte> UpperHexCodes
            => new byte[]{
                (byte)HCU.x0, (byte)HCU.x1, (byte)HCU.x2, (byte)HCU.x3, 
                (byte)HCU.x4, (byte)HCU.x5, (byte)HCU.x6, (byte)HCU.x7,
                (byte)HCU.x8, (byte)HCU.x9, 
                (byte)HCU.A,  (byte)HCU.B, (byte)HCU.C, (byte)HCU.D, (byte)HCU.E, (byte)HCU.F,
                };

        /// <summary>
        /// Defines a 16-byte sequence with terms that correspond to the ASCI codes for hex digits {0..9,a..f}
        /// </summary>
        public static ReadOnlySpan<byte> LowerHexCodes
            => new byte[]{
                (byte)HCL.x0, (byte)HCL.x1, (byte)HCL.x2, (byte)HCL.x3, 
                (byte)HCL.x4, (byte)HCL.x5, (byte)HCL.x6, (byte)HCL.x7,
                (byte)HCL.x8, (byte)HCL.x9, 
                (byte)HCL.a,  (byte)HCL.b, (byte)HCL.c, (byte)HCL.d, (byte)HCL.e, (byte)HCL.f,
                };
    }
}