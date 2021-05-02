//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using static Pow2x64;

    public enum NasmFileKind : ulong
    {
        None = 0,

        Asm = P2ᐞ08,

        Obj = P2ᐞ09,

        Bin = P2ᐞ10,

        Listing = P2ᐞ12,
    }
}