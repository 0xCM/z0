//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CellFunctions
    {
        public readonly struct Signature : ISignature<Signature>
        {
            readonly Cell128 Data;

            [MethodImpl(Inline)]
            internal Signature(Cell128 src)
                => Data = src;

            public ReadOnlySpan<TypeWidth> ArgWidths
                 => default;

            public TypeWidth ResultWidth
                => (TypeWidth)(Data.Hi >> (64 - 16));
        }
   }
}