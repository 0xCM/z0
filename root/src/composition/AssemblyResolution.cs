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

    public abstract class AssemblyResolution<T> : IAssemblyResolution<T>
        where T : AssemblyResolution<T>, new()
    {
        protected AssemblyResolution()
        {
            this.Id = 0;
        }

        protected AssemblyResolution(AssemblyId id)
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

        // public virtual AssemblyRole Role 
        //     => AssemblyRole.Library;

        public virtual string Name
            => Resolved.GetName().Name;

        public bool IsNonEmpty
            => Id != AssemblyId.None && Id != AssemblyId.None;

        
        public virtual IEnumerable<IAssemblyResolution> Designates {get;}
            = new IAssemblyResolution[]{};

        public IOpCatalog Catalog
            =>(IOpCatalog)OpCatalogProvider.Define(Id, Resolved, Operations);

        public virtual IOpCatalog Operations {get;}
            = new EmptyCatalog();

        public string Format()
            => Id.Format();

        public virtual void Run(params string[] args)
            => term.error("Assembly has no executor");

        public override string ToString()
            => Format();
    }

    public abstract class AssemblyResolution<T,C> : AssemblyResolution<T>
        where T : AssemblyResolution<T,C>, new()
        where C : OpCatalog<C>, new()
    {
        public override IOpCatalog Operations  => new C();

        protected AssemblyResolution(AssemblyId id)
            : base(id)
        {
            
        }
            
    }

    [Ignore]
    sealed class EmptyResolution : AssemblyResolution<EmptyResolution>
    {

        public EmptyResolution()
        {

        }

        public override AssemblyId Id => AssemblyId.None;
    }

}