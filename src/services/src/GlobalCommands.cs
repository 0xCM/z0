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

        Dictionary<string,MethodInfo> Methods;

        object[] DefaultParameters;

        public GlobalCommands()
        {
            Methods = GetType().PublicInstanceMethods().Tagged<CmdOpAttribute>().Select(x => (x.Name, x)).ToDictionary();
            DefaultParameters = core.array<object>();
            CommandLookup = new();
        }

        protected override void Initialized()
        {
            foreach(var (name,method) in Methods)
            {
                var cmd = method.Tag<CmdOpAttribute>().MapValueOrDefault(m => m.CommandName, method.Name);
                if(!CommandLookup.TryAdd(cmd,method))
                    Wf.Warn(string.Format("The operation {0}:{1} has a duplicate identifier", cmd, method.Name));
            }
        }

        public void UpdateToolHelpIndex()
        {
            var catalog = ToolCatalog.create(Wf);
            var index = catalog.UpdateHelpIndex();
            core.iter(index, entry => Wf.Row(entry.HelpPath));
        }

        [CmdOp("docsplit")]
        public Outcome SplitDocs(params object[] args)
        {
            Wf.DocSplitter().Run();
            return true;
        }

        [CmdOp("asm-gen-models")]
        public Outcome GenInstructionModels(params object[] args)
        {
            Wf.AsmCodeGenerator().GenerateModelsInPlace();
            return true;
        }

        [CmdOp("asm-gen-models-preview")]
        public Outcome GenInstructionModelPreview(params object[] args)
        {
            Wf.AsmCodeGenerator().GenerateModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
            return true;
        }

        [CmdOp("capture-xtract")]
        public Outcome RunExtractWorkflow(params object[] args)
        {
           var svc = Wf.ApiExtractWorkflow();
           svc.Run();
           return true;
        }

        [CmdOp("capture-process")]
        public Outcome RunMachine(params object[] args)
        {
            using var machine = MachineRunner.create(Wf);
            machine.Run(WorkflowOptions.@default());
            return true;
        }

        [CmdOp("capture")]
        public Outcome RunCapture(params object[] args)
        {
            var result = Capture.run();
            return true;
        }


        public Outcome Dispatch(string command, params object[] args)
        {
            try
            {
                if(CommandLookup.TryGetValue(command, out var method))
                {
                    return (Outcome)method.Invoke(this, args);
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