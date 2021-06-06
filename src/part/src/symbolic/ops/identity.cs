//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct Symbols
    {
        [Op]
        public static SymIdentity identity(FieldInfo field, ushort index, SymExpr expr)
            => string.Format("{0:D3}:{1}:{2}::{3}.{4}({5})",
                    index,
                    RP.bracket((CliToken)field),
                    field.DeclaringType.Assembly.GetSimpleName(),
                    field.DeclaringType.FullName,
                    field.Name,
                    expr);
    }
}