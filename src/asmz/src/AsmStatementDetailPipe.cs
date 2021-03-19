//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public class AsmStatementDetailPipe : WfService<AsmStatementDetailPipe>
    {
        public void Process()
        {
            var table = SymbolStores.table<AsmMnemonicCode>();
            var counter = 0u;
            var mnemonics = root.hashset<AsmMnemonicCode>();
            var failures = root.hashset<string>();
            var opcodes = root.hashset<AsmOpCodeExpr>();
            var ocpath = Db.AppDataFile(FS.file("statement-opcodes", FS.Extensions.Csv));
            using var ocwriter = ocpath.Writer();


            void CountStatements(AsmStatementDetail src)
            {
                counter++;
            }

            void CollectOpCodes(AsmStatementDetail src)
            {
                var encoded = src.Encoded;
                var opcode = src.OpCode;
                if(!opcodes.Contains(opcode))
                {
                    opcodes.Add(opcode);
                    ocwriter.WriteLine(string.Format("{0,-24} | {1, -24} | {2,-16} | {3}", src.Expression, src.Sig, src.OpCode, src.Encoded));
                }
            }

            void CollectMnemonics(AsmStatementDetail src)
            {
                var symbol = src.Mnemonic.Name.ToLower();
                if(table.TokenFromSymbol(symbol, out var t))
                    mnemonics.Add(t.Kind);
                else
                    failures.Add(symbol);
            }

            Run(CountStatements, CollectMnemonics, CollectOpCodes);
            Wf.Status($"{counter} statements were processed)");
            Wf.Status($"{mnemonics.Count} known mnemonics were encountered along with {failures.Count} unknown mnemonics: {failures.FormatList()}");
            Wf.Status($"{opcodes.Count} distinct opcodes were collected");
        }

        public void Run(params Action<AsmStatementDetail>[] processors)
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

        void Process(ReadOnlySpan<AsmStatementDetail> src, Action<AsmStatementDetail> receiver)
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
        public static AsmStatementDetailPipe AsmStatementDetailPipe(this IWfShell wf)
            => Asm.AsmStatementDetailPipe.create(wf);
    }
}