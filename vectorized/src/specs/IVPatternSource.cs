//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Characterizes a vectorized pattern source
    /// </summary>
    /// <typeparam name="W">The vector width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource<W,V,T> : IVFunc, ISFApi<V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 128-bit vector pattern source
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource128<T> : IVPatternSource<W128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 256-bit vector pattern source
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource256<T> : IVPatternSource<W256,Vector256<T>,T>
        where T : unmanaged
    {

    }
}