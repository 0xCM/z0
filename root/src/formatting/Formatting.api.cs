//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static RootShare;

    public static class Formatting
    {             
        /// <summary>
        /// Formats any object, using a custom formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string format(object src)
            => src.GetFormatter().Format(src);

        /// <summary>
        /// Formats any object, using a custom configurable formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string format(object src, IFormatConfig config)
            => src.GetFormatter().Format(src,config);

        /// <summary>
        /// Formats any object, using a custom configurable formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string format<C>(object src, C config)
            where C : IFormatConfig
                => src.GetFormatter().Format(src,config);

        [MethodImpl(Inline)]
        static IFormatter CreateFormatter(Type realization)
        {
            try
            {
                return (IFormatter)Activator.CreateInstance(realization);
            }
            catch(Exception)
            {
                return default(DefaultFormatter);
            }

        }

        [MethodImpl(Inline)]
        static IFormatter GetFormatter(this object src)
        {
            var attrib = src?.GetType()?.GetCustomAttribute<FormatterAttribute>();
            if(attrib != null)
                return CreateFormatter(attrib.Realization);
            else
                return default(DefaultFormatter);
        }

        /// <summary>
        /// Reifies a formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultFormatter : IFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;
        }
    }
}