//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    /// <summary>
    /// Non-generic contract for a value object, which is a reference type that is characterized only by the values 
    /// it represents and otherwise has no identity
    /// </summary>
    public interface IDataObject 
    {
        /// <summary>
        /// Gets the value members defined by the object
        /// </summary>
        DataMember[] DataMembers { get; }

        DataMemberValue[] Destructure();
    }

    /// <summary>
    /// Generic contract for a value object, which is a reference type that is characterized only by the values 
    /// it represents and otherwise has no identity
    /// </summary>
    public interface IDataObject<T> : IDataObject, IEquatable<T>
    {

    }
}