//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes a resolver that produces <typeparamref name='E'/>-refined <typeparamref name='T'/> values of width <typeparamref name='W'/>
    /// </summary>
    /// <typeparam name="W">The resolution width</typeparam>
    /// <typeparam name="E">The refining type</typeparam>
    /// <typeparam name="T">The primitive resolution type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IRefiningResolver<W,E,T> : IPrimalResolver<W,T>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
        where T : unmanaged
    {
        Type IDataResolver.RefiningType
            => typeof(E);

        void Resolve(ref E dst);

        void Resolve(uint count, Span<E> dst);
    }
}