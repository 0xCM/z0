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

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] search(Type src)
        {
            var fields = src.Fields();
            
            return fields.Literals();
        }
        
        [MethodImpl(Inline), Op]
        public static FieldInfo[] search(Type src, Type match)
            => search(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldInfo[] search<T>(Type match)
            => search(match).Where(f => f.IsLiteral && f.FieldType == typeof(T));
    }
}