//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITokenSet
    {
        Type[] Types();
    }

    public abstract class TokenSet<T> : ITokenSet
        where T : TokenSet<T>, new()
    {
        public abstract Type[] Types();
    }
}