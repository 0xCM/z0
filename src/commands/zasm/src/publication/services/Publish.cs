//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm.Data;

    using static Seed;

    public readonly struct OpCodeSpecs
    {        
        readonly IReadOnlyDictionary<OpCodeId, OpCodeSpec> Index;

        public OpCodeSpecs(IReadOnlyDictionary<OpCodeId, OpCodeSpec> index)
        {
            this.Index = index;
        }

        public OpCodeSpec this[OpCodeId id]
        {
            get 
            {
                if(Index.TryGetValue(id, out var spec))
                    return spec;
                else return OpCodeSpec.Empty;
            }
        }
    }

    partial class AsmEtl
    {        
        OpCodeSpecs Index(OpCodeSpec[] src)
        {
            var dst = new Dictionary<OpCodeId, OpCodeSpec>(src.Length);
            for(var i=0; i<src.Length; i++)
            {
                var spec = src[i];
                dst.TryAdd(spec.Id, spec);
            }
            return new OpCodeSpecs(dst);
        }

        public void Publish()
        {
            var specs = PublishOpCodeSpecs();
            var index = Index(specs);
            //var forms = Publish(AsmEtl.OpCodeForms, index);
            PublishDecoderTests(index);
            //PublishLists();
            //etl.PublishLiterals();
            // etl.Publish(AsmEtl.Instructions);
            //etl.Publish(AsmEtl.OpCodes);

        }
    }
}
