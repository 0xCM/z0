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
    using static z;

    partial class XReflex
    {
        /// <summary>
        /// Queries the source <see cref='Type'/> for <see cref='FieldInfo'/> members determined by the
        /// <see cref='BF_Declared'/> flags where <see cref='FieldInfo.IsLiteral'/> is true
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] LiteralFields(this Type src)
            => src.GetFields(BF_Declared).Where(f => f.IsLiteral);

        /// <summary>
        /// Queries the source <see cref='Type'/> for <see cref='FieldInfo'/> members determined by the
        /// <see cref='BF_Declared'/> flags where <see cref='FieldInfo.IsLiteral'/> is true with field types that match
        /// a specified type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="match">The literal field type to match</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<FieldInfo> LiteralFields(this Type src, Type match)
            => src.GetFields(BF_Declared).Where(f => f.IsLiteral && f.FieldType == match);
    }
}