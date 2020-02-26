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

        public virtual AssemblyRole Role 
            => AssemblyRole.Library;

        public virtual string Name
            => Resolved.GetName().Name;

        public bool IsNonEmpty
            => Id != AssemblyId.None && Id != AssemblyId.Empty;

        public virtual AssemblyId Id 
            => AssemblyId.None;
        
        public virtual IEnumerable<IAssemblyResolution> Designates {get;}
            = new IAssemblyResolution[]{};

        public IOperationCatalog Catalog
            =>(IOperationCatalog)CatalogProvider.Define(Id, Resolved, Operations);

        public virtual IOperationCatalog Operations {get;}
            = new EmptyCatalog();
             
        public virtual void Run(params string[] args)
        {
            Console.WriteLine("Assembly has no executor");
        }

        public override string ToString()
            => Id.Format();
    }
}