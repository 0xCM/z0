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
    /// ModRM = [Mod:[7:6] | Reg:[5:3] | Rm:[2:0]]
    /// </summary>
    public readonly struct ModRmBits : ITextual
    {
        readonly uint8T Data;

        [MethodImpl(Inline)]
        public static ModRmBits define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmBits(rm, reg, mod);

        [MethodImpl(Inline)]
        public ModRmBits(uint3 rm, uint3 reg, uint2 mod)
            => Data = (uint8T)rm | ((uint8T)reg << ModRmMasks.RegIndex ) | ((uint8T)mod << ModIndex);

        [MethodImpl(Inline)]
        public ModRmBits(byte src)
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
            get => (Data & RegMask) >> ModRmMasks.RegIndex;
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

        public static ModRmBits Empty => default;
    }
}