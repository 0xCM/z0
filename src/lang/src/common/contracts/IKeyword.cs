//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
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
            => memory.bw16(Kind);
    }
}