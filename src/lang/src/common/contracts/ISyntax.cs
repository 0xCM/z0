//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface ISyntax : ITextual
    {

    }

    public interface ISyntax<X> : ISyntax
        where X : ISyntax<X>, new()
    {

    }

}