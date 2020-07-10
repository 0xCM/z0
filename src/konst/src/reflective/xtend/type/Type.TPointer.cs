//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// If the source type is a pointer, returns the type to which the pointer points; otherwise, returns the empty type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static Type TPointer(this Type src)
            => src.IsPointer ? src.GetElementType() : EmptyType;
    }
}