//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static ModRmEncoder;

    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together with an addressing mode
    /// ModRM = [Mod:[7 6] | Reg:[5 4 3] | Rm:[2 1 0] ]
    /// </summary>
    public readonly struct ModRm : ITextual
    {        
        public static ModRm Empty => default;
        
        readonly octet Data;

        [MethodImpl(Inline)]
        public static ModRm Define(triad rm, triad reg, duet mod)
            => new ModRm(rm,reg,mod);

        [MethodImpl(Inline)]
        public ModRm(triad rm, triad reg, duet mod)
        {
            Data = (octet)rm | ((octet)reg << RegIndex ) | ((octet)mod << ModIndex);
        }        

        [MethodImpl(Inline)]
        public ModRm(octet src)
        {
            Data = src;
        }

        /// <summary>
        /// Defines bits [2:0] of the modrm byte
        /// </summary>
        public triad Rm
        {
            [MethodImpl(Inline)]
            get => (Data & RmMask) >> RmIndex;
        }

        /// <summary>
        /// Defines bits [5:3] of the modrm byte
        /// </summary>
        public triad Reg
        {
            [MethodImpl(Inline)]
            get => (Data & RegMask) >> RegIndex;
        }

        /// <summary>
        /// Defines bits [7:6] of the modrm byte
        /// </summary>
        public duet Mod
        {
            [MethodImpl(Inline)]
            get => (Data & ModMask) >> ModIndex;
        }

        /// <summary>
        /// The encoded bitfield value
        /// </summary>
        public octet Encoded
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => BitFormatter.format(Encoded);

        public override string ToString()
            => Format();
    }
}