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

    using static Components;

    partial class Core
    {
        /// <summary>
        /// Writes exception content to the standard error stream
        /// </summary>
        /// <param name="e">The excecption to explain</param>
        public static void error(Exception e)
            => term.error(e);

        /// <summary>
        /// Writes content to the standard error stream
        /// </summary>
        /// <param name="src">The content to write</param>
        public static void error(object src)
            => term.error(src);
    }
}