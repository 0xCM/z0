//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Encloses text between less than and greater than characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        static string angled(string content)
            => String.IsNullOrWhiteSpace(content) ? string.Empty : $"<{content}>";

        static string GenericMethodDisplayName(this MethodInfo src, IReadOnlyList<Type> args)
        {
            var argFmt = args.Count != 0 ?  string.Join(", ", args.Select(t => t.DisplayName()).ToArray()) : string.Empty;
            var typeName = src.Name.Replace($"`{args.Count}", string.Empty);
            return typeName + (args.Count != 0 ? angled(argFmt) : string.Empty);
        }

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        public static string DisplayName(this MethodInfo src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if(attrib != null)
                return attrib.DisplayName;
            var slots = src.GenericParameters(false);
            return slots.Length == 0 ? src.Name : src.GenericMethodDisplayName(slots);
        }

        /// <summary>
        /// Constructs a display name for a generic method specialized for a specified type
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param>
        public static string DisplayName<T>(this MethodBase src)
            => src.DeclaringType.DisplayName() + "/" + src.Name + "<" + typeof(T).DisplayName() + ">";
    }
}