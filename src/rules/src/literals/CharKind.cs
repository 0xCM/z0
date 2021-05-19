//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static DataWidth;
    using static DataKind;

    [System.Flags]
    public enum CharKind : ushort
    {
        None = 0,

        Char6 = W6 | Char,

        Char7 = W7 | Char,

        Char8 = W8 | Char,

        Char16 = W16 | Char,
    }
}