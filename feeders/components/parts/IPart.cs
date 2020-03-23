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
        Assembly Owner {get;}

        /// <summary>
        /// The name of the assembly
        /// </summary>
        string Name {get;}        
    }

    public interface IPart<A> : IPart
        where A : IPart<A>, new()   
    {
        Assembly IPart.Owner 
            => typeof(A).Assembly;

        string IPart.Name 
            => Owner.GetName().Name;

        PartId IPartIdentity.Id 
            =>  Attribute.IsDefined(Owner, typeof(PartIdAttribute))  
              ? ((PartIdAttribute)Attribute.GetCustomAttribute(Owner, typeof(PartIdAttribute))).Id
              : PartId.None;
    }
}