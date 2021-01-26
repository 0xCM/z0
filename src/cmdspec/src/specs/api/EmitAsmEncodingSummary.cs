//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitAsmEncodingCmd : ICmd<EmitAsmEncodingCmd>
    {
        public const string CmdName = "emit-asm-encodings";
    }
}