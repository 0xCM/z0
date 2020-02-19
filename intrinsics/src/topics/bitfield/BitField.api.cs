//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public static class BitField
    {
        [MethodImpl(Inline)]
        public static BitFieldSegment segment(byte index, string name, byte startpos, byte endpos)
            => BitFieldSegment.Define(index, name, startpos,endpos);

        [MethodImpl(Inline)]
        public static BitFieldSegment segment<E>(E segid, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => BitFieldSegment.Define(evalue<E,byte>(segid), segid.ToString(), startpos, endpos);

        public static BitFieldSpec<E,T> specify<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var indices = Enums.indexed<E>();
            var segs = segments(indices);
            return new BitFieldSpec<E,T>(segs);
        }

        [MethodImpl(Inline)]
        public static BitFieldSpec<E,T> specify<E,T>(params BitFieldSegment[] segments)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var indices = Enums.indexed<E>();            
            return new BitFieldSpec<E,T>(segments);
        }

        [MethodImpl(Inline)]
        public static BitFieldReader<E,T> reader<E,T>(BitFieldSpec<E,T> spec)
            where E : unmanaged, Enum
            where T : unmanaged
                => new BitFieldReader<E,T>(spec);

        public static string format<E>(IBitFieldSpec<E> spec)
            where E : unmanaged, Enum
        {
            var formatted = text();
            for(var i=0; i< spec.FieldCount; i++)
            {
                var segment = spec[(byte)i];
                formatted.Append(segment.Format());
                if(i != spec.FieldCount - 1)
                {
                    formatted.Append(AsciSym.Comma);
                    formatted.Append(AsciSym.Space);
                }
            }
            return bracket(formatted.ToString());
        }

        public static string format<S>(S segment)
            where S : IBitFieldSegment
                => $"{segment.Name}({segment.Index}):{segment.StartPos}..{segment.EndPos}";

        static BitFieldSegment[] segments<E>(EnumIndexEntry<E>[] indices)
            where E : unmanaged, Enum
        {            
            var count = indices.Length;
            var segments = new BitFieldSegment[count];
            
            var start = byte.MinValue;
            for(var i=0; i<count; i++)
            {
                var entry = indices[i];
                var width = evalue<E,byte>(entry.Value);
                var endpos = (byte)(start + width - 1);
                segments[i] = BitField.segment((byte)i, entry.Name, start, endpos);
                start = (byte)(endpos + 1);
            }
            return segments;
        }
    }
}