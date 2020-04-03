//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// A parametric type that, when closed, reifies a type width classification
    /// </summary>
    public readonly struct TypeWidth<T> : ITypeWidth<TypeWidth<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(TypeWidth<T> src)
            => Widths.measure<T>();

        public TypeWidth Class => Widths.measure<T>();

    }
}