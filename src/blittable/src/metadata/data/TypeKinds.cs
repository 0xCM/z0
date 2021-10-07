//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = DataKind;

    partial struct BitFlow
    {
        partial struct Meta
        {
            const byte TypeKindCount = 18;

            internal static ReadOnlySpan<DataKind> TypeKinds
                => new DataKind[TypeKindCount]{
                    K.Unknown,
                    K.Unsigned,
                    K.Signed,
                    K.Float,
                    K.Char,
                    K.Enum,
                    K.Vector,
                    K.Array,
                    K.Tensor,
                    K.Domain,
                    K.Seq,
                    K.Grid,
                    K.Name,
                    K.BitVector,
                    K.Tuple,
                    K.Function,
                    K.Pair,
                    K.Block,
                    };
        }
    }
}