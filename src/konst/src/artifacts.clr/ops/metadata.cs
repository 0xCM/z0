//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static FieldMetadata metadata(FieldInfo src)
        {
            var a = ClrViews.view(src);
            var dst = new FieldMetadata();
            dst.Key = reference(a);
            dst.DeclaringType = a.DeclaringType.Id;
            dst.DataType = a.FieldType.Id;
            dst.Attributes = a.Attributes;
            dst.Address = a.Address;
            dst.IsStatic = a.IsStatic;
            return dst;
        }
    }
}