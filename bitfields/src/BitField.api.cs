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

    public static class BitField
    {
        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify(params FieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, the underlying numeric type of I, T, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="I">The indexing enum type</typeparam>
        /// <typeparam name="U">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => GetSpec<I,U,W>();

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, with an assumed underlying 
        /// numeric type of byte, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="I">The indexing enum type</typeparam>
        /// <typeparam name="U">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,W>()
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => specify<I,byte,W>();

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
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="I">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static NumericBits<I,T> numeric<I,T,W>()
            where I : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => new NumericBits<I,T>(specify<I,T,W>());

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="I">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static NumericBits<S,I,T> numeric<S,I,T,W>()
            where S : INumericBits<T>
            where I : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => new NumericBits<S,I,T>(specify<I,T,W>());


        /// <summary>
        /// Defines and creates a fixed-width bitfield
        /// </summary>
        /// <param name="bitcount">The total field bit-width</param>
        /// <typeparam name="I">A index-defining enumeration</typeparam>
        /// <typeparam name="U">The numeric type</typeparam>
        /// <typeparam name="W"></typeparam>
        /// <typeparam name="W">A width-defining enumeration</typeparam>
        [MethodImpl(Inline)]
        public static FixedBits<I,U,W> @fixed<I,U,W>(int bitcount)
            where I : unmanaged, Enum            
            where U : unmanaged
            where W : unmanaged, Enum
        {
            var data = fixedalloc<U>(bitcount);
            var spec = new BitFieldSpec<I,W>(specify<I,U,W>(), bitcount);
            return new FixedBits<I,U,W>(data, spec);                
        }

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

        static FixedData<T> fixedalloc<T>(int bitcount)
            where T : unmanaged
                => new FixedData<T>(DataBlocks.alloc<T>(n64, DataBlocks.blockcount<T>(bitcount)), bitcount);             

        /// <summary>
        /// Creates a stateful numeric bitfield api surface
        /// </summary>
        /// <param name="spec">The bitfield definition</param>
        /// <typeparam name="S">The type over which the bitfield is defined</typeparam>
        /// <typeparam name="I">A index-defining enumeration</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        static NumericBits<S,I,T> numeric<S,I,T>(in BitFieldSpec spec)
            where I : unmanaged, Enum
            where S : INumericBits<T>
            where T : unmanaged
                => new NumericBits<S,I,T>(spec);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        static FieldSegment<T> segment<T>(string name, T index, T startpos, T endpos, T width)
            where T : unmanaged
                => new FieldSegment<T>(name, index, startpos, endpos, width);

        static FieldSegment segment<I,W>(in FieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = evalue<I,byte>(entry.FieldIndex);
            var width = evalue<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = BitField.segment(entry.FieldName, i, start, end, width);
            start = (byte)(end + 1);
            return seg;
        }

        /// <summary>
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        static FieldSegment[] segments<I,W>(in FieldIndex<I,W> index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {            
            var count = index.Length;
            var start = z8;
            var segments = new FieldSegment[count];            
            for(var i=0; i<count; i++)
                segments[i] = segment(index[i], ref start);
            return segments;
        }
         
        [MethodImpl(Inline)]
        static BitFieldSpec CreateSpec<I,U,W>()        
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => new BitFieldSpec(segments(FieldIndex.Create<I,U,W>()));

        [MethodImpl(Inline)]
        static BitFieldSpec GetSpec<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => FieldSpecs.GetOrAdd(typeof(I), _ => CreateSpec<I,U,W>());

        static readonly ConcurrentDictionary<Type,BitFieldSpec> FieldSpecs
            = new ConcurrentDictionary<Type, BitFieldSpec>();        
    }
}