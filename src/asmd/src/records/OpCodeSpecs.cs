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

    public readonly struct OpCodeSpecs
    {        
        public static OpCodeSpecs From(OpCodeSpec[] src)
        {
            var dst = new Dictionary<OpCodeId, OpCodeSpec>(src.Length);
            for(var i=0; i<src.Length; i++)
            {
                var spec = src[i];
                dst.TryAdd(spec.Id, spec);
            }
            return new OpCodeSpecs(dst);
        }

        readonly IReadOnlyDictionary<OpCodeId, OpCodeSpec> Index;

        [MethodImpl(Inline)]
        public OpCodeSpecs(IReadOnlyDictionary<OpCodeId, OpCodeSpec> index)
        {
            this.Index = index;
        }

        [MethodImpl(Inline)]
        public OpCodeSpec FindSpec(OpCodeId id)
            => Index.TryGetValue(id, out var spec) ? spec : OpCodeSpec.Empty;

        public OpCodeSpec this[OpCodeId id]
        {
            [MethodImpl(Inline)]
            get => FindSpec(id);
        }
    }
}