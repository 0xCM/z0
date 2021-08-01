//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
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
        [Symbol("c")]
        Char = 4,

        /// <summary>
        /// Indicates a type over the integral domain that specified list of named values
        /// </summary>
        [Symbol("e")]
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
        [Symbol("a")]
        Array = 7,

        /// <summary>
        /// Indicates a composite type covers a finite sequence of <see cref='Vector'/> values of potentially non-uniform type
        /// </summary>
        /// <example>
        /// t:[v3x32u, v5x1u, v1x8c]
        /// </example>
        [Symbol("t")]
        Tensor = 8,

        /// <summary>
        /// Indicates a metatype that forms a typespace
        /// </summary>
        [Symbol("d")]
        Domain = 9,

        /// <summary>
        /// Indicates a mathematical sequence over a given domain
        /// </summary>
        /// <example>
        /// A finite sequence {x0,x1,...xN} of N values
        /// A sequence {x0,x1,...} of a coutable number of values
        /// </example>
        [Symbol("s")]
        Sequence = 10,

        /// <summary>
        /// Indicates an homogenous tensor
        /// </summary>
        [Symbol("z")]
        Cube = 11,

        /// <summary>
        /// Indicates a type that represents an identifier, unique within some scope
        /// </summary>
        [Symbol("q")]
        Name = 12,

        [Symbol("bv")]
        BitVector = 13,

        [Symbol("fx")]
        Function = 14,
    }
}