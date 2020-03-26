//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface IPart : IPartId
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

    public interface IPart<P> : IPart, IEquatable<P>
        where P : IPart<P>, new()   
    {
        Assembly IPart.Owner 
            => typeof(P).Assembly;

        string IPart.Name 
            => Owner.GetName().Name;

        [MethodImpl(Inline)]
        bool IEquatable<P>.Equals(P src)
            => this.Id == src.Id;

        int HashCode
            => Id.GetHashCode();     

        [MethodImpl(Inline)]
        bool BoxedEquals(object src) 
            => src is P a && a.Id == Id;

        PartId IPartId.Id 
            =>  Attribute.IsDefined(Owner, typeof(PartIdAttribute))  
              ? ((PartIdAttribute)Attribute.GetCustomAttribute(Owner, typeof(PartIdAttribute))).Id
              : PartId.None;
    }
}