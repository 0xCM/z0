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
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            if(src == null)
                throw new ArgumentNullException(nameof(src));
                
            if(Attribute.IsDefined(src, typeof(DisplayNameAttribute)))
                return src.GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            if(src.IsEnum)
                return src.Name + AsciSym.Colon + src.GetEnumUnderlyingType().DisplayName();

            if(src.IsPointer)
                return $"{src.GetElementType().DisplayName()}*";
            
            if(src.IsPrimal())
                return src.PrimitiveKeyword().IfBlank(src.Name);

            if(src.IsGenericType && !src.IsRef())
                return src.FormatGeneric();

            if(src.IsRef())
                return src.GetElementType().DisplayName();

            return src.Name;
        }

        static string FormatGeneric(this Type src)
        {
            var name = src.Name;                
            var args = src.GetGenericArguments();
            if(args.Length != 0)
            {
                name = name.Replace($"`{args.Length}", string.Empty);
                name += "<";
                for(var i= 0; i< args.Length; i++)
                {
                    name += args[i].DisplayName();
                    if(i != args.Length - 1)
                        name += ",";
                }                                
                name += ">";
            }
            return name;
        } 

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

        /// <summary>
        /// Gets the display name specified by the eponymous attribute, if attributed; otherwise, returns the reflected property name
        /// </summary>
        /// <param name="src">The source property</param>
        public static string DisplayName(this PropertyInfo src)
            => (from a in src.CustomAttribute<DisplayNameAttribute>() 
                 select a.DisplayName).ValueOrElse(() => src.Name);

    }

}