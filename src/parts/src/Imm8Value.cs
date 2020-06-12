//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Imm8Value
    {
        public readonly byte Value;

        public readonly ImmSourceKind Source;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8Value imm8)
            => imm8.Value;

        [MethodImpl(Inline)]
        public static Imm8Value Define(byte value, ImmSourceKind source = ImmSourceKind.Literal)
            => new Imm8Value(value,source);
        
        [MethodImpl(Inline)]
        public Imm8Value(byte value)
        {
            this.Value = value;
            this.Source = ImmSourceKind.Literal;
        }

        [MethodImpl(Inline)]
        public Imm8Value(byte value, ImmSourceKind source)
        {
            this.Value = value;
            this.Source = source;
        }
    }
}