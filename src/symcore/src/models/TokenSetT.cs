//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class TokenSet<T> : ITokenSet
        where T : TokenSet<T>, new()
    {
        public static T create()
            => new T();

        public abstract Type[] Types();

        public virtual string Name
            => typeof(T).Name;
    }
}