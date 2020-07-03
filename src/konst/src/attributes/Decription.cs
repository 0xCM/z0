//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes anything, or at least something
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {
        /// <summary>
        /// Returns the a target description, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetDescription(MemberInfo src)
        {
             var attrib = src.GetCustomAttribute<DescriptionAttribute>();
             return attrib is null ? src.Name : attrib.Description;
        }    

        /// <summary>
        /// Returns the description of a parametric type, if attributed; otherwise, returns the type's name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetDescription<T>() 
            => TargetDescription(typeof(T));

        public DescriptionAttribute(string name)
        {
            Description = name;
        }

        public string Description {get;}
    }
}