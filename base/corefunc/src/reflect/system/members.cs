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
    using static ReflectionFlags;

    public enum ParamDirection
    {
        Default,

        In = 1,

        Out = 2
    }

    partial class Reflections
    {        
        public static ParamDirection Direction(this ParameterInfo src)
            => src.IsIn ? ParamDirection.In : src.IsOut ? ParamDirection.Out : ParamDirection.Default;

        /// <summary>
        /// Gets the value of a specified field or property
        /// </summary>
        /// <param name="m">The field or property</param>
        /// <param name="o">The object on which the member is defined</param>
        [MethodImpl(Inline)]
        public static object MemberValue(this MemberInfo m, object o)
        {
            if (m is FieldInfo)
                return (m as FieldInfo).GetValue(o);
            else if (m is PropertyInfo)
                return (m as PropertyInfo).GetValue(o);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Gets the value of the identified member field or property
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="m">The member</param>
        /// <param name="o">The instance from which to access the member</param>
        [MethodImpl(Inline)]
        public static T MemberValue<T>(this MemberInfo m, object o)
            => (T)m.MemberValue(o);

        /// <summary>
        /// Determines whether an attribute is applied to a subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Attributed<T>(this MemberInfo m) 
            where T : Attribute
                => System.Attribute.IsDefined(m, typeof(T));

        /// <summary>
        /// Retrieves the value of an attached attribute paired with the subject
        /// </summary>
        /// <param name="m">The member to query</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static Pair<MemberInfo,A> Attribution<A>(this MemberInfo m)
            where A : Attribute
                => (m,(A)m.GetCustomAttribute(typeof(A)));

        /// <summary>
        /// Returns true if a parametrically-identified attribute is not applied to the subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Unattributed<T>(this MemberInfo m) 
            where T : Attribute
                => !m.Attributed<T>();

        /// <summary>
        /// Determines whether an attribute of specified type is attached to a member
        /// </summary>
        /// <param name="m">The member to test</param>
        /// <param name="t">The target attribute type</param>
        [MethodImpl(Inline)]
        public static bool Attributed(this MemberInfo m, Type t)
            => Attribute.IsDefined(m,t);

        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list describing the open parameters
        /// If a type is closed generic, returns a list describing the closed parameters
        /// </summary>
        /// <param name="src">The type from which to extract existing closed/open generic parameters</param>
        public static IReadOnlyList<Type> GetGenericSlots(this Type src)
            => (!src.IsGenericType && !src.IsGenericTypeDefinition) ? new Type[]{} 
               : src.IsConstructedGenericType 
               ? src.GenericTypeArguments 
               : src.GetGenericTypeDefinition().GetGenericArguments();    
                
        /// <summary>
        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, string name)
            where T : MemberInfo
                => src.Where(x => x.Name == name); 

        /// <summary>
        /// Selects the members with a name that exists within a supplied set
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, HashSet<string> names)
            where T : MemberInfo
                => src.Where(x => names.Contains(x.Name));

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameLike<T>(this IEnumerable<T> src, string search)
            where T : MemberInfo
            => src.Where(x => x.Name.Contains(search)); 

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameLike<T>(this IEnumerable<T> src, params string[] search)
            where T : MemberInfo
            => from m in src
                where search.Any(match => m.Name.Contains(match))
                select m;

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameStartingWith<T>(this IEnumerable<T> src, params string[] search)
            where T : MemberInfo
            => from m in src
                where search.Any(match => m.Name.StartsWith(match))
                select m;    
    }
}