//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public class AsmStatementProcessor : WfService<AsmStatementProcessor>
    {
        public void Run(params Action<AsmStatementInfo>[] processors)
        {
            var distiller = Wf.AsmDistiller();
            var paths = distiller.Distillations();
            var flow = Wf.Running("Processing statement set");
            foreach(var path in paths)
            {
                var loading = Wf.Running(Msg.LoadingStatements.Format(path));
                var data = distiller.LoadDistillation(path).View;
                var count = data.Length;
                Wf.Ran(loading, Msg.LoadedStatments.Format(count,path));
                var processing = Wf.Running(Msg.ProcessingStatments.Format(count,path));
                foreach(var receiver in processors)
                    Process(data, receiver);
                Wf.Ran(processing, Msg.ProcessedStatements.Format(count,path));
            }

            Wf.Ran(flow);
        }

        void Process(ReadOnlySpan<AsmStatementInfo> src, Action<AsmStatementInfo> receiver)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(statement.OpCode.IsEmpty || statement.Sig.IsEmpty)
                    continue;
                else
                {
                    var opcode = statement.OpCode;
                    if(opcode.IsValid)
                        receiver(statement);
                }
            }
        }
    }

    partial struct Msg
    {
        public static MsgPattern<FS.FileUri> LoadingStatements
            => "Loading statements from {0}";

        public static MsgPattern<Count,FS.FileUri> LoadedStatments
            => "Loading {0} statements from {1}";

        public static MsgPattern<Count,FS.FileUri> ProcessingStatments
            => "Processing {0} statements from {1}";

        public static MsgPattern<Count,FS.FileUri> ProcessedStatements
            => "Processed {0} statements from {1}";
    }

    public static partial class XTend
    {
        public static AsmStatementProcessor AsmStatementProcessor(this IWfShell wf)
            => Asm.AsmStatementProcessor.create(wf);
    }
}