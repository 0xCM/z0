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

        static IEnumerable<Pair<string,MethodInfo>> HostMethods(params Type[] hosts)
            =>  from host in hosts
                from m in host.Methods().Public().Attributed<OpAttribute>()
                let name = m.CustomAttribute<OpAttribute>().MapValueOrElse(a => a.Name, () => m.Name)
                select paired(name,m);

        public override IEnumerable<ContractedOpInfo> Contracted 
            => from nr in OpRealizations
                let name = nr.A let host = nr.B
                let attrib = host.CustomAttribute<PrimalClosuresAttribute>()
                let closures = attrib.MapValueOrElse(a => a.Closures, () => PrimalKind.Integers).Distinct()
                let monikers = closures.Select(k => Moniker.define(name,k,true))
                select ContractedOpInfo.Define(name,host,monikers);

        public override IEnumerable<GenericOpInfo> Generic 
            => from namedMethods in HostMethods(typeof(gmath)).Where(m => m.B.IsOpenGeneric())
                let m = namedMethods.B.GetGenericMethodDefinition() 
                let name = m.Name                
                let attrib = m.CustomAttribute<PrimalClosuresAttribute>()
                let closures = attrib.MapValueOrElse(a => a.Closures, () => PrimalKind.Integers).Distinct()
                let monikers = closures.Select(k => Moniker.define(name,k,true))
                select GenericOpInfo.Define(name,m,monikers);
                
        public override IEnumerable<DirectOpInfo> Direct 
            => from nm in HostMethods(typeof(math),typeof(fmath)).Where(m => m.B.IsNonGeneric())
                select DirectOpInfo.Define(nm.A, nm.B);

        public override string Name 
            => nameof(gmath);
    }
}