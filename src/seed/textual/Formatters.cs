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

    using static Seed;

    [ApiHost]
    public partial class Formatters : IApiHost<Formatters>
    {
        /// <summary>
        /// Creates a formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to format</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IFormatter<T> create<T>(FormatRender<T> render)
            => new Formatter<T>(render);        

        /// <summary>
        /// Creates a formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to format</typeparam>
        [MethodImpl(Inline)]
        public static IFormatter<C,T> create<C,T>(FormatRender<C,T> render)
            where C : struct
                => new Formatter<C,T>(render);

        /// <summary>
        /// Formats any object, using a custom formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string format(object src)
            => GetFormatter(src).Format(src);

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
        static IFormatter GetFormatter(object src)
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