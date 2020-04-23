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
    public interface ISVPatternSource<W,V,T> : ISVFunc, ISFunc<V>
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
    public interface ISVPatternSource128<T> : ISVPatternSource<W128,Vector128<T>,T>, ISVFunc128<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 256-bit vector pattern source
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVPatternSource256<T> : ISVPatternSource<W256,Vector256<T>,T>, ISVFunc256<T>
        where T : unmanaged
    {

    }
}