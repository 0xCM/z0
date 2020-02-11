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

    public abstract class AssemblyDesignator<T> : IAssemblyDesignator
        where T : AssemblyDesignator<T>, new()
    {
        /// <summary>
        /// The assembly in which the concrete subtype is defined
        /// </summary>
        public static Assembly Assembly 
            => typeof(T).Assembly;

        public static T Designated 
            => new T();

        public Assembly DeclaringAssembly 
            => typeof(T).Assembly;

        public virtual AssemblyRole Role 
            => AssemblyRole.Library;

        public virtual string Name
            => Assembly.GetName().Name;

        public bool IsNonEmpty
            => Id != AssemblyId.None && Id != AssemblyId.Empty;

        public virtual AssemblyId Id 
            => AssemblyId.None;
        
        public virtual IEnumerable<IAssemblyDesignator> Designates {get;}
            = new IAssemblyDesignator[]{};

        public virtual IOperationCatalog Catalog {get;}
            = new EmptyCatalog();
             
        public virtual void Run(params string[] args)
        {
            Console.WriteLine("Assembly has no executor");
        }

        public override string ToString()
            => Id.Format();
    }
}