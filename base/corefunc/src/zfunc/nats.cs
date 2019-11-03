//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{
    /// <summary>
    /// Returns the integral value represented by a natural type as a signed 32-bit integer
    /// </summary>
    /// <typeparam name="N">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static int inat<N>(N n = default) 
        where N : ITypeNat, new()
            => (int)new N().value;

    /// <summary>
    /// Returns the integral value represented by a natural type as an unsigned 32-bit integer
    /// </summary>
    /// <typeparam name="N">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static uint unat<N>(N n = default) 
        where N : ITypeNat, new()
            => (uint)new N().value;

    [MethodImpl(Inline)]   
    public static NatSeq<T0,T1> natseq<T0,T1>(T0 t0 = default, T1 t1 = default)
        where T0 : unmanaged, INatPrimitive<T0>
        where T1 : unmanaged, INatPrimitive<T1>
            => NatSeq<T0,T1>.Rep;

    [MethodImpl(Inline)]   
    public static NatSeq<T0,T1,T2> natseq<T0,T1,T2>(T0 t0 = default, T1 t1 = default, T2 t2 = default)
        where T0 : unmanaged, INatPrimitive<T0>
        where T1 : unmanaged, INatPrimitive<T1>
        where T2 : unmanaged, INatPrimitive<T2>
            => NatSeq<T0,T1,T2>.Rep;

    [MethodImpl(Inline)]   
    public static NatSeq<T0,T1,T2,T3> natseq<T0,T1,T2,T3>(T0 t0 = default, T1 t1 = default, T2 t2 = default, T3 t3 = default)
        where T0 : unmanaged, INatPrimitive<T0>
        where T1 : unmanaged, INatPrimitive<T1>
        where T2 : unmanaged, INatPrimitive<T2>
        where T3 : unmanaged, INatPrimitive<T3>
            => NatSeq<T0,T1,T2,T3>.Rep;


    public static N0 n0 => default;

    public static N1 n1 => default;

    public static N2 n2 => default;

    public static N3 n3 => default;
    
    public static N4 n4 => default;

    public static N5 n5 => default;

    public static N6 n6 => default;

    public static N7 n7 => default;

    public static N8 n8 => default;
    
    public static N9 n9 => default;
    
    public static N10 n10 => default;
    
    public static N11 n11 => default;

    public static N12 n12 => default;

    public static N13 n13 => default;

    public static N14 n14 => default;

    public static N15 n15 => default;

    public static N16 n16 => default;

    public static N17 n17 => default;

    public static N18 n18 => default;

    public static N19 n19 => default;

    public static N20 n20 => default;

    public static N21 n21 => default;

    public static N22 n22 => default;

    public static N23 n23 => default;

    public static N24 n24 => default;

    public static N25 n25 => default;

    public static N26 N26 => default;

    public static N27 n27 => default;

    public static N28 n28 => default;

    public static N29 n29 => default;

    public static NatSeq<N3,N0> n30 => default;

    public static NatSeq<N3,N1> n31 => default;

    public static N32 n32 => default;

    public static NatSeq<N3,N3> n33 => default;

    public static NatSeq<N3,N4> n34 => default;

    public static NatSeq<N3,N5> n35 => default;

    public static NatSeq<N3,N6> n36 => default;

    public static NatSeq<N3,N7> n37 => default;

    public static NatSeq<N3,N8> n38 => default;

    public static NatSeq<N3,N9> n39 => default;

    public static NatSeq<N4,N0> n40 => default;

    public static NatSeq<N4,N1> N41 => default;

    public static NatSeq<N4,N2> n42 => default;

    public static NatSeq<N4,N3> n43 => default;

    public static NatSeq<N4,N4> n44 => default;

    public static NatSeq<N4,N5> n45 => default;

    public static NatSeq<N4,N5> n47 => default;

    public static NatSeq<N4,N8> N48 => default;

    public static N63 n63 => default;

    public static N64 n64 => default;

    public static NatSeq<N6,N5> n65 => default;

    public static NatSeq<N6,N6> n66 => default;

    public static NatSeq<N6,N7> n67 => default;

    public static NatSeq<N6,N8> n68 => default;

    public static NatSeq<N8,N7> n87 => default;

    public static NatSeq<N8,N7> n88 => default;

    public static NatSeq<N1,N1,N1> n111 => default;

    public static N127 n127 => default;

    public static N128 n128 => default;

    public static N255 n255 => default;

    public static N256 n256 => default;

    public static NatSeq<N2,N5,N7> n257 => default;

    public static N512 n512 => default;

    public static N1024 n1024 => default;

    public static NatSeq<N1,N2,N7,N7> n1277 => default;

    public static N2048 n2048 => default;

    public static N4096 n4096 => default;

    public static N8192 n8192 => default;

    public static N16384 n16384 => default; 

    /// <summary>
    /// Creates a natural sequence of length 2
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2> nat<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : INatPrimitive<K1>,new()
        where K2 : INatPrimitive<K2>, new()
            => NatSeq<K1,K2>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 3
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3> nat<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
            => NatSeq<K1,K2,K3>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 4
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <param name="k4">The fourth term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    /// <typeparam name="K4">The fourth term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4> nat<K1,K2,K3,K4>(K1 k1 = default, K2 k2 = default, K3 k3 = default,
            K4 k4 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
        where K4 : INatPrimitive<K4>, new()
            => NatSeq<K1,K2,K3,K4>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 5
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <param name="k4">The fourth term</param>
    /// <param name="k5">The fifth term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    /// <typeparam name="K4">The fourth term type</typeparam>
    /// <typeparam name="K5">The fifth term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4,K5> nat<K1,K2,K3,K4,K5>(K1 k1 = default, K2 k2 = default, K3 k3 = default, 
            K4 k4 = default, K5 k5 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
        where K4 : INatPrimitive<K4>, new()
        where K5 : INatPrimitive<K5>, new()
            => NatSeq<K1,K2,K3,K4,K5>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 6
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <param name="k4">The fourth term</param>
    /// <param name="k5">The fifth term</param>
    /// <param name="k6">The sixth term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    /// <typeparam name="K4">The fourth term type</typeparam>
    /// <typeparam name="K5">The fifth term type</typeparam>
    /// <typeparam name="K6">The sixth term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4,K5,K6> nat<K1,K2,K3,K4,K5,K6>(K1 k1 = default, K2 k2 = default, K3 k3 = default, 
            K4 k4 = default, K5 k5 = default, K6 k6 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
        where K4 : INatPrimitive<K4>, new()
        where K5 : INatPrimitive<K5>, new()
        where K6 : INatPrimitive<K6>, new()
            => NatSeq<K1,K2,K3,K4,K5,K6>.Rep;

}