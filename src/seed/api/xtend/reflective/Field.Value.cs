//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0
{
    using System;
    using System.Reflection;

    using static Option;

    partial class XTend
    {
        /// <summary>
        /// Attempts to retrieve the value of an instance or static field
        /// </summary>
        /// <param name="field">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> Value(this FieldInfo field, object instance = null)
            => Try(() => field.GetValue(instance));
    }
}