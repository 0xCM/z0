//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules.DataKind;

    using W = DataWidth;

    partial struct Rules
    {
        [System.Flags]
        public enum CharKind : ushort
        {
            None = 0,

            Char6 = W.W6 | Char,

            Char7 = W.W7 | Char,

            Char8 = W.W8 | Char,

            Char16 = W.W16 | Char,
        }
    }
}