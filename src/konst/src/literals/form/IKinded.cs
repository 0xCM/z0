//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IKinded<K> : ITypedLiteral<K>, ITextual
        where K : unmanaged, Enum
    {
        K Literal {get;}

        K ITypedLiteral<K>.Class
            => Literal;
        string ITextual.Format()
            => Literal.ToString();
    }

}