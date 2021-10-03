//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using N = BlittableNames;

    [SymSource]
    public enum BlittableKind : byte
    {
        /// <summary>
        /// Mystery kind
        /// </summary>
        [Symbol(N.Unknown)]
        Unknown = 0,

        /// <summary>
        /// Indicates a type represents an unsigned integral value
        /// </summary>
        [Symbol(N.Unsigned)]
        Unsigned = 1,

        /// <summary>
        /// Indicates a type represents a signed integral value
        /// </summary>
        [Symbol(N.Signed)]
        Signed = 2,

        /// <summary>
        /// Indicates a type represents a floating-point value
        /// </summary>
        [Symbol(N.Float)]
        Float = 3,

        /// <summary>
        /// Indicates a type represents a character value
        /// </summary>
        [Symbol(N.Char)]
        Char = 4,

        /// <summary>
        /// Indicates a type over the integral domain that specified list of named values
        /// </summary>
        [Symbol(N.Enum)]
        Enum = 5,

        /// <summary>
        /// Indicates a composite type that uniformly partitions a sequence of bits over a finite number of homogenously-typed values
        /// </summary>
        /// <example>
        /// v8x32u := a packed sequence of 8 u32 values
        /// v13x3i := a packed sequence of 13 i32 values
        /// </example>
        [Symbol(N.Vector)]
        Vector = 6,

        /// <summary>
        /// Indicates a composite type that uniformly partitions a sequence of bits over a finite number of typed values of potentially non-uniform type
        /// </summary>
        [Symbol(N.Array)]
        Array = 7,

        /// <summary>
        /// Indicates a composite type covers a finite sequence of <see cref='Vector'/> values of potentially non-uniform type
        /// </summary>
        /// <example>
        /// t:[v3x32u, v5x1u, v1x8c]
        /// </example>
        [Symbol(N.Tensor)]
        Tensor = 8,

        /// <summary>
        /// Indicates a metatype that forms a typespace
        /// </summary>
        [Symbol(N.Domain)]
        Domain = 9,

        /// <summary>
        /// Indicates a mathematical sequence over a given domain
        /// </summary>
        /// <example>
        /// A sequence {x0,x1,...xN} of N values
        /// </example>
        [Symbol(N.Seq)]
        Seq = 10,

        /// <summary>
        /// Indicates a grid
        /// </summary>
        [Symbol(N.Grid)]
        Grid = 11,

        /// <summary>
        /// Indicates a type that represents an identifier, unique within some scope
        /// </summary>
        [Symbol(N.Name)]
        Name = 12,

        /// <summary>
        /// Indicates a type that represents a sequence of bits
        /// </summary>
        [Symbol(N.BitVector)]
        BitVector = 13,

        /// <summary>
        /// Indicates a type that defines a function
        /// </summary>
        [Symbol(N.Function)]
        Function = 15,

        /// <summary>
        /// Indicates an ordered pair (a0,a1)
        /// </summary>
        [Symbol(N.Pair)]
        Pair = 16,

        /// <summary>
        /// Indicates a contiguous cell sequence
        /// </summary>
        [Symbol(N.Block)]
        Block = 17,

        /// <summary>
        /// Indicates an N-tuple (a0,...,aN)
        /// </summary>
        [Symbol(N.Tuple)]
        Tuple = 18,

        /// <summary>
        /// Indicates a finite sequence of bits
        /// </summary>
        [Symbol(N.BitSeq)]
        BitSeq = 19,
    }


    [LiteralProvider]
    public readonly struct BlittableNames
    {
        public const string Unknown = "?";

        public const string Unsigned = "u";

        public const string Signed = "i";

        public const string Float = "f";

        public const string Char = "c";

        public const string Enum = "enum";

        public const string Vector = "v";

        public const string Array = "array";

        public const string Tensor = "tensor";

        public const string Domain = "domain";

        public const string Seq = "seq";

        public const string Grid = "grid";

        public const string Name = "name";

        public const string BitVector = "bv";

        public const string Tuple = "tuple";

        public const string Function = "fx";

        public const string Pair = "pair";

        public const string Block = "block";

        public const string BitSeq = "bits";
    }
}