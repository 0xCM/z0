//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".project")]
        Outcome Project(CmdArgs args)
        {
            var outcome = Outcome.Success;
            if(args.Length == 0)
            {
                Write(State.Project());
            }
            else
            {
                ProjectId id = arg(args,0).Value;
                var dir = ProjectHome(id);
                outcome = dir.Exists;
                if(outcome)
                {
                    State.Project(id);
                    Write(string.Format("{0} project selected", id));
                    var src = ProjectWs.SrcFiles(id);
                    Files(src);
                }
                else
                    outcome = (false, UndefinedProject.Format(id));
                return outcome;
            }
            return outcome;
        }
    }
}