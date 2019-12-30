//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Characterizes a source of T-valued patterns
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPatternSource<T> : IFunc<T>
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized pattern source
    /// </summary>
    /// <typeparam name="W">The vector width type</typeparam>
    /// <typeparam name="V">The vector type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource<W,V,T> : IPatternSource<V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a 128-bit vector pattern source
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource128<T> : IVPatternSource<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a 256-bit vector pattern source
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVPatternSource256<T> : IVPatternSource<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

}