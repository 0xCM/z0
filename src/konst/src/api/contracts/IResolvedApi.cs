//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    [Free]
    public interface IResolvedApi
    {
        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        IPart[] Resolved {get;}

        Assembly[] Components
            => Resolved.Select(x => x.Owner);
    }
}