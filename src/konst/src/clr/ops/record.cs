//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrFieldRecord record(FieldInfo src)
        {
            var data = adapt(src);
            var dst = new ClrFieldRecord();
            dst.Key = reference(data);
            dst.DeclaringType = data.DeclaringType.Token;
            dst.DataType = data.FieldType.Token;
            dst.Attributes = data.Attributes;
            dst.Address = data.Address;
            dst.IsStatic = data.IsStatic;
            return dst;
        }
    }
}