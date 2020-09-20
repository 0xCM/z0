//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using OC = ApiClass;

    public readonly struct ApiClassLimits
    {
        public const ApiClass FirstApiClass = ApiClass.Nullary;

        public const ApiClass LastApiClass = ApiClass.System;

        public const CellOperatorKind FirstCellOperator = (CellOperatorKind)((uint)LastApiClass << 1);

        public const CellOperatorKind LastCellOperator = CellOperatorKind.Function;
    }
}