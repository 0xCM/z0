//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

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

        public void EmitBitstrings()
        {
            const string RenderPattern = "{0,-16} | {1,-10} | {2,-4} | {3,-42} | {4,-32} | {5,-32} | {6,-32} | {7}";

            var flow = Wf.Running();
            var counter = 0u;
            var allocated = 0u;
            var writers = root.dict<ApiHostUri,StreamWriter>();
            var @base = new MemoryAddress();
            var opcodes = root.hashset<AsmOpCodeExpr>();

            var dir = Db.TableDir("asm.bitstrings");
            dir.Delete();
            Wf.Babble($"Obliterated <{dir}>");

            using var all = (dir + FS.file("asm.bitstrings", FS.Csv)).Writer();
            all.WriteLine(header());

            static string header()
                => string.Format(RenderPattern, "Address", "Offset", "Size", "Statement", "Sig", "OpCode", "Hex", "Bits");

            StreamWriter factory(FS.FilePath dst)
            {
                var writer = dst.Writer();
                writer.WriteLine(header());
                return writer;
            }

            FS.FilePath path(ApiHostUri host)
                => dir + ApiFiles.folder(host.Part) + ApiFiles.filename(host, FS.Csv);

            StreamWriter writer(ApiHostUri host)
            {
                var writer = default(StreamWriter);
                if(!writers.TryGetValue(host, out writer))
                {
                    writer = factory(path(host));
                    writers.Add(host, writer);
                    allocated++;
                    Wf.Babble($"Allocated <{host}> writer");
                }

                return writer;
            }

            void receive(AsmApiStatement src)
            {
                if(@base == 0)
                    @base = src.IP;

                var opcode = src.OpCode;
                opcodes.Add(opcode);

                var host = src.OpUri.Host;
                var asmcode = src.Expression;
                var hexcode = src.Encoded;
                var sig = src.Sig;
                var bitcode = asm.bitstring(hexcode);
                var offset = Addresses.address((uint)(src.IP - @base));
                var target = writer(src.OpUri.Host);
                var row = string.Format(RenderPattern, src.IP, offset, hexcode.Size, asmcode, sig, opcode, hexcode, bitcode);
                target.WriteLine(row);
                all.WriteLine(row);
                counter++;
            }

            Wf.AsmStatements().Traverse(receive);

            Wf.Babble($"Disposing <{writers.Values.Count}> out of <{allocated}> allocations");
            root.iter(writers.Values, w => w.Dispose());

            var ocpath = dir + FS.file("opcodes", FS.Csv);
            var eoc = Wf.EmittingFile(ocpath);
            using var ocwriter = ocpath.Writer();
            ocwriter.WriteLine("OpCode");
            var ocsorted = opcodes.Array().OrderBy(x => x.Content).Array();
            root.iter(ocsorted, oc => ocwriter.WriteLine(oc));
            Wf.EmittedFile(eoc, ocsorted.Length);
            Wf.Ran(flow, counter);
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