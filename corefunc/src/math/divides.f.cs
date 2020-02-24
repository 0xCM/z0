//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{            
    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, uint m)
        where N : unmanaged, ITypeNat
            => Mod<N>.divisible(m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, long m)
        where N : unmanaged, ITypeNat
            => (ulong)m % n.NatValue == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, ulong m)
        where N : unmanaged, ITypeNat
            => m % n.NatValue == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, int m)
        where N : unmanaged, ITypeNat
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, short m)
        where N : unmanaged, ITypeNat
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, ushort m)
        where N : unmanaged, ITypeNat
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, byte m)
        where N : unmanaged, ITypeNat
            => divides<N>(n, (uint)m);
    
    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, sbyte m)
        where N : unmanaged, ITypeNat
            => divides<N>(n, (uint)m);
}
