//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolSpec
    {
        ushort SymWidth {get;}

        ushort SegWidth {get;}

        ushort SegCapacity {get;}

        CliKey SegDomain {get;}

        CliKey SymDomain {get;}

        CliKey KindDomain
            => CliKey.Empty;
    }

    public interface ISymbolSpec<S> : ISymbolSpec
        where S : unmanaged
    {
        S[] Symbols {get;}
    }

    public interface ISymbolSpec<H,S> : ISymbolSpec<S>
        where S : unmanaged
        where H : struct, ISymbolSpec<H,S>
    {

    }

    public interface ISymbolSpec<H,K,S> : ISymbolSpec<H,S>
        where H : struct, ISymbolSpec<H,K,S>
        where S : unmanaged
        where K : unmanaged
    {
        K[] Kinds {get;}
    }
}