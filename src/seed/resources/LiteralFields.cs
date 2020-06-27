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
    using static Root;
    using static ReflectionFlags;

    [ApiHost]
    public readonly struct LiteralFields
    {
        [Op]
        public static FieldInfo[] strings(Type src)
            => search(src).Where(f => f.IsLiteral && f.FieldType == typeof(string));        
        
        [Op]
        public static FieldInfo[] search(Type src)
            => src.GetFields(BF_Declared).Where(f => f.IsLiteral);        
        
        [Op]
        public static FieldInfo[] search(Type src, Type match)
            => search(src);

        [Op, Closures(AllNumeric)]
        public static FieldInfo[] search<T>(Type match)
            => search(match).Where(f => f.IsLiteral && f.FieldType == typeof(T));
    }
}