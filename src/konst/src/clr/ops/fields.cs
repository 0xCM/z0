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
    using static ReflectionFlags;

    partial struct ClrArtifacts
    {
        /// <summary>
        /// Returns a <see cref='FieldInfo'/> array of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(Type src)
            => src.GetFields(BF_All);

        /// <summary>
        /// Provides a non-allocated <see cref='FieldView'> sequence that covers the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<FieldView> vFields(Type src)
            => View(fields(src), field);
    }

    partial struct ClrQuery
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(Type src)
            => src.GetFields(BF);
    }
}