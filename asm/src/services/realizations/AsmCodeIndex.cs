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
        
        readonly Dictionary<OpIdentity, AsmCode> index;

        public static AsmCodeIndex Create(IEnumerable<AsmCode> src, bool generic)
            => new AsmCodeIndex(src,generic);

        AsmCodeIndex(IEnumerable<AsmCode> src, bool generic)
        {
            this.generic = generic;
            this.index = new Dictionary<OpIdentity, AsmCode>();
         
        }
        
        public Option<AsmCode> Lookup(OpIdentity id)
            => index.TryFind(id);
        

        public IEnumerable<AsmCode> Entries
            => index.Values;

    }
}