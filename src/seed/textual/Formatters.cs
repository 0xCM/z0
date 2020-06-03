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
        [MethodImpl(Inline)]
        public static BitFormatter<T> bits<T>()
            where T : struct    
                => BitFormatter.create<T>();

        /// <summary>
        /// Creates a formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IFormatter<T> content<T>(FormatRender<T> render)
            => new Formatter<T>(render);        

        /// <summary>
        /// Creates a formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to format</typeparam>
        [MethodImpl(Inline)]
        public static IFormatter<C,T> content<C,T>(FormatRender<C,T> render)
            where C : struct
                => new Formatter<C,T>(render);

        /// <summary>
        /// Creates a title formatter from a rendering function render:T -> string
        /// </summary>
        /// <param name="render">A function that produces text from an element value</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ITitleFormatter<T> title<T>(TitleRender<T> render)
            => new TitleFormatter<T>(render);        

        /// <summary>
        /// Creates an entitled formatter that provides formatting, entitling and entitled formatting
        /// </summary>
        /// <param name="fContent">The content formatter to use</param>
        /// <param name="fTitle">The title formatter to use</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline)]
        public static IEntitled<T> entitled<T>(ITitleFormatter<T> fTitle, IFormatter<T> fContent)
            => new Entitled<T>(fTitle, fContent);

        /// <summary>
        /// Creates an entitled formatter that provides formatting, entitling and entitled formatting
        /// from a format/title render function pair
        /// </summary>
        /// <param name="renderF">The format render function</param>
        /// <param name="renderT">The title render function</param>
        /// <typeparam name="T">The type of element to render</typeparam>
        [MethodImpl(Inline)]
        public static IEntitled<T> entitled<T>(TitleRender<T> renderT, FormatRender<T> renderF)
            => new Entitled<T>(title(renderT), content(renderF));


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