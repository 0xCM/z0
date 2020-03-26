//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class ApiPart<P> : Part<P>, IApiPart<P>
        where P : ApiPart<P>, new()
    {
        protected ApiPart()
        {
            
        }
        
        public IApiCatalog Catalog
            => (IApiCatalog)ApiCatalogProvider.Define(Id, Owner, new ApiCatalog(typeof(P).Assembly, base.Id, base.ResourceProvider));

        public virtual void Run(params string[] args)
            => Console.Error.Write("Assembly has no executor");

        public override string ToString()
            => Format();
    }

    public abstract class ApiPart<P,C> : ApiPart<P>
        where P : ApiPart<P,C>, new()
        where C : ApiCatalog<C>, new()
    {        
        protected ApiPart()
            : base()
        {

        }
    }
}