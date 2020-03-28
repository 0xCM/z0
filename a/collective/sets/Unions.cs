//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Core;

    partial class XTend
    {
        /// <summary>
        /// Adds all items from sets specified in a parameter array to a target set
        /// </summary>
        /// <param name="dst">The target set</param>
        /// <param name="src">The source sets</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> Unions<T>(this ISet<T> dst, params ISet<T>[] src)
        {
            Streams.iter(src, set => Streams.iter(set, item => dst.Add(item)));            
            return dst;
        }
    }
}