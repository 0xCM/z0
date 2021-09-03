//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Blit
    {
        [LiteralProvider]
        public readonly struct IndicatorNames
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

            public const string List = "list";

            public const string Function = "fx";

            public const string Pair = "pair";

            public const string Block = "block";

            public const string Tuple = "tuple";
        }
    }
}