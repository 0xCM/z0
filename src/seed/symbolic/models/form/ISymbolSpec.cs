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

        ushort Capacity {get;}

        MetadataToken SegDomain {get;}

        MetadataToken SymDomain {get;}
    }

    public interface ISymbolSpec<S> : ISymbolSpec
        where S : unmanaged
    {
        S[] Symbols {get;}
    }
}