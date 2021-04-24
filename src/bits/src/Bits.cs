//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public partial class Bits
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitEditor<T> editor<T>(in T src)
            where T : unmanaged
                => new BitEditor<T>(src);
    }

}