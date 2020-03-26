//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Textual;

    public static class SpanFormatting
    {
        /// <summary>
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatAsVector<T>(this ReadOnlySpan<T> src, string sep = ",")
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
        public static string FormatAsVector<T>(this Span<T> src, string sep = ",")
            => src.ReadOnly().FormatAsVector(sep);        

        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this ReadOnlySpan<T> src)
        {
            var lines = text.build();
            for(var i=0; i<src.Length; i++)
                lines.AppendLine(src[i].ToString());
            return lines.ToString();
        }

        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this Span<T> src)
            => src.ReadOnly().FormatLines();

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
            var sb = text.build();
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

        [MethodImpl(Inline)]
        static bool IsRowHead(int index, int rowlen)
            => index == 0 || index % rowlen == 0; 

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
            var sb = text.factory.Builder();
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
    }
}