//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural transformation function
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFMapApi<A,B> : ISFApi<A,B>
    {

    }


}