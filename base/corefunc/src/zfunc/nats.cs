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
    /// Returns the value represented by a natural type
    /// </summary>
    /// <typeparam name="N">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static NatVal natval<N>(N n = default) 
        where N : unmanaged, ITypeNat
            => NatMath.natval<N>(); 

    /// <summary>
    /// Returns the value represented by a natural type
    /// </summary>
    /// <typeparam name="N">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static ulong nateval<N>(N n = default) 
        where N : unmanaged, ITypeNat
            => NatMath2.natval<N>(); 

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

    /// <summary>
    /// Creates a natural sequence of length 2
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2> nat<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
            => NatSeq<K1,K2>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 3
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3> nat<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
            => NatSeq<K1,K2,K3>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 4
    /// </summary>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4> nat<K1,K2,K3,K4>(K1 k1 = default, K2 k2 = default, K3 k3 = default,
            K4 k4 = default)
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
            => NatSeq<K1,K2,K3,K4>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 5
    /// </summary>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4,K5> nat<K1,K2,K3,K4,K5>(K1 k1 = default, K2 k2 = default, K3 k3 = default, 
            K4 k4 = default, K5 k5 = default)
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
            => NatSeq<K1,K2,K3,K4,K5>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 6
    /// </summary>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4,K5,K6> nat<K1,K2,K3,K4,K5,K6>(K1 k1 = default, K2 k2 = default, K3 k3 = default, 
            K4 k4 = default, K5 k5 = default, K6 k6 = default)
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
        where K6 : unmanaged, INatPrimitive<K6>
            => NatSeq<K1,K2,K3,K4,K5,K6>.Rep;

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

    public static N30 n30 => default;

    public static N31 n31 => default;

    public static N32 n32 => default;

    public static N33 n33 => default;

    public static N34 n34 => default;

    public static N35 n35 => default;

    public static N36 n36 => default;

    public static N37 n37 => default;

    public static N38 n38 => default;

    public static N39 n39 => default;

    public static N40 n40 => default;

    public static N41 N41 => default;

    public static N42 n42 => default;

    public static N43 n43 => default;

    public static N44 n44 => default;

    public static N45 n45 => default;

    public static N46 n46 => default;

    public static N47 n47 => default;

    public static N48 n48 => default;

    public static N49 n49 => default;

    public static N50 n50 => default;

    public static N50 n51 => default;

    public static N52 n52 => default;

    public static N53 n53 => default;

    public static N54 n54 => default;

    public static N55 n55 => default;

    public static N63 n63 => default;

    public static N64 n64 => default;

    public static N87 n87 => default;

    public static N127 n127 => default;

    public static N128 n128 => default;

    public static N255 n255 => default;

    public static N256 n256 => default;

    public static N257 n257 => default;

    public static N512 n512 => default;

    public static N1024 n1024 => default;

    public static N2048 n2048 => default;

    public static N4096 n4096 => default;

    public static N8192 n8192 => default;

    public static N16384 n16384 => default; 

    public static N32768 n32768 => default; 


}