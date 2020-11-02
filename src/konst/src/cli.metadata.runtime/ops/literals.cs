//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ClrQuery
    {
        /// <summary>
        /// Returns true if the source field is a literal, false otherwise
        /// </summary>
        /// <param name="src">The field to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsLiteral(FieldInfo src)
            => src.IsLiteral;

        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(in Indexed<FieldInfo> src, Span<FieldInfo> dst)
        {
            var k = 0u;
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
                if(IsLiteral(skip(view,i)))
                    seek(dst, k++) = skip(view,i);
            return slice(dst,k);
        }

        [MethodImpl(Inline), Op]
        public static Span<FieldInfo> literals(Type src, Span<FieldInfo> dst)
            => literals(fields(src), dst);
    }
}