//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static zfunc;

    public static class BitFields
    {
        [MethodImpl(Inline)]
        public static BitField<T> api<T>(in BitFieldSpec spec)
            where T : unmanaged
                => BitFields.create<T>(spec);

        [MethodImpl(Inline)]
        public static NumericBits<F,S,T> api<F,S,T>(in BitFieldSpec spec)
            where F : unmanaged, Enum
            where S : INumericBits<T>
            where T : unmanaged, IBitField
                => BitFields.create<F,S,T>(spec);

        /// <summary>
        /// Creates a stateful bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
        [MethodImpl(Inline)]
        public static BitField<T> create<T>(in BitFieldSpec spec)
            where T : unmanaged
                => new BitField<T>(spec);
                
        /// <summary>
        /// Creates a stateful bitfield api surface parametrized by an indexing enum
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="F">A indexing enumeration</typeparam>
        [MethodImpl(Inline)]
        public static NumericBits<F,S,T> create<F,S,T>(in BitFieldSpec spec)
            where F : unmanaged, Enum
            where S : INumericBits<T>
            where T : unmanaged
                => new NumericBits<F,S,T>(spec);

        /// <summary>
        /// Defines a bitfield predicated on an enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<E>()
            where E : unmanaged, Enum
                => GetSpec<E>();

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static FieldSegment segment(string name, byte index, byte startpos, byte endpos, byte width)
            => new FieldSegment(name,index, startpos, endpos, width);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static FieldSegment<T> segment<T>(string name, T index, T startpos, T endpos, T width)
            where T : unmanaged
                => new FieldSegment<T>(name, index, startpos, endpos, width);

        public static FieldSegment[] segments<E>(FieldIndexEntry<E>[] indices)
            where E : unmanaged, Enum
        {            
            var count = indices.Length;
            var segments = new FieldSegment[count];
            
            var start = byte.MinValue;
            for(var i=0; i<count; i++)
            {
                var entry = indices[i];
                var width = evalue<E,byte>(entry.FieldValue);
                var endpos = (byte)(start + width - 1);
                segments[i] = BitFields.segment(entry.FieldName, (byte)i, start, endpos, width);
                start = (byte)(endpos + 1);
            }
            return segments;
        }

        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify(params FieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline)]
        public static byte width(in BitFieldSpec spec)
        {
            var total = 0;
            for(byte i=0; i< spec.Segments.Length; i++)
                total += spec.Segment(i).Width;
            return (byte)total;            
        }
        

        [MethodImpl(Inline)]
        static BitFieldSpec CreateSpec<E>()
            where E : unmanaged, Enum
                => new BitFieldSpec(segments(FieldIndex.Entries<E>()));

        [MethodImpl(Inline)]
        static BitFieldSpec GetSpec<E>()
            where E : unmanaged, Enum
                => FieldSpecs.GetOrAdd(typeof(E), _ => CreateSpec<E>());

        static readonly ConcurrentDictionary<Type,BitFieldSpec> FieldSpecs
            = new ConcurrentDictionary<Type, BitFieldSpec>();        
    }
}