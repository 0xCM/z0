//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public abstract class ModuleDesignator<T> : AssemblyResolution<T>, IModuleDesignator
        where T : ModuleDesignator<T>, new()
    {
        public Module DeclaringModule 
            => typeof(T).Module;
    }
}