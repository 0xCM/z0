//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        Outcome RunAsmScript(string asmid, ScriptId script)
        {
            var result = Outcome.Success;
            var vars = WsVars.create();
            var path = AsmWs.Script(script);
            // if(!path.Exists)
            //     return (false, FS.missing(path));
            vars.SrcId = asmid;
            return Run(path, vars.ToCmdVars());
            // if(result.Fail)
            //     return result;

            // var flows = Tooling.flow(response);
            // var count = flows.Length;
            // for(var i=0; i<count; i++)
            // {
            //     ref readonly var f = ref skip(flows,i);
            //     Write(string.Format("{0}:{1} -> {2}", f.Kind, f.Source, f.Target));
            // }
        }

    }
}