//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Characterizes a service that attempts to assign a non-cryptic identity to a 
    /// subject that is both useful and unique within the intended scope
    /// </summary>
    /// <typeparam name="S">The type of the thing to identify</typeparam>
    /// <typeparam name="T">The target identity type</typeparam>
    public interface IIdentityDiviner<S,T> : IIdentityDiviner
        where T : IIdentified
    {
        /// <summary>
        /// Reifies an identity divination algorithm
        /// </summary>
        /// <param name="arg">The divinity source</param>
        T DivineIdentity(S arg);        
    }

    /// <summary>
    /// Characterizes a serive that attempts to assign a reasonable identity to a type
    /// </summary>
    public interface ITypeIdentityDiviner : IIdentityDiviner<Type,TypeIdentity>
    {
    }
}