//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using static zfunc;

    class Catalog : OperationCatalog<Catalog>
    {
        static IEnumerable<Pair<string, Type>> OpRealizations
            => GetOpRealizations(typeof(GXTypes));

        public override IEnumerable<ContractedOpInfo> Contracted 
            => from nr in OpRealizations
                let name = nr.A let host = nr.B
                let attrib = host.CustomAttribute<PrimalClosuresAttribute>()
                let closures = attrib.MapValueOrElse(a => a.Closures, () => PrimalKind.Integers).Distinct()
                let monikers = closures.Select(k => Moniker.define(name,k,true))
                select ContractedOpInfo.Define(name,host,monikers);

        public override IEnumerable<GenericOpInfo> Generic 
            => typeof(gmath).FastOpGenerics();
                
        public override IEnumerable<DirectOpInfo> Direct 
            => items(typeof(math), typeof(fmath)).FastOpDirect();
               

        public override string Name 
            => nameof(gmath);
    }
}