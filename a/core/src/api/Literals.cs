//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;          

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        public static W1024 w1024 => default(W1024);

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

        public static N64 n64 => default;

        public static N128 n128 => default;

        public static N256 n256 => default;

        public static N512 n512 => default;

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
    }
}