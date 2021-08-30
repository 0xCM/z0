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
        partial struct Types
        {
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
                    K.Sequence,
                    K.Grid,
                    K.Name,
                    K.BitVector,
                    K.List,
                    K.Function,
                    K.Map,

                    K.K17,
                    K.K18,
                    K.K19,
                    K.K20,
                    K.K21,
                    K.K22,
                    K.K23,
                    K.K24,
                    K.K26,
                    K.K26,
                    K.K27,
                    K.K28,
                    K.K29,
                    K.K30,
                    K.K31,
                    };
        }
    }
}