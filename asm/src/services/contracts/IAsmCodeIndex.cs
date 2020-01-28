//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using AsmSpecs;

    public interface IAsmVCodeIndex
    {
        IEnumerable<AsmCode> Entries {get;}

        Option<AsmCode> Find(string name, FixedWidth width, PrimalKind kind);

        Option<AsmCode> Find<W,T>(string name,  W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged;

    }
    
    public interface IAsmCodeIndex : IAsmVCodeIndex
    {

        Option<AsmCode> Lookup(Moniker id);        

        Option<AsmCode> PrimalOp(string name, PrimalKind kind);

        Option<AsmCode> VectorOp(string name, FixedWidth width, PrimalKind kind);

        Option<AsmCode> PrimalOp<T>(string name, T t = default)
            where T : unmanaged;

        Option<AsmCode> VectorOp<W,T>(string name,  W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged;
    }


}