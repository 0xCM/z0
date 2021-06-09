//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = AsciCode;

    [CodeProvider]
    public enum AsciWhitespaceCode : byte
    {
        Space = C.Space,

        NL = C.LF,

        CR = C.CR,

        FF = C.FF,

        Tab = C.Tab,

        VTab = C.VTab,
    }

    public readonly struct AsciWhitespaceCodes
    {
        public static ReadOnlySpan<AsciCode> Data
            => new AsciCode[6]{C.Space, C.LF, C.CR, C.FF, C.Tab, C.VTab};
    }
}