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

    public readonly struct ymm<N> : IYmmRegOp<ymm<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed256 Value {get;}

        [MethodImpl(Inline)]
        public ymm(Fixed256 value)
        {
            Value = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBitField.join((RegisterCode)value<N>(), RegisterClass.YMM, RegisterWidth.W256);
        }
    }
}