//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ReflectionFlags;

    partial class XTend
    {
        /// <summary>
        /// Queries the source <see cref='Type'/> for <see cref='FieldInfo'/> members determined by the 
        /// <see cref='BF_Declared'/> flags where <see cref='FieldInfo.IsLiteral'/> is true
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] DeclaredLiteralFields(this Type src)
            => src.GetFields(BF_Declared).Where(f => f.IsLiteral);
    }
}