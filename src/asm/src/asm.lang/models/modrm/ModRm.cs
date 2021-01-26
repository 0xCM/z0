//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ModRmMasks;

    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together with an addressing mode
    /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
    /// </summary>
    public readonly struct ModRm : ITextual
    {
        readonly uint8T Data;

        [MethodImpl(Inline)]
        public static ModRm define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRm(rm, reg, mod);

        [MethodImpl(Inline)]
        public ModRm(uint3 rm, uint3 reg, uint2 mod)
            => Data = (uint8T)rm | ((uint8T)reg << RegIndex ) | ((uint8T)mod << ModIndex);

        [MethodImpl(Inline)]
        public ModRm(byte src)
            => Data = src;

        /// <summary>
        /// Defines bits [2:0] of the modrm byte
        /// </summary>
        public uint3 Rm
        {
            [MethodImpl(Inline)]
            get => (Data & RmMask) >> RmIndex;
        }

        /// <summary>
        /// Defines bits [5:3] of the modrm byte
        /// </summary>
        public uint3 Reg
        {
            [MethodImpl(Inline)]
            get => (Data & RegMask) >> RegIndex;
        }

        /// <summary>
        /// Defines bits [7:6] of the modrm byte
        /// </summary>
        public uint2 Mod
        {
            [MethodImpl(Inline)]
            get => (Data & ModMask) >> ModIndex;
        }

        /// <summary>
        /// The encoded bitfield value
        /// </summary>
        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => BitFormatter.format(Encoded);

        public override string ToString()
            => Format();

        public static ModRm Empty => default;
    }
}