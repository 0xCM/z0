//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>, ISource
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter128<T> : IEmitter<Vector128<T>>, IFunc128<T>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter256<T> : IEmitter<Vector256<T>>, IFunc256<T>
        where T : unmanaged
    {

    }    
}