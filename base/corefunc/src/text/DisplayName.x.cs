//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.ComponentModel;

    using static zfunc;

    public static class DisplayNameX
    {
        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        public static string DisplayName(this MethodInfo src)
        {
            static string GenericMemberDisplayName(string memberName, IReadOnlyList<Type> args)
            {                
                var argFmt = args.Count != 0 ? args.Select(t => t.DisplayName()).Concat(", ") : string.Empty;            
                var typeName = memberName.Replace($"`{args.Count}", string.Empty);
                return typeName + (args.Count != 0 ? angled(argFmt) : string.Empty);
            }

            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if(attrib != null)
                return attrib.DisplayName;
            var slots = src.GenericParameters(false);
            return slots.Length == 0 ? src.Name : GenericMemberDisplayName(src.Name, slots);            
        }

        /// <summary>
        /// Constructs a display name for a generic method specialized for a specified type
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param> 
        [MethodImpl(Inline)]
        public static string DisplayName<T>(this MethodBase src)
            => src.DeclaringType.DisplayName() + "/" + src.Name + "<" + typeof(T).DisplayName() + ">";
                
        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static string FullDisplayName(this MethodInfo src)
            => $"{src.DeclaringType.DisplayName()}/{src.DisplayName()}";
    }

}