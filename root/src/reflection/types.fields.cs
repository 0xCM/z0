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
    using static RootShare;

    partial class RootReflections
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> Fields(this Type src)
            => src.GetFields(BF_All);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects the fields accessible via a type but which the type itself does nto declare
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> UndeclaredFields(this Type src)
            => src.Fields().Except(src.DeclaredFields());

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<FieldInfo> LiteralFields(this Type src)
            => src.DeclaredFields().Literal();

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
                return (T)f.GetValue(null);
            else
                return @default;
        }

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<(int index, T value)> LiteralValues<T>(this Type src, int? maxcount = null)  
            where T : unmanaged  
        {
            var literals = src.LiteralFields().ToArray();
            var count = Math.Min(maxcount ?? literals.Length, literals.Length);
            for(var i=0; i<count; i++)
                yield return (i, (T)Convert.ChangeType(literals[i].GetValue(null), typeof(T)));
        }

        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="src">The type to examine</param>
        public static IDictionary<FieldInfo, A> FieldAttributions<A>(this Type src) 
            where A : Attribute
        {
            var selection = from f in src.DeclaredFields()
                            where f.Attributed<A>()
                            let a = f.GetCustomAttribute<A>()
                            select (f,a);
            return selection.ToDictionary();
        }
    }
}