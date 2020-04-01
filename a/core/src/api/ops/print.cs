//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Seed;

    partial class Core
    {
       /// <summary>
        /// Writes a single messages to the terminal
        /// </summary>
        /// <param name="msg">The message to print</param>    
        public static void print(AppMsg msg)
            => term.print(msg);

        /// <summary>
        /// Writes a single line to the terminal
        /// </summary>
        /// <param name="content">The message to print</param>    
        public static void print(object content)
            => term.print(content);

        /// <summary>
        /// Writes formattables to the console in a contiguous block
        /// </summary>
        /// <param name="content">The content to print</param>    
        public static void print<F>(F src, AppMsgColor color)
            where F : ICustomFormattable
                => term.print(src,color);

        /// <summary>
        /// Writes formattables to the console in a contiguous block
        /// </summary>
        /// <param name="content">The content to print</param>    
        public static void print<F>(F src)
            where F : ICustomFormattable
                => term.print(src);

        /// <summary>
        /// Writes formattables to the console in a contiguous block
        /// </summary>
        /// <param name="content">The content to print</param>    
        public static void print<F>(params F[] src)
            where F : ICustomFormattable
                => term.print(src);

        /// <summary>
        /// Writes formattables to the console in a contiguous block using a specified foreground color
        /// </summary>
        /// <param name="color">The message foreground color</param>    
        /// <param name="content">The content to print</param>    
        public static void print<F>(AppMsgColor color, params F[] content)
            where F : ICustomFormattable
                => term.print(color,content);
    }
}