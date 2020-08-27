//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using static System.Runtime.InteropServices.Marshal;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Interop
    {
        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(FieldInfo src)
            => (Address64)OffsetOf(src.DeclaringType, src.Name);

        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(Type t, StringRef name)
            => Option.Try(() => (Address64)OffsetOf(t, name)).ValueOrDefault();

        /// <summary>
        /// Invokes <see cref='OffsetOf'/>
        /// </summary>
        /// <param name="src">the source field</param>

        [MethodImpl(Inline), Op]
        public static Address64 offset(Type t, string name)
            => Option.Try(() => (Address64)OffsetOf(t, name)).ValueOrDefault();

        /// <summary>
        /// Invokes <see cref='OffsetOf{T}'/>
        /// </summary>
        /// <param name="src">the source field name</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Address64 offset<T>(string field)
            => Option.Try(() => (Address64)OffsetOf<T>(field)).ValueOrDefault();
    }
}