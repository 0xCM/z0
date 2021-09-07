//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = BlittableKind;

    partial struct Blit
    {
        partial struct Meta
        {
            const byte TypeKindCount = 18;

            internal static ReadOnlySpan<BlittableKind> TypeKinds
                => new BlittableKind[TypeKindCount]{
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