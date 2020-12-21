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
    using static memory;

    partial struct Records
    {
        /// <summary>
        /// Defines a field value within the context of a <see cref='S'/> parametric record
        /// </summary>
        /// <param name="src">The source record</param>
        /// <param name="field">The defining field</param>
        /// <param name="value">The field value</param>
        /// <typeparam name="S">The record type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static FieldValue<S,T> value<S,T>(S src, FieldInfo field, T value)
            where S : struct, IRecord<S>
                => new FieldValue<S,T>(src, field, value);
    }
}