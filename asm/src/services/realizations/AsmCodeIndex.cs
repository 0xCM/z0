//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct AsmCodeIndex : IAsmCodeIndex
    {
        readonly bool generic;
        
        readonly Dictionary<Moniker, AsmCode> index;

        public static AsmCodeIndex Create(IEnumerable<AsmCode> src, bool generic)
            => new AsmCodeIndex(src,generic);

        AsmCodeIndex(IEnumerable<AsmCode> src, bool generic)
        {
            this.generic = generic;
            this.index = new Dictionary<Moniker, AsmCode>();
         
        }
        
        public Option<AsmCode> Lookup(Moniker id)
            => index.TryFind(id);
        

        public IEnumerable<AsmCode> Entries
            => index.Values;

    }
}