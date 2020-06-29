//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;    

    public readonly struct BitFieldSegmentFormatter
    {
        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="V">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<V,T>(V value)
            where V : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = Enums.scalar<V,T>(value);
            var limit = gbits.effwidth(data);
            var config = BitFormatConfig.Limited(limit);
            var name = typeof(V).Name;
            var bits = formatter.Format(data,config);
            return text.concat(name, Chars.Colon, bits);
        }

        [MethodImpl(Inline)]
        public static IFormatter<IBitFieldSegment<T>> create<T>()
            where T : unmanaged 
                => default(SegmentFormatter<T>);

        [MethodImpl(Inline)]
        public static IFormatter<S> create<S,T>()
            where T : unmanaged
            where S : IBitFieldSegment<T>
                => default(SegmentFormatter<S,T>);

        [MethodImpl(Inline)]
        public static string entry<F>(F entry)
            where F : IBitFieldIndexEntry
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<S,T>(ReadOnlySpan<S> src)
            where T : unmanaged
            where S : IBitFieldSegment<T>
        {
            var sep =$"{Chars.Comma}{Chars.Space}";
            var segformat = create<T>();            
            var formatted = new StringBuilder();
            formatted.Append(Chars.LBracket);
            for(var i=0; i< src.Length; i++)
            {
                formatted.Append(segformat.Format(src[(byte)i]));
                if(i != src.Length - 1)
                    formatted.Append(sep);
            }

            formatted.Append(Chars.RBracket);            
            return formatted.ToString();
        }
    }

    readonly struct SegmentFormatter<T> : IFormatter<IBitFieldSegment<T>>
        where T : unmanaged
    {
        public string Format(IBitFieldSegment<T> src)
            => $"{src.Name}({src.Width}:{src.StartPos}..{src.EndPos})";
    }

    readonly struct SegmentFormatter<S,T> : IFormatter<S>
        where T : unmanaged
        where S : IBitFieldSegment<T>
    {
        public string Format(S src)
            => default(SegmentFormatter<T>).Format(src);
    }
}