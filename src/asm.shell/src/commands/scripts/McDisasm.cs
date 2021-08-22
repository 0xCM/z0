//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        Outcome McDisasm(FS.FilePath src, FS.FolderPath dst)
        {
            var script = LlvmMcScripts.mcdisasm(src.FolderPath, src.FileName, dst);
            var result = Run(script, out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }



    }
}