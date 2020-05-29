//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public readonly struct RegisterSpecs : IApiHost<RegisterSpecs>
    {        
        [MethodImpl(Inline), Op]
        public static RegisterCode Code(RegisterSpec src)
            => (RegisterCode)Bits.slice((uint)src, (byte)FI.C, (byte)FW.C);

        [MethodImpl(Inline), Op]
        public static RegisterClass Class(RegisterSpec src)
            => (RegisterClass)Bits.slice((uint)src, (byte)FI.K, (byte)FW.K);

        [MethodImpl(Inline), Op]
        public static RegisterWidth Width(RegisterSpec src)
            => (RegisterWidth)Bits.slice((uint)src, (byte)FI.W, (byte)FW.W);

        [MethodImpl(Inline), Op]
        public static RegisterSpec Code(RegisterCode src, RegisterSpec dst)
            => (RegisterSpec)(Bits.copy((uint)src, (byte)FI.C, (byte)(FW.C), (uint)dst));

        [MethodImpl(Inline), Op] 
        public static RegisterSpec Class(RegisterClass src, RegisterSpec dst)
            => (RegisterSpec)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.K), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterSpec Width(RegisterWidth src, RegisterSpec dst)
            => (RegisterSpec)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.W), (uint)dst));
        
        public enum FI : byte
        {
            /// <summary>
            /// RegisterCode: [0..3]
            /// </summary>
            C = 0,

            /// <summary>
            /// RegisterClass: [4..15]
            /// </summary>
            K = 4,

            /// <summary>
            /// Register width: [16..31]
            /// </summary>
            W = 16,

            Last = 31,
        }

        public enum FW : byte
        {
            C = FI.K - FI.C,

            K = FI.W - FI.K,

            W = FI.Last - FI.W,
        }
    }
}