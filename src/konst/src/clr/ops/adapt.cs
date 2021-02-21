//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static memory;

    partial struct Clr
    {
        /// <summary>
        /// Defines a <see cref='ClrAssembly'/> over an <see cref='Assembly'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrAssembly adapt(Assembly src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrModule'/> over a <see cref='Module'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrModule adapt(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrField'/> over a <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrField adapt(FieldInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrMethod'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrMethod adapt(MethodInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrAssembly> adapt(Assembly[] src)
            => adapt<Assembly,ClrAssembly>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrType> adapt(Type[] src)
            => adapt<Type,ClrType>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrModule> adapt(Module[] src)
            => adapt<Module,ClrModule>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrMethod> adapt(MethodInfo[] src)
            => adapt<MethodInfo,ClrMethod>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrField> adapt(FieldInfo[] src)
            => adapt<FieldInfo,ClrField>(src);

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> adapt<S,V>(S[] src)
            => recover<S,V>(@readonly(src));

    }
}