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

    partial class BitFields
    {        
        [MethodImpl(Inline)]
        public static string format<F>(F entry)
            where F : IBitFieldIndexEntry
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";        

        public static string Format<W>(BitFieldIndexEntry<W> src)
            where W : unmanaged, Enum
                => $"{src.FieldWidth.GetType().Name}[{src.FieldIndex}] = {src.FieldName}";
                
        [MethodImpl(Inline)]
        public static string format<T>(BitFieldSegment<T> src)
            where T : unmanaged
            => $"{src.Name}({src.Width}:{src.StartPos}..{src.EndPos})";
        
        public static string[] format(in BitFieldModel src)
            => BitFieldFormatters.Service.FormatLines(src);

        [MethodImpl(Inline)]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
            => format<BitFieldSegment,byte>(src);

        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
            where T : unmanaged
                => format<BitFieldSegment<T>,T>(src);

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
            var config = BitFormatter.limited(limit);
            var name = typeof(V).Name;
            var bits = formatter.Format(data,config);
            return text.concat(name, Chars.Colon, bits);
        }


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
            var formatted = new StringBuilder();
            formatted.Append(Chars.LBracket);
            for(var i=0; i< src.Length; i++)
            {
                formatted.Append(Format(src[(byte)i]));
                if(i != src.Length - 1)
                    formatted.Append(sep);
            }

            formatted.Append(Chars.RBracket);            
            return formatted.ToString();
        }

        static string Format<T>(IBitFieldSegment<T> src)
            where T : unmanaged
                => $"{src.Name}({src.Width}:{src.StartPos}..{src.EndPos})";

    }
}