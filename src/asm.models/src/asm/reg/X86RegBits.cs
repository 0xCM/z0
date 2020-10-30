//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RegisterBitFields;

    using W = RegisterWidth;

    /// <summary>
    /// The register bitfield
    /// </summary>
    [ApiHost]
    public readonly struct X86RegBits
    {
        /// <summary>
        /// The register code data (1 byte)
        /// </summary>
        public readonly RegisterIndex Code;

        /// <summary>
        /// The register class data (1 byte)
        /// </summary>
        public readonly RegisterClass Class;

        /// <summary>
        /// The register width (2 bytes)
        /// </summary>
        public readonly RegisterWidth Width;


        [MethodImpl(Inline)]
        public X86RegBits(RegisterIndex c, RegisterClass k, RegisterWidth w)
        {
            Code = c;
            Class = k;
            Width = w;
        }

        [MethodImpl(Inline)]
        public X86RegBits(RegisterKind src)
            => RegisterQuery.split(src, out Code, out Class, out Width);

        public RegisterKind Joined
        {
            [MethodImpl(Inline)]
            get => RegisterQuery.join(Code,Class,Width);
        }

        [MethodImpl(Inline)]
        public static implicit operator X86RegBits(RegisterKind src)
            => new X86RegBits(src);

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