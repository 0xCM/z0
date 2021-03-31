//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Symbols
    {
        [Op]
        public static SymIdentity identity(FieldInfo field, ushort index)
            => text.format(RP.SlotDot4, field.DeclaringType.Assembly.GetSimpleName(), field.DeclaringType.Name, index, field.Name);
    }
}