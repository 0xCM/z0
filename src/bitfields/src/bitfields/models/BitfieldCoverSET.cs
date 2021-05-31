//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = BitFields;

    /// <summary>
    /// Defines the (stateful) bitfield api surface parametrized by an indexing enum
    /// </summary>
    /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
    /// <typeparam name="E">A indexing enumeration</typeparam>
    public readonly ref struct BitfieldCover<S,E,T>
        where S : unmanaged
        where E : unmanaged
        where T : unmanaged
    {
        //readonly BitfieldSectionSpecs Spec;

        // readonly ReadOnlySpan<BitfieldSectionSpec> Segments;

        // [MethodImpl(Inline)]
        // public BitfieldCover(in BitfieldSectionSpecs spec, T state)
        // {
        //     Spec = spec;
        //     Segments = spec.Segments;
        // }

        // [MethodImpl(Inline)]
        // public ref readonly BitfieldSectionSpec Segment(E index)
        //     => ref skip(Segments, @as<E,uint>(index));

        // [MethodImpl(Inline)]
        // public T Read(in BitfieldSectionSpec part, in S src)
        //     => api.read<S,T>(part, src);

        // [MethodImpl(Inline)]
        // public T Read(E index, in S src)
        //     => api.read<S,T>(Segment(index), src);

        // [MethodImpl(Inline)]
        // public void Read(in S src, Span<T> dst)
        //     => api.store<S,T>(Spec, src, dst);

        // [MethodImpl(Inline)]
        // public T Read(in BitfieldSectionSpec segment, in S src, bool offset)
        //     => api.read<S,T>(segment, src, offset);

        // [MethodImpl(Inline)]
        // public T Read(E index, in S src, bool offset)
        //     => api.read<S,T>(Segment(index), src, offset);

        // [MethodImpl(Inline)]
        // public ref T Store(in BitfieldSectionSpec segment, in S src, ref T dst)
        // {
        //     api.store<S,T>(segment, src, ref dst);
        //     return ref dst;
        // }

        // [MethodImpl(Inline)]
        // public ref S Store(in BitfieldSectionSpec segment, in S src, ref S dst)
        // {
        //     api.store<S,T>(segment, src, ref dst);
        //     return ref dst;
        // }

        // [MethodImpl(Inline)]
        // public ref S Store(E index, in S src, ref S dst)
        // {
        //     api.store<S,T>(Segment(index), src, ref dst);
        //     return ref dst;
        // }

        // [MethodImpl(Inline)]
        // public ref T Store(E index, in S src, ref T dst)
        // {
        //     api.store<S,T>(Segment(index), src, ref dst);
        //     return ref dst;
        // }
    }
}