//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.ComponentModel;

    partial class XTend
    {
        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            if(src == null)
                sys.@throw(new ArgumentNullException(nameof(src)));

            if(Attribute.IsDefined(src, typeof(DisplayNameAttribute)))
                return src.GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            if(src.IsEnum)
                return src.Name + ':' + src.GetEnumUnderlyingType().DisplayName();

            if(src.IsPointer)
                return $"{src.GetElementType().DisplayName()}*";

            if(src.IsSystemDefined())
            {
                var kw = ApiIdentity.keyword(src);
                return string.IsNullOrWhiteSpace(kw) ? src.Name : kw;
            }

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
    }
}