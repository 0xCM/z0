//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class ExtendedBlocks
    {
        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this Block128<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Data.FormatDataList(delimiter, offset, pad, bracketed);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this Block256<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Data.FormatDataList(delimiter, offset, pad,bracketed); 
    }
}