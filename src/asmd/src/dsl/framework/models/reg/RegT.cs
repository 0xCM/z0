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

    public readonly struct reg<T> : IRegOp
        where T : IFixed
    {
        public T Value {get;}

        public RegisterKind Kind {get;}

        public BitSize Width 
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        [MethodImpl(Inline)]
        public reg(T value, RegisterKind kind)
        {
            Value = value;
            Kind = kind;
        }
    }
}