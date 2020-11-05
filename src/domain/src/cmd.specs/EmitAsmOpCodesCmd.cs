//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitAsmOpCodesCmd : ICmdSpec<EmitAsmOpCodesCmd>
    {
        public FS.FilePath Target;
    }
}