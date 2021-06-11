//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class GlobalCommands : WorkflowRunner<GlobalCommands>
    {
        Dictionary<string,MethodInfo> CommandLookup;

        object[] DefaultParameters;

        public GlobalCommands()
        {
            CommandLookup = GetType().PublicInstanceMethods().Tagged<CmdOpAttribute>().Select(x => (x.Name, x)).ToDictionary();
            DefaultParameters = core.array<object>();
        }

        [CmdOp]
        public Outcome GenInstructionModels()
        {
            Wf.AsmCodeGenerator().GenerateModelsInPlace();
            return true;
        }

        [CmdOp]
        public Outcome GenInstructionModelPreview()
        {
            Wf.AsmCodeGenerator().GenerateModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
            return true;
        }

        [CmdOp]
        public Outcome RunExtractWorkflow()
        {
           var svc = Wf.ApiExtractWorkflow();
           svc.Run();
           return true;
        }

        public Outcome Exec(string command)
        {
            try
            {
                if(CommandLookup.TryGetValue(command, out var method))
                {
                    return (Outcome)method.Invoke(this, DefaultParameters);
                }
                else
                {
                    return (false, string.Format("Command '{0}' unrecognized", command));
                }
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}