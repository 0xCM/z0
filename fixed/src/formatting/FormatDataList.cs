//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    using static Root;

    partial class FixedFormattables
    {
       /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatDataList<T>(this ReadOnlySpan<T> src, char sep = ',', int offset = 0, int pad = 0, bool bracketed = true)
        {
            if(src.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();
            
            for(var i = offset; i< src.Length; i++)
            {
                var item =$"{src[i]}";
                sb.Append(pad != 0 ? item.PadLeft(pad) : item);                
                if(i != src.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(AsciSym.Space);
                }
            }
            return bracketed ? $"[{sb.ToString()}]" : sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatDataList<T>(this Span<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            => src.ReadOnly().FormatDataList(delimiter, offset, pad, bracketed);

        /// <summary>
        /// Formats an array as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatDataList<T>(this T[] src, char delimiter = ',', int offset = 0)
            => src.ToSpan().FormatDataList(delimiter, offset);

        public static string FormatNumeric<T>(this T src, NumericKind kind)
            where T : unmanaged, IFixed
        {
            var dst = BitConvert.GetBytes(in src);
            switch(kind)
            {
                case NumericKind.I8:
                    return dst.As<sbyte>().FormatDataList();
                case NumericKind.U8:
                    return dst.As<byte>().FormatDataList();
                case NumericKind.I16:
                    return dst.As<short>().FormatDataList();
                case NumericKind.U16:
                    return dst.As<ushort>().FormatDataList();
                case NumericKind.I32:
                    return dst.As<int>().FormatDataList();
                case NumericKind.U32:
                    return dst.As<uint>().FormatDataList();
                case NumericKind.I64:
                    return dst.As<long>().FormatDataList();
                case NumericKind.U64:
                    return dst.As<ulong>().FormatDataList();
                case NumericKind.F32:
                    return dst.As<float>().FormatDataList();
                case NumericKind.F64:
                    return dst.As<double>().FormatDataList();
                default:
                    throw unsupported(kind);
            }
        }
             
    }
}