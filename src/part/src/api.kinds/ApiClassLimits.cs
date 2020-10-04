//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ApiClassLimits
    {
        public const OperationKind FirstApiClass = OperationKind.Nullary;

        public const OperationKind LastApiClass = OperationKind.System;

        public const CellOperatorKind FirstCellOperator = (CellOperatorKind)((uint)LastApiClass << 1);

        public const CellOperatorKind LastCellOperator = CellOperatorKind.Function;
    }
}