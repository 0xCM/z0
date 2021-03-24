//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using C = AsciCharCode;

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
}