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

    using static zfunc;

    public static partial class Reflections
    {
        /// <summary>
        /// Convenience accessor for the assembly's version
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Version AssemblyVersion(this Assembly a)
            => a.GetName().Version;

        /// <summary>
        /// Determines whether an assembly has an attribute of a given type
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="T">The attribute type</typeparam>
        public static bool HasAttribute<T>(this Assembly a) 
            where T : Attribute
                => System.Attribute.IsDefined(a, typeof(T));

        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise NULL
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        public static A GetAttribute<A>(this Assembly a) where A : Attribute
            => (A)System.Attribute.GetCustomAttribute(a, typeof(A));

        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise None
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        public static Option<A> TryGetAttribute<A>(this Assembly a) 
            where A : Attribute
                =>  a.GetAttribute<A>();

        /// <summary>
        /// Gets the value of <see cref="AssemblyProductAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Product(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyProductAttribute>() select x.Product;

        /// <summary>
        /// Gets the value of <see cref="AssemblyTitleAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Title(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyTitleAttribute>() select x.Title;

        /// <summary>
        /// Gets the value of <see cref="AssemblyCompanyAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Company(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyCompanyAttribute>() select x.Company;

        /// <summary>
        /// Gets the value of <see cref="AssemblyDefaultAliasAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> DefaultAlias(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyDefaultAliasAttribute>() select x.DefaultAlias;

        /// <summary>
        /// Gets the simple name of an assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string GetSimpleName(this Assembly a)
            => a?.GetName()?.Name ?? string.Empty;
 
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