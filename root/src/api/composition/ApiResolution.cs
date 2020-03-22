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

    public abstract class ApiPart<T> : Part<T>, IApiPart<T>
        where T : ApiPart<T>, new()
    {
        protected ApiPart()
        {
            this.Id = typeof(T).Assembly.Id();
        }

        protected internal ApiPart(PartId id)
        {
            this.Id = id;   
        }

        public virtual PartId Id {get;}

        /// <summary>
        /// The resolved assembly representation
        /// </summary>
        public static T Resolution 
            => new T();

        /// <summary>
        /// The resolved assembly
        /// </summary>
        public Assembly Resolved 
            => typeof(T).Assembly;

        public virtual string Name
            => Resolved.GetName().Name;
        
        public virtual IEnumerable<IApiAssembly> Designates {get;}
            = new IApiAssembly[]{};

        public IApiCatalog Catalog
            =>(IApiCatalog)ApiCatalogProvider.Define(Id, Resolved, Operations);

        public virtual IApiCatalog Operations {get;}
            = new EmptyCatalog();

        // public string Format()
        //     => Id.Format();

        public virtual void Run(params string[] args)
            => term.error("Assembly has no executor");

        public override string ToString()
            => Format();
    }

    public abstract class ApiPart<T,C> : ApiPart<T>
        where T : ApiPart<T,C>, new()
        where C : ApiCatalog<C>, new()
    {
        public override IApiCatalog Operations  => new C();

        protected ApiPart(PartId id)
            : base(id)
        {
            
        }
    }

    [Ignore]
    sealed class EmptyResolution : ApiPart<EmptyResolution>
    {

        public EmptyResolution()
        {

        }

        public override PartId Id => PartId.None;
    }
}