//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalResolver : IDataResolver
    {
        Type PrimalType {get;}
    }

    /// <summary>
    /// Characterizes a resolver that produces unmanaged primitive <typeparamref name='T'/> values of width <typeparamref name='W'/>
    /// </summary>
    /// <typeparam name="W">The resolution width</typeparam>
    /// <typeparam name="T">The primitive resolution type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalResolver<W,T> : IPrimalResolver, IDataResolver<T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        TypeWidth IDataResolver.TargetWidth
            => Widths.type<W>();

        Type IPrimalResolver.PrimalType
            => typeof(T);
    }
}