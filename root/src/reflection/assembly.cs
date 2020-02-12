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
    using System.Runtime.Intrinsics;
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static RootShare;
    
    partial class RootReflections
    {        
        /// <summary>
        /// Gets the simple name of an assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string GetSimpleName(this Assembly a)
            => a?.GetName()?.Name ?? string.Empty;

        /// <summary>
        /// Gets the type attributions for the specified assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IDictionary<Type, A> TypeAttributions<A>(this Assembly a, Func<Type,bool> pred = null)
            where A : Attribute
        {
            var f = pred ?? (t => true);
            var q = from t in a.GetTypes()
                    where Attribute.IsDefined(t, typeof(A)) && f(t)
                    let attrib = t.GetCustomAttribute<A>()
                    select new
                    {
                        Type = t,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Type, x => x.Attribute);
        }

        public static IEnumerable<Type> Types(this Assembly a)
            => a.GetTypes();

        public static IEnumerable<Type> Interfaces(this Assembly a)
            => a.GetTypes().Interfaces();

        public static IEnumerable<Type> Classes(this Assembly a)
            => a.GetTypes().Classes();

        public static IEnumerable<Type> Classes(this Assembly a, string name)
            => a.Classes().Where(c => c.Name == name);

        public static IEnumerable<Type> Enums(this Assembly a)
            => a.GetTypes().Enums();

        public static IEnumerable<Type> Structs(this Assembly a)
            => a.GetTypes().Structs();

        public static IEnumerable<Type> Delegates(this Assembly a)
            => a.GetTypes().Delegates(); 

        public static IEnumerable<Type> NestedTypes(this Assembly a)
            => a.GetTypes().Nested();

        public static IEnumerable<Type> StaticTypes(this Assembly a)
            => a.GetTypes().Static();

        public static IEnumerable<Type> PublicTypes(this Assembly a)
            => a.GetTypes().Public();

        public static IEnumerable<Type> NonPublicTypes(this Assembly a)
            => a.GetTypes().NonPublic();
    }
}