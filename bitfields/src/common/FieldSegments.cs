//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Core;    

    public static class FieldSegments
    {
        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<S,T>(ReadOnlySpan<S> src)
            where T : unmanaged
            where S : IFieldSegment<T>
        {
            var sep =$"{Chars.Comma}{Chars.Space}";
            var segformat = FieldSegments.formatter<T>();            
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

        public static string format(ReadOnlySpan<FieldSegment> src)
            => format<FieldSegment,byte>(src);

        public static string format<T>(ReadOnlySpan<FieldSegment<T>> src)
            where T : unmanaged
                => format<FieldSegment<T>,T>(src);

        readonly struct FieldSegmentFormatter<S,T> : IFormatter<S>
            where T : unmanaged
            where S : IFieldSegment<T>
        {
            public string Format(S src)
                => default(FieldSegmentFormatter<T>).Format(src);
        }

        readonly struct FieldSegmentFormatter<T> : IFormatter<IFieldSegment<T>>
            where T : unmanaged
        {
            public string Format(IFieldSegment<T> src)
                => $"{src.Name}({src.Index}, {src.Width}:{src.StartPos}..{src.EndPos})";
        }

        [MethodImpl(Inline)]
        public static IFormatter<S> formatter<S,T>()
            where T : unmanaged
            where S : IFieldSegment<T>
                => default(FieldSegmentFormatter<S,T>);

        [MethodImpl(Inline)]
        public static IFormatter<IFieldSegment<T>> formatter<T>()
            where T : unmanaged 
                => default(FieldSegmentFormatter<T>);

        internal static string FormatEntry<F>(this F entry)
            where F : IFieldIndexEntry
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";
    }
}