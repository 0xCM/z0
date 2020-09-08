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
        public static string Format<T>(this SpanBlock8<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock16<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock32<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock64<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock128<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock256<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        /// <summary>
        /// Formats blocked content
        /// </summary>
        /// <param name="src">The source block sequence</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <param name="pad">The dell padding</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static string Format<T>(this SpanBlock512<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);
    }
}