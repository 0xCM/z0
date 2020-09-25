//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The production type</typeparam>
    [Free]
    public interface IEmitter<A> : IFunc<A>
    {

    }

    [Free]
    public interface IEmitter128<T> : IEmitter<Vector128<T>>, IFunc128<T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IEmitter256<T> : IEmitter<Vector256<T>>, IFunc256<T>
        where T : unmanaged
    {

    }
}