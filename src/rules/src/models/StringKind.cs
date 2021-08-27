//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules.DataKind;
    using static Rules.CharKind;

    partial struct Rules
    {
        [System.Flags]
        public enum StringKind : ushort
        {
            None = 0,

            Char6String = Char6 | String,

            AsciString = Char7 | String,

            Utf8String = Char8 | String,

            UnicodeString = Char16 | String,

            Utf32String = Char32 | String
        }
    }
}