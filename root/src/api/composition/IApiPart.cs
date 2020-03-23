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
    /// Characterizes an object that, when extant, proves that the represented assembly 
    /// is resolved/loaded/ready-for-use
    /// </summary>
    public interface IApiPart : IPart, ICustomFormattable
    {
        /// <summary>
        /// The designates delclared by the designate
        /// </summary>
        IEnumerable<IApiPart> Constituents {get;}

        IApiCatalog Catalog {get;}

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
   public interface IApiPart<P> : IApiPart, IPart<P>, IFormattable<P>
        where P : IApiPart<P>, new()   
    {
        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly IPart.Owner
            => typeof(P).Assembly;

        /// <summary>
        /// The simple assembly name
        /// </summary>
        string IPart.Name
            => Owner.GetName().Name;
    }
}