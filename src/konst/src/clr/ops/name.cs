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

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrTypeKind kind(Type src)
        {
            if(src.IsClass)
                return ClrTypeKind.Class;
            else if (src.IsEnum)
                return ClrTypeKind.Enum;
            else if(src.IsInterface)
                return ClrTypeKind.Interface;
            else if(src.IsStruct())
                return ClrTypeKind.Struct;
            else if(src.IsDelegate())
                return ClrTypeKind.Delegate;
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static string name(FieldInfo src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(MethodInfo src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(Type src)
            => src.Name;

        [MethodImpl(Inline), Op]
        public static string name(PropertyInfo src)
            => src.Name;
    }
}