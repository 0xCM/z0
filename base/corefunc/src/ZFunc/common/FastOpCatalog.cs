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

    using static zfunc;

    public abstract class FastOpCatalog<C> : IOperationCatalog
        where C : FastOpCatalog<C>
    {
        public virtual string CatalogName
            => DeclaringAssembly.GetSimpleName().RightOf(AsciSym.Dot);

        public virtual IEnumerable<FastOpContract> Services
            => from host in ServiceHosts
                let name = host.LiteralFieldValue<string>("Name",string.Empty)
                where name.IsNonEmpty()               
                let attrib = host.CustomAttribute<PrimalClosuresAttribute>()
                let closures = attrib.MapValueOrElse(a => a.Closures, () => PrimalKind.Integers).Distinct()
                let monikers = closures.Select(k => Moniker.define(name,k,true))
                select FastOpContract.Define(name,host,monikers);

        public virtual IEnumerable<FastGenericInfo> GenericOps 
            =>  GenericApiHosts.FastOpGenerics();

        public virtual IEnumerable<FastDirectInfo> DirectOps 
            => DirectApiHosts.FastOpDirect();
        
        public virtual IEnumerable<Type> ServiceHosts
            => items<Type>();                

        public virtual IEnumerable<Type> GenericApiHosts
            => items<Type>();

        public virtual IEnumerable<Type> DirectApiHosts
            => items<Type>();

        public virtual IEnumerable<FastGenericInfo> SpanOps 
            => items<FastGenericInfo>();

        public Assembly DeclaringAssembly 
            => typeof(C).Assembly;
    }
}