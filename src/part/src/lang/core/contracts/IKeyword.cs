//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IKeyword
    {
        Name Name {get;}

        ushort Index {get;}
    }

    public interface IKeyword<L,K> : IKeyword
        where L : struct, ILanguage
        where K : unmanaged
    {
        K Kind {get;}

        ushort IKeyword.Index
            => memory.w16(Kind);
    }
}