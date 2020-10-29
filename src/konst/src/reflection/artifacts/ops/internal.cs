//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Buffers;
    using System.Reflection;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    partial struct ClrArtifacts
    {
        [MethodImpl(Inline)]
        static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => CreateReadOnlySpan(ref @as<S,T>(first(src)), (int)((src.Length * size<S>())/size<T>()));

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<V> View<S,V>(S[] src, V v = default)
            => @recover<S,V>(@readonly(src));
    }
}