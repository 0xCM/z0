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

    public class AsmCodeIndex
    {
        public static AsmCodeIndex Create(IEnumerable<AsmCode> src)
            => new AsmCodeIndex(src);
         
        AsmCodeIndex(IEnumerable<AsmCode> src)
        {
            index = new Dictionary<Moniker, AsmCode>();
            foreach(var item in src)            
            {
                if(!index.TryAdd(item.Id, item))
                    throw error(AppMsg.Error($"Duplicate identifier found: Id = {item.Id}, data = {item.Encoded.FormatAsmHex()}"));
            }
        }
        
        Dictionary<Moniker,AsmCode> index;

        public Option<AsmCode> Lookup(Moniker id)
            => index.TryFind(id);
        
        public Option<AsmCode> VectorOp(string name, FixedWidth width, PrimalKind kind, bool generic)
            => Lookup(OpIdentity.segmented(name, width, kind, generic));

        public Option<AsmCode> VectorOp<W>(string name, PrimalKind kind, W w = default)
            where W : unmanaged, ITypeNat
                => Lookup(OpIdentity.segmented(name, (FixedWidth)w.NatValue, kind, false));

        public Option<AsmCode> VectorOp<W,T>(string name,  W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => Lookup(OpIdentity.segmented(name, (FixedWidth)w.NatValue, typeof(T).Kind(), false));

        public Option<AsmCode> gVectorOp<W,T>(string name,  W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => Lookup(OpIdentity.segmented(name, (FixedWidth)w.NatValue, typeof(T).Kind(), true));

        public Option<AsmCode> PrimalOp(string name, PrimalKind kind, bool generic)
            => Lookup(OpIdentity.define(name, kind, generic));

        public Option<AsmCode> PrimalOp<T>(string name, T t = default)
            where T : unmanaged
                => Lookup(OpIdentity.define(name, typeof(T).Kind(), false));

        public Option<AsmCode> gPrimalOp<T>(string name, T t = default)
            where T : unmanaged
                => Lookup(OpIdentity.define(name, typeof(T).Kind(), true));

        public IEnumerable<AsmCode> Entries
            => index.Values;
    }
}