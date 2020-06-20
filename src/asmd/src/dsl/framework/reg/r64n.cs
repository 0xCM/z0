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

    public readonly struct r64<N> : IRegOp64<r64<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed64 Value {get;}

        [MethodImpl(Inline)]
        public r64(Fixed64 value)
        {
            Value = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBitField.join((RegisterCode)value<N>(), RegisterClass.GP, RegisterWidth.W64);
        }
    }
}