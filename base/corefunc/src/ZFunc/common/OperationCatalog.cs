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

    public abstract class OperationCatalog<C> : IOperationCatalog
        where C : OperationCatalog<C>
    {
        public abstract IEnumerable<ContractedOpInfo> Contracted {get;}


        public abstract IEnumerable<GenericOpInfo> Generic { get; }

        public abstract IEnumerable<DirectOpInfo> Direct { get; }
        

        public virtual IEnumerable<GenericOpInfo> SpanOps => items<GenericOpInfo>();

        public Assembly DeclaringAssembly 
            => typeof(C).Assembly;

        public abstract string Name {get;}

        protected static IEnumerable<Pair<string,Type>> GetOpRealizations(Type host)
            => from t in host.GetNestedTypes().Realize<IFunc>()
                let name = t.LiteralFieldValue<string>("Name",string.Empty)
                where name.IsNonEmpty()
                select paired(name,t);
    }
}