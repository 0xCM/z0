//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    public interface IPartIdentity
    {
        /// <summary>
        /// The assembly identification
        /// </summary>
        PartId Id {get;}   
    }

    public interface IPart : IPartIdentity
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

    public interface IPart<A> : IPart
        where A : IPart<A>, new()   
    {
        Assembly IPart.Resolved 
            => typeof(A).Assembly;

        string IPart.Name 
            => Resolved.GetName().Name;

        PartId IPartIdentity.Id 
            =>  Attribute.IsDefined(Resolved, typeof(PartIdAttribute))  
              ? ((PartIdAttribute)Attribute.GetCustomAttribute(Resolved, typeof(PartIdAttribute))).Id
              : PartId.None;
    }

    public abstract class Part<A> : IPart<A>
        where A : IPart<A>, new()
    {
        public string Format()
            =>  (this as IPartIdentity).Id.Format();
        
        public override string ToString()
            => Format();
    }
}