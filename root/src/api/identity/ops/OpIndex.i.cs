//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public interface IOpIndex<T>
    {
        int EntryCount {get;}

        IEnumerable<OpIdentity> Keys {get;}

        IReadOnlyList<OpIdentity> DuplicateKeys {get;}
        
        T this[OpIdentity id] {get;}

        Option<T> Lookup(OpIdentity id);

        IEnumerable<(OpIdentity, T)> Enumerated {get;}       

    }
}