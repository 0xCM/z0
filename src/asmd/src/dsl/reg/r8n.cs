//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct r8<N> : IRegOp8<r8<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r8(Fixed8 value)
        {
            Value = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBitField.join((RegisterCode)value<N>(), RegisterClass.GP, RegisterWidth.W8);
        }
    }
}