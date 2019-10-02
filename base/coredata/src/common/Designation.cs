//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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


    public interface IAssemblyDesignator
    {
        Assembly DeclaringAssembly {get;}

        IEnumerable<Assembly> Dependencies {get;}         
    }

    public interface IModuleDesignator : IAssemblyDesignator
    {
        Module DeclaringModule {get;}

    }


    public abstract class AssemblyDesignator<T> : IAssemblyDesignator
        where T : AssemblyDesignator<T>, new()
    {
        /// <summary>
        /// The assembly in which the concrete subtype is defined
        /// </summary>
        public static readonly Assembly Assembly = typeof(T).Assembly;

        public Assembly DeclaringAssembly 
            => Assembly;

        public virtual IEnumerable<Assembly> Dependencies 
            => new Assembly[]{};
    }


    public abstract class ModuleDesignator<T> : AssemblyDesignator<T>, IModuleDesignator
        where T : ModuleDesignator<T>, new()
    {
        /// <summary>
        /// The module in which the concrete subtype is defined
        /// </summary>
        public static readonly Module Module = typeof(T).Module;

        public Module DeclaringModule 
            => Module;
    }



}