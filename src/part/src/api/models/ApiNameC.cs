//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct ApiName<C> : ITextual
    {
        public C Content {get;}

        [MethodImpl(Inline)]
        public ApiName(C content)
            => Content = content;

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}",Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiName<C>(C src)
            => new ApiName<C>(src);
    }
}