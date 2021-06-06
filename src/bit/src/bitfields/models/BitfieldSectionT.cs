//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = BitfieldSpecs;

    /// <summary>
    /// Defines a section within a bitfield that comprises one or more segments
    /// </summary>
    public readonly struct BitfieldSection<T> : IBitfieldSection<T>
        where T : unmanaged
    {
        /// <summary>
        /// The section name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The index, relative to the containing bitfield, of the first bit in the section
        /// </summary>
        public T FirstIndex {get;}

        /// <summary>
        /// The index, relative to the containing bitfield, of the last bit in the section
        /// </summary>
        public T LastIndex {get;}

        /// <summary>
        /// The segments within the section
        /// </summary>
        public BitfieldSegs Segments {get;}

        [MethodImpl(Inline)]
        public BitfieldSection(StringAddress name, T min, T max, BitfieldSegs segments)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
            Segments = segments;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        public BitfieldSection Untyped
        {
            [MethodImpl(Inline)]
            get => api.untyped(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSection(BitfieldSection<T> src)
            => src.Untyped;
    }
}