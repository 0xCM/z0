//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IIdentityDiviner : IService
    {

    }

    /// <summary>
    /// Characterizes a serive that attempts to assign a reasonable identity to a method
    /// </summary>
    public interface IMethodIdentityDiviner : IIdentityDiviner<MethodInfo,OpIdentity>
    {
    }

    public interface IDelegateIdentityDiviner : IIdentityDiviner<Delegate,OpIdentity>
    {
    }
}