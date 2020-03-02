//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// A very thin wrapper around a dictionary
    /// </summary>
    public readonly struct AsmCodeIndex
    {        
        readonly Dictionary<OpIdentity, AsmCode> Index;

        [MethodImpl(Inline)]
        public static AsmCodeIndex Create(IEnumerable<AsmCode> src)
            => new AsmCodeIndex(src);

        [MethodImpl(Inline)]
        AsmCodeIndex(IEnumerable<AsmCode> src)
        {
            this.Index = new Dictionary<OpIdentity, AsmCode>();
            foreach(var item in src)
                Index.TryAdd(item.Id, item);         
        }
        
        public Option<AsmCode> Lookup(OpIdentity id)
            => Index.TryFind(id);
        
        public IEnumerable<AsmCode> Entries
            => Index.Values;
    }
}