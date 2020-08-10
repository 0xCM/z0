//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Queries the source <see cref='Type'/> for the value of a name-identified literal <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="name">The field name</param>
        /// <param name="fallback">The value returned if the field doesn't exist</param>
        /// <typeparam name="T">The literal value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T LiteralFieldValue<T>(this Type src, string name, T fallback = default)
        {
            var field = src.DeclaredFields().Where(f => f.Name == name).FirstOrDefault();
            if(field != null)
                return (T)field.GetRawConstantValue();
            else
                return fallback;
        }
    }
}