//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>
    {
        
    }
}