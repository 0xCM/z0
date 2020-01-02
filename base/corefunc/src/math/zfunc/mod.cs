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
    /// Computes m % n quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static sbyte mod<N>(sbyte m, N n = default)
        where N : unmanaged, ITypeNat
            => (sbyte)(mod<N>((uint)m) * sign(m));

    /// <summary>
    /// Computes m % n quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static byte mod<N>(byte m, N n = default)
        where N : unmanaged, ITypeNat
            => (byte)mod<N>((uint)m);

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static short mod<N>(short m, N n = default)
        where N : unmanaged, ITypeNat
            => (short)(mod<N>((uint)m) * sign(m));

    /// <summary>
    /// Computes m % n quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static ushort mod<N>(ushort m, N n = default)
        where N : unmanaged, ITypeNat
            => (ushort)mod<N>((uint)m);

    /// <summary>
    /// Computes m % n quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static int mod<N>(int m, N n = default)
        where N : unmanaged, ITypeNat
            => (int)mod<N>((uint)m) * sign(m);

    /// <summary>
    /// Computes m % n quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static uint mod<N>(uint m, N n = default)
        where N : unmanaged, ITypeNat
            => Mod<N>.mod(m);

    /// <summary>
    /// Computes m % n not so quickly
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static long mod<N>(long m, N n = default)
        where N : unmanaged, ITypeNat
            => m % (long)n.NatValue  * sign(m);


}