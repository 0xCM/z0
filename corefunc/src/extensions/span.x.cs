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


        [MethodImpl(Inline)]
        public static IByteReader ByteReader(this IContext context)
            => Z0.ByteReader.Create(context);        


    }
}