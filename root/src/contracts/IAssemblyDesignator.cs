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
    /// Characterizes a type that is responsible for identifying/classifying an assembly
    /// </summary>
    public interface IAssemblyDesignator : ICatalogProvider
    {
        /// <summary>
        /// Specifies the identifier of the designate, i.e. the  designated assembly
        /// </summary>
        AssemblyId Id {get;}

        /// <summary>
        /// The designates delclared by the designate
        /// </summary>
        IEnumerable<IAssemblyDesignator> Designates {get;}

        /// <summary>
        /// The designate
        /// </summary>
        Assembly DeclaringAssembly {get;}

        /// <summary>
        /// The assembly role
        /// </summary>
        AssemblyRole Role
            => AssemblyRole.Library;

        /// <summary>
        /// The designate name, typically determined by the simple assembly name
        /// </summary>
        string Name
            => DeclaringAssembly.GetName().Name;

        /// <summary>
        /// If designate supports a means of execution, invokes it; otherwise, does nothing
        /// </summary>
        /// <param name="args">Arguments passed to the execution controller</param>
        void Run(params string[] args);
    }
}