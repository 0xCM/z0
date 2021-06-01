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
    using static core;

    partial struct Clr
    {
        /// <summary>
        /// Defines a <see cref='ClrAssemblyAdapter'/> over an <see cref='Assembly'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrAssemblyAdapter adapt(Assembly src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrModuleAdapter'/> over a <see cref='Module'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrModuleAdapter adapt(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrFieldAdapter'/> over a <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrFieldAdapter adapt(FieldInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrParameter'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrParameter adapt(ParameterInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ClrMethodAdapter'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ClrMethodAdapter adapt(MethodInfo src)
            => src;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrAssemblyAdapter> adapt(Assembly[] src)
            => adapt<Assembly,ClrAssemblyAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrTypeAdapter> adapt(Type[] src)
            => adapt<Type,ClrTypeAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrModuleAdapter> adapt(Module[] src)
            => adapt<Module,ClrModuleAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrMethodAdapter> adapt(MethodInfo[] src)
            => adapt<MethodInfo,ClrMethodAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> adapt(FieldInfo[] src)
            => adapt<FieldInfo,ClrFieldAdapter>(src);

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> adapt<S,V>(S[] src)
            => recover<S,V>(@readonly(src));
    }
}