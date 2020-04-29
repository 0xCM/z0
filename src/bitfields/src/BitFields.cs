//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Seed;    
    using static Memories;

    [ApiHost("api")]
    public partial class BitFields : IApiHost<BitFields>
    {
        static FixedData<T> fixedalloc<T>(int bitcount)
            where T : unmanaged
                => new FixedData<T>(Blocks.alloc<T>(n64, Blocks.bitcover<T>(bitcount)), bitcount);             

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
            var i = Enums.numeric<I,byte>(entry.FieldIndex);
            var width = Enums.numeric<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = BitFields.segment(entry.FieldName, i, start, end, width);
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