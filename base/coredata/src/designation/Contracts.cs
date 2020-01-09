//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Defines assembly role classifiers
    /// </summary>
    public enum AssemblyRole
    {
        /// <summary>
        /// Indicates the absence of a role classification
        /// </summary>
        Unsclassified = 0,

        /// <summary>
        /// Classifies an assembly as a test host/runner
        /// </summary>
        Test,

        /// <summary>
        /// Classifies an assembly as a benchmark host/runner
        /// </summary>
        Bench,

        /// <summary>
        /// Classifies an assembly as an api library
        /// </summary>
        Library
    }

    /// <summary>
    /// Characterizes a type that is responsible for identifying/classifying an assembly
    /// </summary>
    public interface IAssemblyDesignator
    {
        /// <summary>
        /// The designates delclared by the reifier
        /// </summary>
        IEnumerable<IAssemblyDesignator> Designates {get;}

        /// <summary>
        /// The desginated assembly  
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

        IEnumerable<string> OpNames {get;}        
    }

    /// <summary>
    /// Characterizes a type that is responsible for identifying/classifying a module
    /// </summary>
    public interface IModuleDesignator : IAssemblyDesignator
    {
        /// <summary>
        /// The designated module
        /// </summary>
        Module DeclaringModule {get;}

    }
}