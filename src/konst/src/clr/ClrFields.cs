//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ReflectionFlags;

    [ApiHost]
    public readonly struct ClrFields
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the declared instance fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> instance(Type src, bool declared = true)
            => Clr.view(src.GetFields(declared ? BF_DeclaredInstance : BF_All));

        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> all(Type src)
            => Clr.fields(src);
    }
}