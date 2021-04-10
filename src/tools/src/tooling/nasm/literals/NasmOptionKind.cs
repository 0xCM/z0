//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    public enum NasmOptionKind : byte
    {
        None = 0,

        [Format("{0}")]
        Input,

        [Format("-o {0}")]
        OutFile,

        [Format("-f {0}")]
        Format,

        [Format("-l {0}")]
        ListFile,
    }

    public enum NasmFlag : byte
    {
        None = 0,

        [Symbol("-g")]
        GenDebugInfo,
    }
}