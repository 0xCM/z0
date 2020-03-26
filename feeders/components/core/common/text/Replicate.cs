//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    using static Components;

    partial class ComponentOps
    {
        /// <summary>
        /// Creates a stream of replicated strings
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static IEnumerable<string> Replicate(this string src, int count)
            => replicate(src,count);

        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static IEnumerable<char> Replicate(this char src, int count)
            => replicate(src,count);
    }
}