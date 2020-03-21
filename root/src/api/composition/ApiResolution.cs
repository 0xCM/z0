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

    public abstract class ApiResolution<T> : Resolution<T>, IApiAssembly<T>
        where T : ApiResolution<T>, new()
    {
        protected ApiResolution()
        {
            this.Id = typeof(T).Assembly.Id();
        }

        protected internal ApiResolution(AssemblyId id)
        {
            this.Id = id;   
        }

        public virtual AssemblyId Id {get;}

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

    public abstract class ApiResolution<T,C> : ApiResolution<T>
        where T : ApiResolution<T,C>, new()
        where C : ApiCatalog<C>, new()
    {
        public override IApiCatalog Operations  => new C();

        protected ApiResolution(AssemblyId id)
            : base(id)
        {
            
        }
    }

    [Ignore]
    sealed class EmptyResolution : ApiResolution<EmptyResolution>
    {

        public EmptyResolution()
        {

        }

        public override AssemblyId Id => AssemblyId.None;
    }
}