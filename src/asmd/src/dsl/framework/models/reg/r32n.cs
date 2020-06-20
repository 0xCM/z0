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

    public readonly struct r32<N> : IRegOp32<r32<N>,N>
        where N : unmanaged, ITypeNat
    {
        public Fixed32 Value {get;}

        [MethodImpl(Inline)]
        public r32(Fixed32 value)
        {
            Value = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBitField.join((RegisterCode)value<N>(), RegisterClass.GP, RegisterWidth.W32);
        }
    }
}