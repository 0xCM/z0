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
    using static ClrViews;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrPrimitiveInfo record(PrimalKind src)
            => new ClrPrimitiveInfo(src, SystemPrimitives.width(src), SystemPrimitives.sign(src), (PrimalTypeCode)SystemPrimitives.code(src));

        [MethodImpl(Inline), Op]
        public static ClrFieldRecord record(FieldInfo src)
        {
            var data = ClrViews.view(src);
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