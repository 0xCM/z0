//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OperatorClass<T> : IOperationalClass<ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(ApiOperatorKind k)
            => Kind = k;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(OperatorClass<T> src)
            => new OperatorClass(src.Kind);
    }
}