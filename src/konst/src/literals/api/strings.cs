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

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] strings(Type src)
        {
            var fields = src.DeclaredFields();
            return search(src).Where(f => f.IsStringLiteral());
        }

        [MethodImpl(Inline), Op]
        public static void strings(Type src, Span<string> dst)
        {
            var fields = span(src.DeclaredFields());
            var match = typeof(string);
            ref readonly var lead = ref first(fields);
            var count = fields.Length;

            var j=0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(lead,i);
                if(field.IsLiteral && field.FieldType == match)
                    seek(dst,j++) = (string)field.GetRawConstantValue();
            }
        }
    }
}