//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;

    [ApiHost("specs")]
    public partial class BitFieldSpecs : IApiHost<BitFieldSpecs>
    {
        public static string[] format(in BitFieldModel src)
            => BitFieldModelFormatter.Service.FormatLines(src);

        [MethodImpl(Inline)]
        public static BitFieldSpec256<F> specify<F>(W256 w)
            where F : unmanaged, Enum
        {
            Span<F> values = Enums.valarray<F>();
            var widths = values.AsBytes();
            var count = math.min(widths.Length, 32);
            var data = default(Vector256<byte>);
            for(var i=0; i<count; i++)
                data = data.WithElement(i,skip(widths,i));  
            return new BitFieldSpec256<F>(data);              
        }

        internal static FieldSegment segment<I,W>(in FieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = Enums.scalar<I,byte>(entry.FieldIndex);
            var width = Enums.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = BitFieldSpecs.segment(entry.FieldName, start, end, width);
            start = (byte)(end + 1);
            return seg;
        }

        /// <summary>
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        internal static FieldSegment[] segments<I,W>(in FieldIndex<I,W> index)
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

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline), Op]
        public static FieldSegment segment(string name, byte startpos, byte endpos, byte width)
            => new FieldSegment(name,startpos, endpos, width);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="i0">The position of the first bit in the segment</param>
        /// <param name="i1">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static FieldSegment<T> segment<T>(string name, T i0, T i1, T width)
            where T : unmanaged
                => new FieldSegment<T>(name, i0, i1, width);

        /// <summary>
        /// Describes an index-identifed model segment
        /// </summary>
        /// <param name="src">The source model</param>
        /// <param name="index">The field index</param>
        [MethodImpl(Inline), Op]
        public static FieldSegment segment(in BitFieldModel src, byte index)
        {
            var width = src.Width(index);
            var i0 = src.Position(index);
            var i1 = (byte)(i0 + width);
            return segment(src.Name(index), i0, i1, width);
        }

        [MethodImpl(Inline)]
        public static FieldSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => segment(id.ToString(), startpos, endpos, (byte)(endpos - startpos + 1));

        [Op]
        public static BitFieldModel model(string name, string[] names, byte[] widths)
        {            
            insist(names.Length, widths.Length);
            var fieldCount = (byte)names.Length;
            var fieldWidths = widths;
            var fieldNames = AsciCodes.alloc(n16,fieldCount);            

            ArraySpan<byte> fieldPositions = new byte[fieldCount];

            byte width = 0;            
            for(var i=0; i< fieldCount; i++)
            {
                AsciCodes.encode(names[i], out fieldNames[i]);
                fieldPositions[i] = width;
                width += fieldWidths[i];                
            }
            return new BitFieldModel(AsciCodes.encode(n16,name), fieldCount, width, fieldNames, fieldWidths, fieldPositions);
        }

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            for(byte i=0; i< spec.Segments.Length; i++)
                total += spec.Segment(i).Width;
            return total;            
        }

        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSpec specify(params FieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, the underlying numeric type of I, T, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="E">The indexing enum type</typeparam>
        /// <typeparam name="T">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<E,T,W>()
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
                => GetSpec<E,T,W>();

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


        [MethodImpl(Inline)]
        internal static BitFieldSpec CreateSpec<I,U,W>()        
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => new BitFieldSpec(segments(FieldIndex.Create<I,U,W>()));

        [MethodImpl(Inline)]
        internal static BitFieldSpec GetSpec<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => FieldSpecs.GetOrAdd(typeof(I), _ => CreateSpec<I,U,W>());

        static readonly ConcurrentDictionary<Type,BitFieldSpec> FieldSpecs
            = new ConcurrentDictionary<Type, BitFieldSpec>();        
    }
}