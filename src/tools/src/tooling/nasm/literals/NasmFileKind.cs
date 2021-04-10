//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using static Pow2x64;

    using K = ToolFileKind;

    public enum NasmFileKind : ulong
    {
        None = 0,

        Input = K.Input,

        Output = K.Output,

        Asm = P2ᐞ08,

        Obj = P2ᐞ09,

        Bin = P2ᐞ10,

        Listing = P2ᐞ12,
    }
}