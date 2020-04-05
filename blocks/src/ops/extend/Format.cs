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
        public static string Format<T>(this Block16<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        public static string Format<T>(this Block32<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        public static string Format<T>(this Block64<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        public static string Format<T>(this Block128<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true);

        public static string Format<T>(this Block256<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true); 

        public static string Format<T>(this Block512<T> src, char delimiter = Chars.Comma, int pad = 0)
            where T : unmanaged
                => src.Data.Format(delimiter, 0, pad, true); 

    }
}