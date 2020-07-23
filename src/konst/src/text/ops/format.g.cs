//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Formats a pattern using a parametric argument
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The pattern argument</param>
        /// <typeparam name="T">The argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(string pattern, T arg0)
            => string.Format(pattern, arg0);

        /// <summary>
        /// Formats a pattern using 2 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B>(string pattern, A arg0, B arg1)
            => string.Format(pattern, arg0, arg1);

        /// <summary>
        /// Formats a pattern using 3 parametric arguments
        /// </summary>
        /// <param name="pattern">The source pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        /// <typeparam name="A">The first argument type</typeparam>
        /// <typeparam name="B">The second argument type</typeparam>
        /// <typeparam name="C">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static string format<A,B,C>(string pattern, A arg0, B arg1, C arg2)
            => string.Format(pattern, arg0, arg1, arg2);

        /// <summary>
        /// Formats a <see cref='ITextual'/>
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>        
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct, ITextual
                => src.Format();

        /// <summary>
        /// Formats a <see cref='ITextual'/> sequence
        /// </summary>
        /// <param name="src">The source elements</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static string[] format<T>(params T[] src)
            where T : struct, ITextual
                => src.Select(x => x.Format());

        /// <summary>
        /// Formats each <see cref='ITextual'/> in the source
        /// </summary>
        /// <param name="items">The source stram</param>
        /// <typeparam name="F">The element type</typeparam>
        public static IEnumerable<string> format<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                
    }
}