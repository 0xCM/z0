//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IKeyword : ITextual
    {
        string Name {get;}

        string ITextual.Format()
            => Name;
    }

    public interface IKeyword<K> : IKeyword
        where K : unmanaged
    {
        K Kind {get;}
    }
}