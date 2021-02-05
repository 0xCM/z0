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

    partial struct Clr
    {
        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> fields(Type src)
            => adapt(src.GetFields(BF));

        /// <summary>
        /// Returns a <see cref='ClrField'/> readonly span of the fields defined by a parametrically-identified source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [Op, Closures(Closure)]
        public static ReadOnlySpan<ClrField> fields<T>()
            => adapt(typeof(T).GetFields(BF));

        [Op]
        public static FieldInfo field(Module module, int metadataToken, Type[] gTypeArgs, Type[] gMethodArgs)
            => Msil.ModuleExtensions.ResolveField(module, metadataToken, gTypeArgs, gMethodArgs);
    }
}