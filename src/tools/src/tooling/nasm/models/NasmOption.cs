//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NasmOption<T>
    {
        public NasmOptionKind Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public NasmOption(NasmOptionKind kind, T value)
        {
            Kind = kind;
            Value = value;
        }
    }
}