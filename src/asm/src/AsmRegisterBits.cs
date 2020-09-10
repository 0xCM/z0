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
    using static RegisterBitFields;

    using W = RegisterWidth;

    /// <summary>
    /// The register bitfield
    /// </summary>
    [ApiHost]
    public readonly struct AsmRegisterBits
    {
        /// <summary>
        /// The register code data (1 byte)
        /// </summary>
        public readonly RegisterCode Code;

        /// <summary>
        /// The register class data (1 byte)
        /// </summary>
        public readonly RegisterClass Class;

        /// <summary>
        /// The register width (2 bytes)
        /// </summary>
        public readonly RegisterWidth Width;

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterCode code(RegisterKind src)
            => (RegisterCode)((byte)src >> CodeIndex);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterClass @class(RegisterKind src)
            => (RegisterClass)((uint)src >> ClassIndex);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterWidth width(RegisterKind src)
            => (RegisterWidth)((uint)src >> WidthIndex);

        [MethodImpl(Inline), Op]
        public static RegisterKind join(RegisterCode c, RegisterClass k, RegisterWidth w)
            => (RegisterKind)((uint)c  << CodeIndex | (uint)k << ClassIndex | (uint)w << WidthIndex);

        [MethodImpl(Inline), Op]
        public static RegisterCode code1(RegisterKind src)
            => (RegisterCode)Bits.slice((uint)src, (byte)FI.C, (byte)FW.C);

        [MethodImpl(Inline), Op]
        public static RegisterClass @class1(RegisterKind src)
            => (RegisterClass)Bits.slice((uint)src, (byte)FI.K, (byte)FW.K);

        [MethodImpl(Inline), Op]
        public static RegisterKind code(RegisterCode src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.C, (byte)(FW.C), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterKind @class(RegisterClass src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.K), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterKind width(RegisterWidth src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.W), (uint)dst));

        public static RegisterKind[] SymbolKinds
            => Enums.literals<RegisterKind>();

        public static IEnumerable<RegisterKind> Gp8
            => SymbolKinds.Where(r => width(r) == W.W8);

        public static IEnumerable<RegisterKind> Gp16
            => SymbolKinds.Where(r => width(r) == W.W16);

        public static IEnumerable<RegisterKind> Gp32
            => SymbolKinds.Where(r => width(r) == W.W32);

        public static IEnumerable<RegisterKind> Gp64
            => SymbolKinds.Where(r => width(r) == W.W64);

        public static IEnumerable<RegisterKind> V128
            => SymbolKinds.Where(r => width(r) == W.W128);

        public static IEnumerable<RegisterKind> V256
            => SymbolKinds.Where(r => width(r) == W.W256);

        public static IEnumerable<RegisterKind> V512
            => SymbolKinds.Where(r => width(r) == W.W512);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegisterCode c, out RegisterClass k, out RegisterWidth w)
        {
            c = code(src);
            k = @class(src);
            w = width(src);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmRegisterBits(RegisterKind src)
            => new AsmRegisterBits(src);

        [MethodImpl(Inline)]
        public AsmRegisterBits(RegisterCode c, RegisterClass k, RegisterWidth w)
        {
            Code = c;
            Class = k;
            Width = w;
        }

        [MethodImpl(Inline)]
        public AsmRegisterBits(RegisterKind src)
            => split(src, out Code, out Class, out Width);

        public RegisterKind Joined
        {
            [MethodImpl(Inline)]
            get => join(Code,Class,Width);
        }
    }

    enum FI : byte
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

    enum FW : byte
    {
        C = FI.K - FI.C,

        K = FI.W - FI.K,

        W = FI.Last - FI.W,
    }
}