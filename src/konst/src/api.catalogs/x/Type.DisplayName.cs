//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.ComponentModel;

    partial class XApi
    {
        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static string DisplayName(this Type src, int recursion = 0)
        {
            if(recursion > 2)
                return $"Recursive fail for {src.Name}";
            try
            {
                if(src.IsGenericMethodParameter || src.IsGenericParameter || src.IsGenericTypeParameter)
                    return src.Name;

                if(src == null)
                    sys.@throw(new ArgumentNullException(nameof(src)));

                if(Attribute.IsDefined(src, typeof(DisplayNameAttribute)))
                    return src.GetCustomAttribute<DisplayNameAttribute>().DisplayName;

                if(src.IsEnum && src.IsConcrete())
                    return src.Name + ':' + src.GetEnumUnderlyingType().DisplayName(recursion + 1);

                if(src.IsPointer)
                    return $"{src.GetElementType().DisplayName(recursion + 1)}*";

                if(src.IsSystemDefined())
                {
                    var kw = ApiIdentify.keyword(src);
                    return string.IsNullOrWhiteSpace(kw) ? src.Name : kw;
                }

                if(src.IsGenericType && !src.IsRef())
                    return src.FormatGeneric();

                if(src.IsRef())
                    return src.GetElementType().DisplayName(recursion + 1);

                return src.Name;

            }
            catch(Exception)
            {
                return $"Error:{src}";
            }
        }

        [Op]
        static string FormatGeneric(this Type src)
        {
            var name = src.Name;
            var args = src.GetGenericArguments();
            if(args.Length != 0)
            {
                name = name.Replace($"`{args.Length}", string.Empty);
                name += "<";
                for(var i= 0; i<args.Length; i++)
                {
                    name += args[i].DisplayName();
                    if(i != args.Length - 1)
                        name += ",";
                }
                name += ">";
            }
            return name;
        }
    }
}