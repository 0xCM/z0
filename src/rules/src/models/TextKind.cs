//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using C = Rules.CharKind;
    using S = Rules.StringKind;

    partial struct Rules
    {
        [System.Flags]
        public enum TextKind : ushort
        {
            None = 0,

            Char6 = C.Char6,

            Char7 = C.Char7,

            Char8 = C.Char8,

            Char16 = C.Char16,

            LlvmString = S.LlvmString,

            AsciString = S.AsciString,

            Utf8String = S.Utf8String,

            Utf16String = S.Utf16String,
        }
    }
}