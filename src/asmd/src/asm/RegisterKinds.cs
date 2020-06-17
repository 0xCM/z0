//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using W = RegisterWidth;

    [ApiHost]
    public partial class RegisterKinds : IApiHost<RegisterKinds>
    {
        [MethodImpl(Inline), Op]
        public static RegisterCode Code(RegisterKind src)
            => (RegisterCode)Bits.slice((uint)src, (byte)FI.C, (byte)FW.C);

        [MethodImpl(Inline), Op]
        public static RegisterClass Class(RegisterKind src)
            => (RegisterClass)Bits.slice((uint)src, (byte)FI.K, (byte)FW.K);

        [MethodImpl(Inline), Op]
        public static RegisterWidth Width(RegisterKind src)
            => (RegisterWidth)Bits.slice((uint)src, (byte)FI.W, (byte)FW.W);

        [MethodImpl(Inline), Op]
        public static RegisterKind Code(RegisterCode src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.C, (byte)(FW.C), (uint)dst));

        [MethodImpl(Inline), Op] 
        public static RegisterKind Class(RegisterClass src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.K), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterKind Width(RegisterWidth src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.W), (uint)dst));

        public static RegisterKind[] SymbolKinds
            => Enums.valarray<RegisterKind>();

        public static IEnumerable<RegisterKind> Gp8 
            => SymbolKinds.Where(r => Width(r) == W.W8);

        public static IEnumerable<RegisterKind> Gp16 
            => SymbolKinds.Where(r => Width(r) == W.W16);

        public static IEnumerable<RegisterKind> Gp32
            => SymbolKinds.Where(r => Width(r) == W.W32);

        public static IEnumerable<RegisterKind> Gp64
            => SymbolKinds.Where(r => Width(r) == W.W64);

        public static IEnumerable<RegisterKind> V128
            => SymbolKinds.Where(r => Width(r) == W.W128);

        public static IEnumerable<RegisterKind> V256
            => SymbolKinds.Where(r => Width(r) == W.W256);

        public static IEnumerable<RegisterKind> V512
            => SymbolKinds.Where(r => Width(r) == W.W512);       
 
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