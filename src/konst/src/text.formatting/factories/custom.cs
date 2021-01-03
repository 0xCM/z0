//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Formatters
    {
        /// <summary>
        /// Formats anything via <see cref='object.ToString()'/>
        /// </summary>
        public readonly struct DefaultTextFormatter : ITextFormatter<DefaultTextFormatter,object>
        {
            public static DefaultTextFormatter Service => default;

            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? "<null>";
        }

        public static IFormatter custom(object src)
        {
            var attrib = src?.GetType()?.GetCustomAttribute<FormatterServiceAttribute>();
            if(attrib != null)
                return custom(attrib.Realization);
            else
                return DefaultTextFormatter.Service;
        }

        public static IFormatter custom(Type host)
        {
            try
            {
                return (IFormatter)Activator.CreateInstance(host);
            }
            catch(Exception)
            {
                return DefaultTextFormatter.Service;
            }
        }
    }
}