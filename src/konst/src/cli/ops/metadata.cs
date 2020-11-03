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
    using System.Reflection.Metadata;

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
            dst.DeclaringType = a.DeclaringType.Key;
            dst.DataType = a.FieldType.Key;
            dst.Attributes = a.Attributes;
            dst.Address = a.Address;
            dst.IsStatic = a.IsStatic;
            return dst;
        }

        /// <summary>
        /// Returns a reference to the cli metadata for an assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref SegRef metadata(Assembly src, out SegRef dst)
        {
            src.TryGetRawMetadata(out var ptr, out var len);
            dst = new SegRef(ptr,len);
            return ref dst;
        }
    }
}