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

    public abstract class ApiPart<P> : Part<P>, IApiPart<P>
        where P : ApiPart<P>, new()
    {
        protected ApiPart()
        {
            this.Id = typeof(P).Assembly.Id();
        }

        protected internal ApiPart(PartId id)
        {
            this.Id = id;   
        }

        public virtual PartId Id {get;}

        /// <summary>
        /// The resolved part
        /// </summary>
        public static P Resolution 
            => new P();

        /// <summary>
        /// The resolved assembly
        /// </summary>
        public Assembly Owner 
            => typeof(P).Assembly;

        public virtual string Name
            => Owner.GetName().Name;
        
        public virtual IEnumerable<IApiPart> Constituents {get;}
            = new IApiPart[]{};

        public IApiCatalog Catalog
            =>(IApiCatalog)ApiCatalogProvider.Define(Id, Owner, Operations);

        public virtual IApiCatalog Operations {get;}
            = new EmptyCatalog();

        public virtual void Run(params string[] args)
            => Console.Error.Write("Assembly has no executor");

        public override string ToString()
            => Format();
    }

    public abstract class ApiPart<P,C> : ApiPart<P>
        where P : ApiPart<P,C>, new()
        where C : ApiCatalog<C>, new()
    {
        public override IApiCatalog Operations  => new C();

        protected ApiPart(PartId id)
            : base(id)
        {
            
        }

        protected ApiPart()
            : base()
        {

        }
    }

}