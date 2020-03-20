//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static ReflectionFlags;

    partial class RootReflections
    {
        /// <summary>
        /// Attempts to retrieve a name-identified field from a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="declared">Whether the field is required to be declared by the source type</param>
        public static Option<FieldInfo> Field(this Type src, string name)
            => src.Fields().FirstOrDefault(f => f.Name == name);

        public static object FieldValue(this Type src, string name, object instance = null)
            => src.Fields().FirstOrDefault(f => f.Name == name)?.GetValue(instance);     

        /// <summary>
        /// Gets the value of a constant field if it exists; otherwise, returns a default value
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="@default">The value to return if the field is not found</param>
        /// <typeparam name="T">The field value type</typeparam>
        public static T LiteralFieldValue<T>(this Type t, string name, T @default = default)
        {
            var f = t.Fields().Literal().FirstOrDefault();
            if(f != null)
                return (T)f.GetRawConstantValue();
            else
                return @default;
        }

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order and which have names that match a specified filter
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<(int index, T value)> LiteralValues<T>(this Type src, string filter, int? maxcount = null)  
            where T : unmanaged  
        {
            var literals = src.LiteralFields().WithNameLike(filter).ToArray();
            var count = Math.Min(maxcount ?? literals.Length, literals.Length);
            for(var i=0; i<count; i++)
                yield return (i, (T)Convert.ChangeType(literals[i].GetValue(null), typeof(T)));
        }
    }
}