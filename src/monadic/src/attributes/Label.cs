//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Monadic;

    /// <summary>
    /// Labels anything since the system-defined DisplayNameAttribute has ridiculously stupid target restrictions
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class LabelAttribute : Attribute
    {

        /// <summary>
        /// Returns the a target label, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetLabel(MemberInfo src)
        {
             var attrib = src.GetCustomAttribute<LabelAttribute>();
             return attrib is null ? src.Name : attrib.Label;
        }    

        /// <summary>
        /// Returns the label of a parametric type, if attributed; otherwise, returns the type's name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static string TargetLabel<T>() 
            => TargetLabel(typeof(T));

        public LabelAttribute(string name)
        {
            Label = name;
        }

        public string Label {get;}
    }
}