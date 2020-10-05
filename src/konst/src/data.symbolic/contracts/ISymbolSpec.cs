//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolSpec
    {
        ushort SymbolWidth {get;}

        ushort SegmentWidth {get;}

        ushort SegmentCapacity {get;}

        ClrArtifactKey SegmentDomain {get;}

        ClrArtifactKey SymbolDomain {get;}

        ClrArtifactKey KindDomain => ClrArtifactKey.Empty;
    }

    public interface ISymbolSpec<S> : ISymbolSpec
        where S : unmanaged
    {
        S[] Symbols {get;}
    }

    public interface ISymbolSpec<K,S> : ISymbolSpec<S>
        where S : unmanaged
        where K : unmanaged
    {
        K[] Kinds {get;}
    }
}