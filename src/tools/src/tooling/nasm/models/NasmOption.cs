//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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