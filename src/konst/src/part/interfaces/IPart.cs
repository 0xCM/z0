//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IPartId : ITextual
    {
        /// <summary>
        /// The part identifier
        /// </summary>
        PartId Id {get;}

        uint Hash
            => Part.hash(Id);
            
        string ITextual.Format()
            => Part.format(Id);        
    }

    public interface IPartId<P> : IPartId, IEquatable<P>
        where P : IPartId, new()
    {
        bool IEquatable<P>.Equals(P src)
            => src.Id == Id;        
    }

    public interface IPart : IPartId
    {
        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The part name, equivalent to the simple assembly name
        /// </summary>
        string Name 
            => Part.name(Owner);

        /// <summary>
        /// The part identifier, known from the assembly
        /// </summary>
        PartId IPartId.Id 
            => Part.id(Owner);
    }

    public interface IPart<P> : IPart, IPartId<P>, IEquatable<P>
        where P : IPart<P>, new()   
    {
        /// <summary>
        /// The assembly, known from the reifying type
        /// </summary>
        Assembly IPart.Owner
            => typeof(P).Assembly;               
    }
}