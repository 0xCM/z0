//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    public interface IAssemblyIdentity
    {
        /// <summary>
        /// The assembly identification
        /// </summary>
        AssemblyId Id {get;}   
    }

    /// <summary>
    /// Characterizes an object that, when extant, proves that the represented assembly 
    /// is resolved/loaded/ready-for-use
    /// </summary>
    public interface IAssemblyResolution : IAssemblyIdentity, ICustomFormattable
    {

        /// <summary>
        /// The designates delclared by the designate
        /// </summary>
        IEnumerable<IAssemblyResolution> Designates {get;}

        /// <summary>
        /// Specifies whther the reification is empty
        /// </summary>
        bool IsNonEmpty {get;}

        /// <summary>
        /// The assembly role
        /// </summary>
        AssemblyRole Role
            => AssemblyRole.Library;

        IOperationCatalog Catalog {get;}

        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly Resolved {get;}

        /// <summary>
        /// The name of the assembly
        /// </summary>
        string Name {get;}
            
        /// <summary>
        /// If designate supports a means of execution, invokes it; otherwise, does nothing
        /// </summary>
        /// <param name="args">Arguments passed to the execution controller</param>
        void Run(params string[] args);
    }

   /// <summary>
   /// Characterizes an object of parametric type that, when extant, proves that the represented assembly 
   /// is resolved/loaded/ready-for-use
   /// </summary>
   public interface IAssemblyResolution<T> : IAssemblyResolution, IFormattable<T>
        where T : IAssemblyResolution<T>, new()   
    {
        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly IAssemblyResolution.Resolved
            => typeof(T).Assembly;

        /// <summary>
        /// The simple assembly name
        /// </summary>
        string IAssemblyResolution.Name
            => Resolved.GetName().Name;

    }
}