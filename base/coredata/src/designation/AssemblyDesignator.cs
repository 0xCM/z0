//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public abstract class AssemblyDesignator<T> : IAssemblyDesignator
        where T : AssemblyDesignator<T>, new()
    {
        /// <summary>
        /// The assembly in which the concrete subtype is defined
        /// </summary>
        public static Assembly Assembly => typeof(T).Assembly;

        public static T Designated => new T();

        public Assembly DeclaringAssembly 
            => typeof(T).Assembly;

        public virtual AssemblyRole Role 
            => AssemblyRole.Library;

        public virtual IEnumerable<IAssemblyDesignator> Designates {get;}

        public virtual void Run(params string[] args)
        {
            Console.WriteLine("Assembly has no executor");
        }
    }

}