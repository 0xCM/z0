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
    /// Defines the (stateful) bitfield api surface
    /// </summary>
    /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
    public struct BitField<T>
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        public readonly BitFieldSpec Spec;

        T _State;

        [MethodImpl(Inline)]
        public BitField(in BitFieldSpec spec, T state)
        {
            Spec = spec;
            _State = state;
        }

        [MethodImpl(Inline)]
        public T State()
            => _State;

        [MethodImpl(Inline)]
        public BitField<T> State(in T src)
        {
            _State = src;
            return this;
        }

        [MethodImpl(Inline)]
        public T Extract(in BitFieldPart seg)
            => api.read(seg, _State);

        [MethodImpl(Inline)]
        public T Extract(byte index)
            => api.read(Segment(index), _State);

        [MethodImpl(Inline)]
        public BitField<T> Deposit(in BitFieldPart seg, in T src)
        {
            api.store<T>(seg, src, ref _State);
            return this;
        }

        [MethodImpl(Inline)]
        public BitField<T> Deposit(byte index, in T src)
        {
            api.store<T>(Segment(index), src, ref _State);
            return this;
        }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly BitFieldPart Segment(byte index)
            => ref skip(Spec.Segments, index);

        public T this[byte index]
        {
            [MethodImpl(Inline)]
            get => Extract(index);

            [MethodImpl(Inline)]
            set => Deposit(index, value);
        }

        public string Format()
            => api.format(this);
    }
}