//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrTypeKind TypeKind(this Type src)
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

        /// <summary>
        /// Queries the source <see cref='Type'/> for the <see cref='Type'/> it wraps
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static Type ElementType(this Type src)
            => src.GetElementType();
    }
}