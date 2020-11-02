//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static math;

    /// <summary>
    /// Captures both the input and encoding for a modrm prefix
    /// </summary>
    public readonly struct ModRmEncoding
    {
        readonly octet Input;

        public readonly ModRm Encoded;

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
        public ModRmEncoding(uint3 rm, UInt3 reg, UInt2 mod, ModRm encoded)
        {
            Input = or((byte)rm, sll((byte)reg,3), sll((byte)mod, 3 + 3));
            Encoded = encoded;
        }
    }
}