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

        public readonly ImmRefinementKind Refinement;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8Value imm8)
            => imm8.Value;

        [MethodImpl(Inline)]
        public Imm8Value(byte value, ImmRefinementKind refinement)
        {
            Value = value;
            Refinement = refinement;
        }
    }
}