//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitApiIndex : CmdReactor<EmitHexIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitHexIndexCmd cmd)
            => ApiCode.EmitHexIndex(Wf);
    }
}