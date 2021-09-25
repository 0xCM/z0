//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITokenizer
    {

    }

    public interface ISyntaxToken
    {

    }

    public interface ISyntaxToken<K> : ISyntaxToken
        where K : unmanaged
    {
        K Kind {get;}
    }

    public interface ISyntaxToken<K,T> : ISyntaxToken<K>
        where K : unmanaged
    {
        T Value {get;}
    }

    public interface ITokenizer<K,T> : ITokenizer
        where K : unmanaged
    {

    }
}