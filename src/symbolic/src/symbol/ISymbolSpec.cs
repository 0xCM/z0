//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

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

        bool DefinesSymbols 
            => Symbols == null || Symbols.Length == 0;        
    }


}