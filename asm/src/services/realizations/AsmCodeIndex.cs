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

            foreach(var item in src.Where(x => generic ? x.Id.IsGeneric : !x.Id.IsGeneric))            
            {
                if(!index.TryAdd(item.Id, item))
                    throw error(AppMsg.Error($"Duplicate identifier found: Id = {item.Id}, data = {item.Encoded.FormatAsmHex()}"));
            }
        }
        
        public Option<AsmCode> Lookup(Moniker id)
            => index.TryFind(id);

        public Option<AsmCode> VectorOp(string name, FixedWidth width, PrimalKind kind)
            => Lookup(OpIdentity.segmented(name, width, kind, generic));

        public Option<AsmCode> VectorOp<W,T>(string name, W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => Lookup(OpIdentity.segmented(name, (FixedWidth)nateval<W>(), typeof(T).Kind(), generic));

        public Option<AsmCode> PrimalOp(string name, PrimalKind kind)
            => Lookup(OpIdentity.define(name, kind, generic));

        public Option<AsmCode> PrimalOp<T>(string name, T t = default)
            where T : unmanaged
                => Lookup(OpIdentity.define(name, typeof(T).Kind()));

        public IEnumerable<AsmCode> Entries
            => index.Values;

    }
}