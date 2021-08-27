//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static WsAtoms;

    partial class EtlWorkflow
    {
        public Outcome GenLists()
        {
            var result = Outcome.Success;
            var path = Ws.Tools().Script(Toolspace.llvm_tblgen, ToolScriptId.emit_llvm_lists);
            result = Wf.OmniScript().RunToolScript(path, CmdVars.Empty, false, out var flow);
            ImportLists(LlvmDatasetNames.TblgenLists, llvm);
            return result;
        }
    }
}