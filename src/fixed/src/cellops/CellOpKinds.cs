//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;

    public partial class CellOpKinds
    {
        public static IEnumerable<CellOpKind> Known
            => typeof(CellOpKinds).StaticProperties(true,false)
                    .Reifies(typeof(ICellOpKind))
                    .Select(p => p.MemberValue<ICellOpKind>(null))
                    .Select(k => new CellOpKind(k.OperandWidth, k.OperandType, k.OperatorType));
    }
}