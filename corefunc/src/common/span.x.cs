//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;
    using System.Text;

    using static zfunc;
    using static nfunc;

    partial class xfunc
    {
        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block64<byte> GetBytes(ulong src, in Block64<byte> dst)
        {         
            Bytes.read(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block32<byte> GetBytes(uint src, in Block32<byte> dst)
        {         
            Bytes.read(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block16<byte> GetBytes(ushort src, in Block16<byte> dst)
        {
            Bytes.read(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Renders a non-allocating mutable view over a source span segment that is presented as an individual target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T AsSingle<S,T>(this Span<S> src, int offset = 0, int? length = null)
            where S : unmanaged
            where T : unmanaged
                => ref MemoryMarshal.AsRef<T>(src.AsBytes(offset,length));

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
        public static string FormatTable<M,N,T>(this TableSpan<M,N,T> src, 
            int? padlen = null, char? padchar = null, char? rowsep = null, char? cellsep = null)
                where M : unmanaged, ITypeNat
                where N : unmanaged, ITypeNat
                where T : unmanaged
                    => src.Data.FormatTable(nati<M>(), nati<N>(),  padlen, padchar, rowsep, cellsep); 

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
            var lines = text.factory.Builder();
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
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        public static string FormatList<N,T>(this NatSpan<N,T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => src.Data.FormatList(delimiter,offset,pad,bracketed);
    }
}