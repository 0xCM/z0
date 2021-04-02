//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static DataKind;
    using static CharKind;

    [System.Flags]
    public enum StringKind : ushort
    {
        None = 0,

        LlvmString = Char6 | String,

        AsciString = Char7 | String,

        Utf8String = Char8 | String,

        Utf16String = Char16 | String,
    }
}