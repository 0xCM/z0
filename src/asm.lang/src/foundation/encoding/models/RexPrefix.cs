//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using RFI = RexFieldIndex;
    using api = AsmEncoder;

    /// <summary>
    /// REX = [ 0100 | W:4 | R:3 | X:2 | B:1 ]
    /// </summary>
    [ApiHost]
    public struct RexPrefix
    {
        internal byte Data;

        [MethodImpl(Inline)]
        public RexPrefix(byte src)
            => Data = src;

        /// <summary>
        /// When enabled, indicates a 64-bit operand size; if not, operand size determined by CS.D
        /// </summary>
        public bit W
        {
            [MethodImpl(Inline)]
            get => bit.test(Data, (byte)RFI.W);
        }

        /// <summary>
        /// Indicates an extension of the ModR/M reg field
        /// </summary>
        public bit R
        {
            [MethodImpl(Inline)]
            get => bit.test(Data, (byte)RFI.R);
        }

        /// <summary>
        /// Indicates an extension of the SIB index field
        /// </summary>
        public bit X
        {
            [MethodImpl(Inline)]
            get => bit.test(Data, (byte)RFI.X);
        }

        /// <summary>
        /// Indicates an extension of the ModR/M r/m field, SIB base field, or Opcode reg field
        /// </summary>
        public bit B
        {
            [MethodImpl(Inline)]
            get => bit.test(Data,(byte)RFI.B);
        }

        public RexPrefixCode Code
        {
            [MethodImpl(Inline)]
            get => (RexPrefixCode)Data;

            [MethodImpl(Inline)]
            set => Data = (byte)value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public string Format()
            => Data.FormatAsmHex();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Hex8(RexPrefix src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator RexPrefix(RexPrefixCode src)
            => new RexPrefix((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator byte(RexPrefix src)
            => src.Data;

        [MethodImpl(Inline)]
        public static RexPrefix operator ++(RexPrefix src)
            => api.next(src);

        [MethodImpl(Inline)]
        public static RexPrefix operator --(RexPrefix src)
            => api.prior(src);

        public static RexPrefix Empty
            => new RexPrefix(0);
    }
}