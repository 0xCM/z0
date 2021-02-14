//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    public interface ISyntaxToken : ITextual
    {
        string Symbol {get;}

        ulong Kind {get;}

        string Description {get;}

        string ITextual.Format()
            => Symbol;
    }

    public interface ISyntaxToken<K> : ISyntaxToken
        where K : unmanaged
    {
        new K Kind {get;}

        ulong ISyntaxToken.Kind
            => read64(Kind);
    }
}