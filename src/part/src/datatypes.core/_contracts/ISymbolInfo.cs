//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISymbolInfo
    {
        ushort SymWidth {get;}

        ushort SegWidth {get;}

        ushort SegCapacity {get;}

        PrimalCode SegDomain {get;}

        PrimalCode SymDomain {get;}

        SymbolInfo Description
            => new SymbolInfo(SymWidth, SegWidth, SegDomain, SymDomain);
    }
}
