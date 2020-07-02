//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    public readonly struct reg<R> : IRegOperand
        where R : unmanaged, IRegOperand
    {
        public R Value {get;}

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => Value.Kind;
        }

        public BitSize Width 
        {
            [MethodImpl(Inline)]
            get => bitsize<R>();
        }

        [MethodImpl(Inline)]
        public reg(R value)
        {
            Value = value;
        }
    }
}