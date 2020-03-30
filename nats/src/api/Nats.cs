//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;

    /// <summary>
    /// Exposes a basic api for natural negotiation and defines static properties
    /// that present the values of common natural numbers
    /// </summary>
    public static class Nats
    {
        [MethodImpl(Inline)]   
        public static Next<K> next<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Returns the value represented by a natural type
        /// </summary>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static NatVal natval<N>(N n = default) 
            where N : unmanaged, ITypeNat
                => NatVal.From(TypeNats.value<N>()); 

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

        public static N56 n56 => default;

        public static N57 n57 => default;

        public static N58 n58 => default;

        public static N59 n59 => default;

        public static N60 n60 => default;

        public static N61 n61 => default;

        public static N62 n62 => default;

        public static N63 n63 => default;

        public static N64 n64 => default;

        public static N128 n128 => default;

        public static N256 n256 => default;

        public static N512 n512 => default;

        public static N1024 n1024 => default;

        public static N2048 n2048 => default;

        public static N4096 n4096 => default;

        public static N8192 n8192 => default;

        public static N16384 n16384 => default; 

        public static N32768 n32768 => default;             

        /// <summary>
        /// A bit with state 1
        /// </summary>
        public static bit on
        {
            [MethodImpl(Inline)]
            get => bit.On;
        }

        /// <summary>
        /// A bit with state 0
        /// </summary>
        public static bit off
        {
            [MethodImpl(Inline)]
            get => bit.Off;
        }

        /// <summary>
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        public const sbyte z8i = 0;

        /// <summary>
        /// The zero-value for an 8-bit usigned integer
        /// </summary>
        public const byte z8 = 0;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        public const short z16i = 0;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        public const ushort z16 = 0;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        public const int z32i = 0;

        /// <summary>
        /// The zero-value for a 32-bit usigned integer
        /// </summary>
        public const uint z32 = 0;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        public const long z64i = 0;

        /// <summary>
        /// The zero-value for a 64-bit usigned integer
        /// </summary>
        public const ulong z64 = 0;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        public const float z32f = 0;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        public const double z64f = 0;

        /// <summary>
        /// The maximum value for an 8-bit signed integer
        /// </summary>
        public const sbyte i8max = sbyte.MaxValue;

        /// <summary>
        /// The maximum value for an 8-bit usigned integer
        /// </summary>
        public const byte u8max = byte.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit signed integer
        /// </summary>
        public const short i16max = short.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit unsigned integer
        /// </summary>
        public const ushort u16max = ushort.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit signed integer
        /// </summary>
        public const int i32max = int.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit usigned integer
        /// </summary>
        public const uint u32max = uint.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit signed integer
        /// </summary>
        public const long i64max = long.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit usigned integer
        /// </summary>
        public const ulong u64max = ulong.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit float
        /// </summary>
        public const float f32max = float.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit float
        /// </summary>
        public const double f64max = double.MaxValue;

        /// <summary>
        /// The minimum value for an 8-bit signed integer
        /// </summary>
        public const sbyte i8min = sbyte.MinValue;

        /// <summary>
        /// The minimum value for a 16-bit signed integer
        /// </summary>
        public const short i16min = short.MinValue;

        /// <summary>
        /// The minimum value for a 32-bit signed integer
        /// </summary>
        public const int i32min = int.MinValue;

    }
}