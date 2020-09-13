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
        /// Creates a binary operator from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="host">The host instance if not static</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp<T> binary<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => from<BinaryOp<T>>(src, host);
    }
}