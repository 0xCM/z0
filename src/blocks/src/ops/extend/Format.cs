//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class XTend
    {
        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block8<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block16<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block32<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block64<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block128<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block256<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true); 

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this Block512<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true); 
    }
}