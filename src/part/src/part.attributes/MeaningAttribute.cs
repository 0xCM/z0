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
    public class MeaningAttribute : Attribute
    {
        public object Content {get;}

        public object Target {get;}

        /// <summary>
        /// Returns the a target description, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static object ContentValue(MemberInfo src)
        {
             var a = src.GetCustomAttribute<MeaningAttribute>();
             object c = src.Name;
             if(a != null)
                c = a.Content;
                return c;
        }

        /// <summary>
        /// Returns the a target description, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [MethodImpl(Inline)]
        public static object ContentValue(ParameterInfo src)
        {
             var a = src.GetCustomAttribute<MeaningAttribute>();
             object c = src.Name;
             if(a != null)
                c = a.Content;
                return c;
        }

        [MethodImpl(Inline)]
        public static (object content, object target) ContentTarget(MemberInfo src)
        {
             var a = src.GetCustomAttribute<MeaningAttribute>();
             object c = src.Name;
             object t = src;
             if(a != null)
             {
                c = a.Content;
                t = a.Target;
             }
             return (c,t);
        }

        public MeaningAttribute(object content)
        {
            Content = content;
            Target = content;
        }

        public MeaningAttribute(object content, object target)
        {
            Content = content;
            Target = target;
        }
    }
}