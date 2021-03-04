//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static math;

    /// <summary>
    /// Captures both the input and encoding for a modrm prefix
    /// </summary>
    public readonly struct ModRmEncoding
    {
        readonly uint8T Input;

        public readonly ModRmBits Encoded;

        public readonly uint3 Rm
        {
            [MethodImpl(Inline)]
            get => (uint3)Input;
        }

        public readonly uint3 Reg
        {
            [MethodImpl(Inline)]
            get => (uint3)(srl(Input,3));
        }

        public readonly uint2 Mod
        {
            [MethodImpl(Inline)]
            get => (uint2)(srl(Input,3 + 3));
        }

        [MethodImpl(Inline)]
        public ModRmEncoding(uint3 rm, BitSeq3 reg, BitSeq2 mod, ModRmBits encoded)
        {
            Input = or((byte)rm, sll((byte)reg,3), sll((byte)mod, 3 + 3));
            Encoded = encoded;
        }

        public string Format()
        {
            const string Sep = " | ";
            const string Assign = " = ";
            var a = Rm.Format();
            var b = Reg.Format();
            var c = Mod.Format();
            var e = Encoded.Format();
            return text.concat(a, Sep, b, Sep, c, Assign, e);
        }

        public override string ToString()
            => Format();

    }
}