//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OperatorClass<T> : IOperationalClass<ApiOperatorClass,T>
    {
        public ApiOperatorClass Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(ApiOperatorClass k)
            => Kind = k;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(OperatorClass<T> src)
            => new OperatorClass(src.Kind);
    }
}