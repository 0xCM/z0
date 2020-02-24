//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a type that is responsible for identifying/classifying a module
    /// </summary>
    public interface IModuleDesignator : IAssemblyResolution
    {
        /// <summary>
        /// The designated module
        /// </summary>
        Module DeclaringModule {get;}
    }
}