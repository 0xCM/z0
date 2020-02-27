// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class SystemCollections
    {
        /// <summary>
        /// Concatenates two arrays
        /// </summary>
        public static T[] AppendTo<T>(this T[] head, T[] tail)
        {
            var dst = new T[head.Length + tail.Length];
            Buffer.BlockCopy(head, 0, dst, 0, head.Length);
            Buffer.BlockCopy(tail, 0, dst, head.Length, tail.Length);
            return dst;
        }

    }
}