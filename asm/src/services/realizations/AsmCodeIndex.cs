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

        public Option<AsmCode> VectorOp(string name, FixedWidth width, NumericKind kind)
            => Lookup(OpIdentity.segmented(name, width, kind, generic));

        public Option<AsmCode> VectorOp<W,T>(string name, W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => Lookup(OpIdentity.segmented(name, (FixedWidth)nateval<W>(), typeof(T).NumericKind(), generic));

        public Option<AsmCode> PrimalOp(string name, NumericKind kind)
            => Lookup(OpIdentity.define(name, kind, generic));

        public Option<AsmCode> PrimalOp<T>(string name, T t = default)
            where T : unmanaged
                => Lookup(OpIdentity.define(name, typeof(T).NumericKind()));

        Option<AsmCode> IAsmVCodeIndex.Find(string name, FixedWidth width, NumericKind kind)
            => VectorOp(name,width,kind);

        Option<AsmCode> IAsmVCodeIndex.Find<W, T>(string name, W w, T t)
        {
            var k = typeof(T).NumericKind();
            var width = (FixedWidth)(w.NatValue);
            var entries = from e in Entries
                            let segments = e.Id.Segments
                            where segments.Any(s => s.DominantWidth == width && s.NumericKind() == k)
                            select e;
            return entries.Any() ? entries.First() : none<AsmCode>();
        }

        public IEnumerable<AsmCode> Entries
            => index.Values;

    }
}