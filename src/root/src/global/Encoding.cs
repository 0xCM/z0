//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static TextEncodings;

    partial struct Root
    {
        public static AsciEncoding AsciEncoding => default;

        public static Utf8Encoding Utf8Encoding => default;

        public static Utf16Encoding Utf16Encoding => default;
    }
}