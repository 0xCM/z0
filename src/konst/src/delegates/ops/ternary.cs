//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Delegates
    {
        /// <summary>
        /// Creates a ternary operator from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TernaryOp<T> ternary<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => from<TernaryOp<T>>(src, host);
    }
}