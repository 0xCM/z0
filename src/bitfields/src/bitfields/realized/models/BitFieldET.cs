//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = BitFields;

    /// <summary>
    /// Defines a stateful numeric bitfield api surface parametrized by an indexing enum and numeric type
    /// </summary>
    /// <typeparam name="E">A indexing enumeration</typeparam>
    /// <typeparam name="T">The numeric type over which the bitfield is defined</typeparam>
    public ref struct Bitfield<E,T>
        where E : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        readonly BitfieldSegSpecs Spec;

        readonly ReadOnlySpan<BitfieldPart> Segments;

        T _State;

        [MethodImpl(Inline)]
        public Bitfield(in BitfieldSegSpecs spec, T state)
        {
            Spec = spec;
            Segments = spec.Segments;
            _State = state;
        }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly BitfieldPart Segment(E index)
            => ref skip(Segments, @as<E,byte>(index));

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the segment specification
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Extract(E index, in T src)
            => api.read(Segment(index), src);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Offset(E index, in T src)
            => api.offset(Segment(index), src);

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Deposit(E index, in T src, ref T dst)
        {
            api.store<T>(Segment(index), src, ref dst);
            return ref dst;
        }
    }
}