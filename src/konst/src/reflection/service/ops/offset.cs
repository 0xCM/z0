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

    using static Konst;
    using static z;

    partial struct ClrReflexSvc
    {
        [MethodImpl(Inline), Op]
        public static Address16 offset(Type host, FieldInfo field)
            => (ushort)Marshal.OffsetOf(host, field.Name);
    }
}