//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct Clr
    {
        [Op]
        public static ushort offset(Type host, FieldInfo field)
            => (ushort)Marshal.OffsetOf(host, field.Name);
    }
}