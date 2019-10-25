//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Text.RegularExpressions;
    using System.Text;

    using static zfunc;
    using static nfunc;

    partial class xfunc
    {
        /// <summary>
        /// Formats a readonly span of characters by forming the implied string
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Format(this ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Formats a span of characters by forming the implied string
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<char> src)
            => new string(src);

        /// <summary>
        /// Formats a stream as a delimited sequence with an optional custom value formatter
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <param name="formatter">An optional custom value formatter</formatter>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatSequence<T>(this IEnumerable<T> src, string sep = ", ",  Func<T,string> formatter = null)
            => string.Join(sep, src.Select(x => formatter?.Invoke(x) ?? x.ToString())).TrimEnd();

        /// <summary>
        /// Formats a stream as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatAsVector<T>(this IEnumerable<T> src, string sep = ", ")
            => AsciSym.Lt + string.Join(sep, src.Select(x => x.ToString())).TrimEnd() + AsciSym.Gt;

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this ReadOnlySpan128<T> src, char delimiter = ',', int offset = 0, int pad = 0)
            where T : unmanaged
                => src.Unblocked.FormatList(delimiter, offset, pad);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Span128<T> src, char delimiter = ',', int offset = 0, int pad = 0)
            where T : unmanaged
                => src.Unblocked.FormatList(delimiter, offset, pad);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this ReadOnlySpan256<T> src, char delimiter = ',', int offset = 0, int pad = 0)
            where T : unmanaged
            => src.Unblocked.FormatList(delimiter, offset, pad);

        /// <summary>
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<N,T>(this Span<N,T> src, char delimiter = ',', int offset = 0, int pad = 0)
            where N : ITypeNat, new()
            where T : unmanaged 
                => src.Unsize().FormatList(delimiter,offset,pad);

        /// <summary>
        /// Formats a span as a table
        /// </summary>
        /// <param name="src">The source data to be formatted</param>
        /// <param name="rowcount">The number of rows in the output table</param>
        /// <param name="colcount">The number of columns in the output table</param>
        /// <param name="cellsep">The character that intersperses the cells of each row</param>
        /// <param name="rowsep">The character that intersperses the rows </param>
        /// <param name="padlen">The optional padding for each cell; if less than zero the calls are left-padded; if greater than zero, the cells are right-padded</param>
        /// <param name="padchar">The optional pad character; if unspecified and padlen is specified it defaults to a space</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static string FormatTable<T>(this Span<T> src, int rowcount, int colcount, 
            int? padlen = null, char? padchar = null, char? rowsep = null, char? cellsep = null)
                where T : unmanaged
        {
            const char lf = '\n';

            const string crlf = "\r\n";

            const char pipe = '|';

            var rowlen = colcount;
            var cells = rowcount * colcount;            
            var sb = new StringBuilder(crlf);
            var lastIx = cells - 1;
            var nextrow = rowsep ?? lf;
            var nextcell = cellsep ?? pipe;
            for(var i=0; i< cells; i++)
            {
                var cell = src[i].ToString();
                if(i != 0)
                {
                    if(IsRowHead(i,rowlen))
                        sb.Append($"{nextrow}");
                    else
                        sb.Append($"{nextcell} ");
                }
                if(padlen == null)
                    sb.Append(cell);
                else
                {
                    var pad = Math.Abs(padlen.Value);
                    var fill = padchar ?? ' ';
                    if(padlen < 0)
                        sb.Append(cell.PadLeft(pad, fill));
                    else
                        sb.Append(cell.PadRight(pad, fill));
                }             
            }

            return sb.ToString();
        }

        static Func<string,int,string> GetPadFunc<T>(bool padright)
            => padright 
            ? new Func<string,int,string>((s,n) => s.PadRight(n)) 
            : new Func<string,int,string>((s,n) => s.PadLeft(n));

        /// <summary>
        /// Formats a span as [c0   c1 ...  cm]  where m = length - 1
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="cellpad">The width of a padded cell, if applicable</param>
        /// <param name="padchar">The character to use for cell padding, if applicable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatCellBlocks<T>(this ReadOnlySpan<T> src, int? cellpad = null, char? padchar = null, bool padright = true)
            where T : unmanaged
        {
            var padlen = cellpad ?? Unsafe.SizeOf<T>()*4;
            var filler = padchar ?? ' ';
            var pad = GetPadFunc<T>(padright);
            var sb = new StringBuilder();  
            sb.Append("[");
            for(var i = 0; i< src.Length; i++)
            {
                var fmt = $"{src[i]}";
                if(i != src.Length - 1)
                    sb.Append(pad(fmt,padlen));
                else
                    sb.Append(fmt);

            }
            sb.Append("]");
            return sb.ToString();
        }

        /// <summary>
        /// Formats a span as [c0   c1 ...  cm]  where m = length - 1
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="cellpad">The width of a padded cell, if applicable</param>
        /// <param name="padchar">The character to use for cell padding, if applicable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatCellBlocks<T>(this Span<T> src, int? cellpad = null, char? padchar = null, bool padright = true)        
            where T : unmanaged
                => src.ReadOnly().FormatCellBlocks(cellpad, padchar, padright);

        /// <summary>
        /// Formats a tabular span
        /// </summary>
        /// <param name="src">The source data to be formatted</param>
        /// <param name="cellsep">The character that intersperses the cells of each row</param>
        /// <param name="rowsep">The character that intersperses the rows </param>
        /// <param name="padlen">The optional padding for each cell; if less than zero the calls are left-padded; if greater than zero, the cells are right-padded</param>
        /// <param name="padchar">The optional pad character; if unspecified and padlen is specified it defaults to a space</param>
        /// <typeparam name="T">The span element type</typeparam>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The row count type</typeparam>
        public static string Format<M,N,T>(this Span<M,N,T> src, 
            int? padlen = null, char? padchar = null, char? rowsep = null, char? cellsep = null)
                where M : ITypeNat, new()
                where N : ITypeNat, new()
                where T : unmanaged
                    => src.Unsized.FormatTable(nati<M>(), nati<N>(),  padlen, padchar, rowsep, cellsep); 

        /// <summary>
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatVector<T>(this ReadOnlySpan<T> src, string sep = ",")
        {
            var components = src.Map(x => x.ToString());
            var body = components.Concat(sep);
            return AsciSym.Lt + body + AsciSym.Gt;
        }
            
        /// <summary>
        /// Formats a span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatVector<T>(this Span<T> src, string sep = ",")
            => src.ReadOnly().FormatVector(sep);

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this ReadOnlySpan<T> src, char sep = ',', int offset = 0, int pad = 0)
        {
            if(src.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append(AsciSym.LBracket);
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
            sb.Append(AsciSym.RBracket);
            return sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Span<T> src, char delimiter = ',', int offset = 0, int pad = 0)
            => src.ReadOnly().FormatList(delimiter, offset, pad);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Span256<T> src, char delimiter = ',', int offset = 0, int pad = 0)
            where T : unmanaged
                => src.Unblocked.FormatList(delimiter, offset, pad); 

        /// <summary>
        /// Formats a property declaration that specifies the span content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="name">The property name</param>
        /// <typeparam name="T">The serialization type</typeparam>
        public static string FormatProperty<T>(this ReadOnlySpan<T> src, string name)
            where T : unmanaged
        {
            var bytes = src.AsBytes();
            var decl = $"public static ReadOnlySpan<byte> {name}{bitsize<T>()}{suffix<T>()}";
            var data = embrace(bytes.FormatHex(sep: AsciSym.Comma, specifier:true));
            var rhs = $"new byte[{bytes.Length}]" + data;
            return $"{decl} => {rhs};";
        }

        /// <summary>
        /// Formats a property declaration that specifies the span content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="name">The property name</param>
        /// <typeparam name="T">The serialization type</typeparam>
        public static string FormatProperty<T>(this Span<T> src, string name)
            where T : unmanaged
                => src.ReadOnly().FormatProperty<T>(name);
        

        public static string Format<T>(this Vector128<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            switch(sfmt)
            {
                case SeqFmtKind.Vector:
                    return elements.FormatVector(sep.ToString());
                default:
                    return elements.FormatList(sep,0,pad);                    
            }
        }

        public static string FormatList<T>(this Vector128<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
                => src.Format(SeqFmtKind.List, sep, pad);

        public static string Format<T>(this Vec256<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            switch(sfmt)
            {
                case SeqFmtKind.Vector:
                    return elements.FormatVector(sep.ToString());
                default:
                    return elements.FormatList(sep,0,pad);
                    
            }
        }

        public static string Format<T>(this Vector256<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            switch(sfmt)
            {
                case SeqFmtKind.Vector:
                    return elements.FormatVector(sep.ToString());
                default:
                    return elements.FormatList(sep,0,pad);
                    
            }
        }

        public static string FormatList<T>(this Vector256<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
                => src.Format(SeqFmtKind.List,sep,pad);


    }

}