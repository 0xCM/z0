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
    using static Part;
    using static memory;

    [ApiHost(ApiNames.MemoryModels, true)]
    public readonly struct MemoryModels
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
        public static Address64 offset(Type t, string field)
            => Option.Try(() => (Address64)OffsetOf(t, field)).ValueOrDefault();

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