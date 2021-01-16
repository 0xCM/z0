//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost(ApiNames.CellOpKinds, true)]
    public partial class CellOpKinds
    {
        const NumericKind Closure = Integers;

        [Op]
        public static CellOpKind[] kinds()
            => typeof(CellOpKinds).StaticProperties(true,false)
                    .Reifies(typeof(ICellOpKind))
                    .Select(p => p.MemberValue<ICellOpKind>(null))
                    .Select(k => new CellOpKind(k.OperandWidth, k.OperandType, k.OperatorType));

    }
}