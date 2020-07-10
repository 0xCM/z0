//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes anything, or at least something
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class NameAttribute : Attribute
    {
        /// <summary>
        /// Returns the a target description, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetName(MemberInfo src)
        {
             var attrib = src.GetCustomAttribute<NameAttribute>();
             return attrib is null ? src.Name : attrib.Name;
        }    

        /// <summary>
        /// Returns the description of a parametric type, if attributed; otherwise, returns the type's name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetName<T>() 
            => TargetName(typeof(T));

        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name {get;}
    }
}