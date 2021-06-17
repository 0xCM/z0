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

        [CmdOp("emit-api-classes")]
        public void EmitApiClasses(params object[] args)
            => Wf.ApiCatalogs().EmitApiClasses();

        [CmdOp("process-intel-sdm")]
        public void ProcessIntelSdm(params object[] args)
        {
            var processor = Wf.IntelSdmProcessor();
            processor.Run();

        }

        [CmdOp("emit-cli-metadata")]
        public Outcome EmitCliMetadata(params object[] args)
        {
            var pipe = Wf.CliPipe();
            pipe.EmitRowStats(Wf.ApiCatalog.Components, Db.IndexTable<CliRowStats>());
            pipe.EmitFieldDefs(Wf.ApiCatalog.Components, Db.IndexTable<FieldDefInfo>());
            pipe.EmitMethodDefs(Wf.ApiCatalog.Components, Db.IndexTable<MethodDefInfo>());
            return true;
        }

        [CmdOp("emit-cil-opcodes")]
        public Outcome EmitCilOpCodes(params object[] args)
        {
            var dst = Db.IndexTable<CilOpCode>();
            TableEmit(Cil.opcodes(), dst);
            return true;
        }

        [CmdOp("emit-sym-literals")]
        public Outcome EmitSymLiterals(params object[] args)
        {
            var service = Wf.Symbolism();
            var dst = Db.AppTablePath<SymLiteral>();
            service.EmitLiterals(dst);
            return true;
        }

        [CmdOp("update-tool-help")]
        public Outcome UpdateToolHelpIndex(params object[] args)
        {
            var catalog = ToolCatalog.create(Wf);
            var index = catalog.UpdateHelpIndex();
            core.iter(index, entry => Wf.Row(entry.HelpPath));
            return true;
        }

        [CmdOp("emit-intrinsics-catalog")]
        public Outcome EmitIntrinsicsCatalog(params object[] args)
        {
            Wf.IntrinsicsCatalog().Emit();
            return true;
        }

        [CmdOp("emit-respack")]
        public Outcome EmitResPack(params object[] args)
        {
            Wf.ResPackEmitter().Emit();
            return true;
        }

        [CmdOp("asm-gen-models")]
        public Outcome GenInstructionModels(params object[] args)
        {
            Wf.AsmModelGen().GenModelsInPlace();
            return true;
        }

        [CmdOp("asm-gen-models-preview")]
        public Outcome GenInstructionModelPreview(params object[] args)
        {
            Wf.AsmModelGen().GenModels(Db.AppLogDir() + FS.folder("asm.lang.g"));
            return true;
        }

        [CmdOp("capture-v2")]
        public Outcome CaptureV2(params object[] args)
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
        public Outcome CaptureV1(params object[] args)
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