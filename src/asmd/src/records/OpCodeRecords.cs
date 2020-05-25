//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct OpCodeRecords
    {        
        readonly IReadOnlyDictionary<OpCodeId, OpCodeRecord> Index;

        public static OpCodeRecords From(OpCodeRecord[] src)
        {
            var dst = new Dictionary<OpCodeId, OpCodeRecord>(src.Length);
            for(var i=0; i<src.Length; i++)
            {
                var spec = src[i];
                dst.TryAdd(spec.Id, spec);
            }
            return new OpCodeRecords(dst);
        }


        [MethodImpl(Inline)]
        public OpCodeRecords(IReadOnlyDictionary<OpCodeId, OpCodeRecord> index)
        {
            this.Index = index;
        }

        [MethodImpl(Inline)]
        public OpCodeRecord FindSpec(OpCodeId id)
            => Index.TryGetValue(id, out var spec) ? spec : OpCodeRecord.Empty;

        public OpCodeRecord this[OpCodeId id]
        {
            [MethodImpl(Inline)]
            get => FindSpec(id);
        }
    }
}