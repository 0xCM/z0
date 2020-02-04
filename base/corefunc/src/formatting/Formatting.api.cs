//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

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
            => src.GetConfiguredFormatter().Format(src,config);

        /// <summary>
        /// Formats any object, using a custom formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            => src.GetFormatter().Format(src);

        /// <summary>
        /// Formats any object, using a custom configurable formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <param name="config">The format configuration</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(T src, IFormatConfig config)
            => src.GetConfiguredFormatter().Format(src, config);

        [MethodImpl(Inline)]
        static IFormatter CreateFormatter(Type realization)
            => Try(() => (IFormatter)Activator.CreateInstance(realization)).ValueOrDefault(default(DefaultFormatter));

        [MethodImpl(Inline)]
        static IConfiguredFormatter CreateConfigured(Type realization)
            => Try(() => (IConfiguredFormatter)Activator.CreateInstance(realization)).ValueOrDefault(default(DefaultConfiguredFormatter));

        [MethodImpl(Inline)]
        static IFormatter GetFormatter(this object src)
            => src == null 
             ? default(DefaultFormatter) 
             : src.GetType().CustomAttribute<FormatterAttribute>()
                            .TryMap(a => CreateFormatter(a.Realization))
                            .ValueOrDefault(default(DefaultFormatter));                          

        [MethodImpl(Inline)]
        static IConfiguredFormatter GetConfiguredFormatter(this object src)
            => src == null 
             ? default(DefaultConfiguredFormatter) 
             : src.GetType().CustomAttribute<FormatterAttribute>()
                            .TryMap(a => CreateConfigured(a.Realization))
                            .ValueOrDefault(default(DefaultConfiguredFormatter));                          

        /// <summary>
        /// Reifies a meaningless implementation of IFormatConfig
        /// </summary>
        readonly struct DefautFormatConfig : IFormatConfig {}

        /// <summary>
        /// Reifies a formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultFormatter : IFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Reifies a configurable formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultConfiguredFormatter : IConfiguredFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;

            [MethodImpl(Inline)]
            public string Format(object src, IFormatConfig config)
                => Format(src);
        }
    }
}