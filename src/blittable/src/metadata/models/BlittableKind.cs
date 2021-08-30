//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [SymSource]
    public enum BlittableKind : byte
    {
        /// <summary>
        /// Mystery kind
        /// </summary>
        [Symbol("?")]
        Unknown = 0,

        /// <summary>
        /// Indicates a type represents an unsigned integral value
        /// </summary>
        [Symbol("u")]
        Unsigned = 1,

        /// <summary>
        /// Indicates a type represents a signed integral value
        /// </summary>
        [Symbol("i")]
        Signed = 2,

        /// <summary>
        /// Indicates a type represents a floating-point value
        /// </summary>
        [Symbol("f")]
        Float = 3,

        /// <summary>
        /// Indicates a type represents a character value
        /// </summary>
        [Symbol("char")]
        Char = 4,

        /// <summary>
        /// Indicates a type over the integral domain that specified list of named values
        /// </summary>
        [Symbol("enum")]
        Enum = 5,

        /// <summary>
        /// Indicates a composite type that uniformly partitions a sequence of bits over a finite number of homogenously-typed values
        /// </summary>
        /// <example>
        /// v8x32u := a packed sequence of 8 u32 values
        /// v13x3i := a packed sequence of 13 i32 values
        /// </example>
        [Symbol("v")]
        Vector = 6,

        /// <summary>
        /// Indicates a composite type that uniformly partitions a sequence of bits over a finite number of typed values of potentially non-uniform type
        /// </summary>
        [Symbol("arr")]
        Array = 7,

        /// <summary>
        /// Indicates a composite type covers a finite sequence of <see cref='Vector'/> values of potentially non-uniform type
        /// </summary>
        /// <example>
        /// t:[v3x32u, v5x1u, v1x8c]
        /// </example>
        [Symbol("tnsr")]
        Tensor = 8,

        /// <summary>
        /// Indicates a metatype that forms a typespace
        /// </summary>
        [Symbol("dom")]
        Domain = 9,

        /// <summary>
        /// Indicates a mathematical sequence over a given domain
        /// </summary>
        /// <example>
        /// A finite sequence {x0,x1,...xN} of N values
        /// A sequence {x0,x1,...} of a coutable number of values
        /// </example>
        [Symbol("seq")]
        Sequence = 10,

        /// <summary>
        /// Indicates a grid
        /// </summary>
        [Symbol("grid")]
        Grid = 11,

        /// <summary>
        /// Indicates a type that represents an identifier, unique within some scope
        /// </summary>
        [Symbol("name")]
        Name = 12,

        /// <summary>
        /// Indicates a type that represents a sequence of bits
        /// </summary>
        [Symbol("bv")]
        BitVector = 13,

        /// <summary>
        /// Indicates a type that represents a cell-sequence of natural length where the
        /// cells may be of non-homogenous type
        /// </summary>
        [Symbol("l")]
        List = 14,

        /// <summary>
        /// Indicates a type that defines a function
        /// </summary>
        [Symbol("fx")]
        Function = 15,

        [Symbol("map")]
        Map = 16,

        [Symbol("k17")]
        K17 = 17,

        [Symbol("k18")]
        K18 = 18,

        [Symbol("k19")]
        K19 = 19,

        [Symbol("k20")]
        K20 = 20,

        [Symbol("k21")]
        K21 = 21,

        [Symbol("k22")]
        K22 = 22,

        [Symbol("k23")]
        K23 = 23,

        [Symbol("k24")]
        K24 = 24,

        [Symbol("k25")]
        K25 = 25,

        K26,

        K27,

        K28,

        K29,

        K30,

        K31
    }
}