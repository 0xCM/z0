//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct Reg<T> : IRegOp
        where T : IFixed
    {
        public T Value {get;}

        public RegisterKind Kind {get;}

        public DataWidth Width => (DataWidth)bitsize<T>();

        [MethodImpl(Inline)]
        public Reg(T value, RegisterKind kind)
        {
            Value = value;
            Kind = kind;
        }
    }
}