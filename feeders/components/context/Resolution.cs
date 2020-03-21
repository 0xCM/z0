//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    public interface IComponentIdentity
    {
        /// <summary>
        /// The assembly identification
        /// </summary>
        AssemblyId Id {get;}   
    }

    public interface IResolution : IComponentIdentity
    {
        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly Resolved {get;}

        /// <summary>
        /// The name of the assembly
        /// </summary>
        string Name {get;}        
    }

    public interface IResolution<A> : IResolution
        where A : IResolution<A>, new()   
    {
        Assembly IResolution.Resolved 
            => typeof(A).Assembly;

        string IResolution.Name 
            => Resolved.GetName().Name;

        AssemblyId IComponentIdentity.Id 
            =>  Attribute.IsDefined(Resolved, typeof(AssemblyIdAttribute))  
              ? ((AssemblyIdAttribute)Attribute.GetCustomAttribute(Resolved, typeof(AssemblyIdAttribute))).Id
              : AssemblyId.None;
    }

    public abstract class Resolution<A> : IResolution<A>
        where A : IResolution<A>, new()
    {
        public string Format()
            =>  (this as IComponentIdentity).Id.Format();
        
        public override string ToString()
            => Format();
    }
}