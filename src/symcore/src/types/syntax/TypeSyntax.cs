//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static TypeSyntax.Scalars;
    using static TypeSyntax.Naturals;
    using static TypeSyntax.Composers;
    using static TypeSyntax.Widths;

    using static Root;

    [ApiHost]
    public readonly struct TypeSyntax
    {
        /// <summary>
        /// Defines a specifier for a natural number <paramref name='n'/>
        /// </summary>
        /// <param name="n">The natural value</param>
        [Op]
        public static string natural(uint n)
            => n.ToString();

        /// <summary>
        /// Defines a specifier for a bit-width <paramref name='w'/>
        /// </summary>
        /// <param name="w">The bit width</param>
        [Op]
        public static string width(uint w)
            => natural(w);

        /// <summary>
        /// Defines a specifier for a scalar of bit-width <paramref name='w'/> of class <paramref name='k'/>
        /// </summary>
        /// <param name="k">The primal class</param>
        /// <param name="w">The bit width</param>
        [Op]
        public static string scalar(PrimalClass k, uint w)
            => string.Format("{0}{1}",k,w);

        /// <summary>
        /// Defines a specifier for an <paramref name='n'/>-dimensional vector with cells of bit-width <paramref name='w'/> of primal class <paramref name='k'/>
        /// </summary>
        /// <param name="n">The vector dimension</param>
        /// <param name="k">The cell's primal class</param>
        /// <param name="w">The cell's width</param>
        [Op]
        public static string vector(uint n, PrimalClass k, uint w)
            => string.Format("v{0}x{1}{2}", n, k, w);

        [LiteralProvider]
        public readonly struct Composers
        {
            /// <summary>
            /// The signed specifier
            /// </summary>
            public const string i = "u";

            /// <summary>
            /// The unsigned specifier
            /// </summary>
            public const string u = "u";

            /// <summary>
            /// The floating-point specifier
            /// </summary>
            public const string f = "f";

            /// <summary>
            /// The vector specifier
            /// </summary>
            public const string v = "v";

            /// <summary>
            /// The product specifier
            /// </summary>
            public const string x = "x";

            /// <summary>
            /// The sum specifier
            /// </summary>
            public const string or = "|";

            /// <summary>
            /// The seqence specifier
            /// </summary>
            public const string seq = "*";

            /// <summary>
            /// The left grouping/containment specifier
            /// </summary>
            public const string left = "(";

            /// <summary>
            /// The right grouping/containment specifier
            /// </summary>
            public const string right = ")";
        }

        [LiteralProvider]
        public readonly struct Naturals
        {
            /// <summary>
            /// The number 0
            /// </summary>
            public const string N0 = "0";

            /// <summary>
            /// The natural number 1
            /// </summary>
            public const string N1 = "1";

            /// <summary>
            /// The natural number 2
            /// </summary>
            public const string N2 = "2";

            /// <summary>
            /// The natural number 3
            /// </summary>
            public const string N3 = "3";

            /// <summary>
            /// The natural number 4
            /// </summary>
            public const string N4 = "4";

            /// <summary>
            /// The natural number 5
            /// </summary>
            public const string N5 = "5";

            /// <summary>
            /// The natural number 6
            /// </summary>
            public const string N6 = "6";

            /// <summary>
            /// The natural number 7
            /// </summary>
            public const string N7 = "7";

            /// <summary>
            /// The natural number 8
            /// </summary>
            public const string N8 = "8";

            /// <summary>
            /// The natural number 6
            /// </summary>
            public const string N16 = "16";

            /// <summary>
            /// The natural number 32
            /// </summary>
            public const string N32 = "32";

            /// <summary>
            /// The natural number 32
            /// </summary>
            public const string N64 = "64";

            /// <summary>
            /// The natural number N
            /// </summary>
            public const string N = "{N}";
        }

        [LiteralProvider]
        public readonly struct Widths
        {
            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W1 = N1;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W2 = N2;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W3 = N3;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W4 = N4;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W5 = N5;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W6 = N6;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W7 = N7;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W8 = N8;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W16 = N16;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W32 = N32;

            /// <summary>
            /// Specifies a bit width of 1
            /// </summary>
            public const string W64 = N64;

            /// <summary>
            /// Specifies a parametric bit width
            /// </summary>
            public const string W = "{W}";
        }

        [LiteralProvider]
        public readonly struct Scalars
        {
            /// <summary>
            /// An unsigned bit (An abstract type)
            /// </summary>
            public const string u1 = N0;

            /// <summary>
            /// A signed bit (An abstract type)
            /// </summary>
            public const string i1 = N1;

            /// <summary>
            /// A quantity of bit-width 1 that may have the value of 0 or 1
            /// </summary>
            public const string bit = u1 + or + i1;

            /// <summary>
            /// Signed 8-bit scalars
            /// </summary>
            public const string i8 = i + N8;

            /// <summary>
            /// Unsigned 8-bit scalars
            /// </summary>
            public const string u8 = u + N8;

            /// <summary>
            /// Signed 16-bit scalars
            /// </summary>
            public const string i16 = i + N16;

            /// <summary>
            /// Unsigned 16-bit scalars
            /// </summary>
            public const string u16 = u + N16;

            /// <summary>
            /// Signed 32-bit scalars
            /// </summary>
            public const string i32 = i + N32;

            /// <summary>
            /// Unsigned 32-bit scalars
            /// </summary>
            public const string u32 = u + N32;

            /// <summary>
            /// Signed 64-bit scalars
            /// </summary>
            public const string i64 = i + N64;

            /// <summary>
            /// Unsigned 64-bit scalars
            /// </summary>
            public const string u64 = u + N64;

            /// <summary>
            /// 16-bit floating points
            /// </summary>
            public const string f16 = f + N16;

            /// <summary>
            /// 32-bit floating points
            /// </summary>
            public const string f32 = f + N32;

            /// <summary>
            /// 64-bit floating points
            /// </summary>
            public const string f64 = f + N64;

            /// <summary>
            /// Signed N-bit scalars
            /// </summary>
            public const string iN = i + N;

            /// <summary>
            /// Unsigned N-bit scalars
            /// </summary>
            public const string uN = u + N;
        }

        [LiteralProvider]
        public readonly struct Vectors
        {
            /// <summary>
            /// A 1-dimensional vector over signed 8-bit integers
            /// </summary>
            public const string v1xi8 = v + N1 + x + i8;

            /// <summary>
            /// A 2-dimensional vector over signed 8-bit integers
            /// </summary>
            public const string v2xi8 = v + N2 + x + i8;

            /// <summary>
            /// A 3-dimensional vector over signed 8-bit integers
            /// </summary>
            public const string v3xi8 = v + N3 + x + i8;

            /// <summary>
            /// An N-dimensional vector over signed 8-bit integers
            /// </summary>
            public const string vNxi8 = v + N + x  + i8;

            /// <summary>
            /// A 1-dimensional vector over signed 8-bit integers
            /// </summary>
            public const string v1xu8 = v + N1 + x + i8;

            /// <summary>
            /// A 2-dimensional vector over unsigned 8-bit integers
            /// </summary>
            public const string v2xu8 = v + N2 + x + u8;

            /// <summary>
            /// A 3-dimensional vector over unsigned 8-bit integers
            /// </summary>
            public const string v3xu8 = v + N3 + x + u8;

            /// <summary>
            /// An N-dimensional vector over unsigned 8-bit integers
            /// </summary>
            public const string vNxu8 = v + N + x + u8;

            /// <summary>
            /// An N-dimensional vector over signed W-bit integers
            /// </summary>
            public const string vNxuW = v + N + x + u + W;

            /// <summary>
            /// An N-dimensional vector over unsigned W-bit integers
            /// </summary>
            public const string vNxiW = v + N + x + i + W;
        }

        public readonly struct Domains
        {
            public const string Naturals = nameof(TypeSyntax.Naturals);

            public const string Widths = nameof(TypeSyntax.Widths);

            public const string Scalars = nameof(TypeSyntax.Scalars);

            public const string Vectors = nameof(TypeSyntax.Vectors);
        }
    }
}