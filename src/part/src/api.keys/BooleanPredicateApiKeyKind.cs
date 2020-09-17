//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiKeyId;

    public enum BooleanPredicateApiKeyKind : ushort
    {
        None = 0,

        Even = Id.Even,

        Odd = Id.Odd,

        EqPred = Id.EqPred,

        NeqPred = Id.NeqPred,

        LtPred = Id.LtPred,

        LtEqPred = Id.LtEqPred,

        GtPred = Id.GtPred,

        GtEqPred = Id.GtEqPred,
    }
}