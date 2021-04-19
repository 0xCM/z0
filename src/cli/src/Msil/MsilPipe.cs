//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    using static memory;

    public sealed class MsilPipe : WfService<MsilPipe>
    {
        const string CommentToken = "// ";

        const string CilCodeHeader = CommentToken + "Id:{0,-16} BaseAddress:{1,-16} Uri:{2}";

        const string CilSigHeader = CommentToken + "CliSig:[{0}] = [{1}]";

        const string CilEncodedHeader = CommentToken + "Encoded[{0}] = [{1}]";

        const string CilPageBreak = CommentToken + RP.PageBreak120;

        ILVisualizer IlViz;

        public MsilPipe()
        {
            IlViz = Cil.visualizer();
        }

        static bool parse(string src, out CilCapture dst)
        {
            var parts = @readonly(src.SplitClean(Chars.Pipe));
            var count = parts.Length;
            if(count != CilCapture.FieldCount)
            {
                dst = default;
                return false;
            }
            else
            {
                var i=0;
                DataParser.parse(skip(parts,i++), out dst.MemberId);
                DataParser.parse(skip(parts,i++), out dst.BaseAddress);
                DataParser.parse(skip(parts,i++), out dst.Uri);
                DataParser.parse(skip(parts,i++), out dst.CilCode);
                return true;
            }
        }

        public Index<CilCapture> LoadCapturedCil()
        {
            var flow = Wf.Running($"Loading cil data rows");
            var input = Db.CilDataPaths().View;
            var count = input.Length;
            var dst = RecordList.create<CilCapture>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                using var reader = path.Reader();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if(parse(line, out var row))
                    {
                        dst.Add(row);
                    }
                    else
                    {
                        Wf.Warn($"The content {line} could not be parsed");
                    }
                }
            }
            Wf.Ran(flow,$"Loaded {dst.Count} cil rows");
            return dst.Emit();
        }

        public void EmitMsil(Index<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Count;
            var builder = text.build();
            if(count != 0)
            {
                var flow = Wf.EmittingFile(dst);
                var view = src.View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var code = ref skip(view,i);
                    var member = code.Member;
                    var cil = member.Cil;
                    var sig = code.CliSig.Data;
                    var bytes = cil.Encoded;
                    writer.WriteLine(CilPageBreak);
                    writer.WriteLine(string.Format(CilCodeHeader, member.Token, member.BaseAddress, member.OpUri));
                    writer.WriteLine(string.Format(CilSigHeader, sig.Length, sig.Format()));
                    writer.WriteLine(string.Format(CilEncodedHeader, bytes.Length, bytes.Format()));
                    writer.WriteLine(CommentToken + member.Metadata.DisplaySig);
                    builder.Clear();
                    IlViz.DumpILBlock(bytes, bytes.Length, builder);
                    writer.WriteLine("{");
                    writer.Write(builder.ToString());
                    writer.WriteLine("}");
                    writer.WriteLine();
                }

                Wf.EmittedFile(flow, count);
            }
        }

        public void Render(OpMsil src, ITextBuffer dst)
        {
            var bytes = src.Encoded;
            var sig = src.Signature.Data;
            dst.AppendLine(CilPageBreak);
            dst.AppendLine(string.Format(CilCodeHeader, src.Id, src.BaseAddress, src.Uri));
            dst.AppendLine(string.Format(CilSigHeader, sig.Length, sig.Format()));
            dst.AppendLine(string.Format(CilEncodedHeader, bytes.Length, bytes.Format()));
            dst.AppendLine("{");
            IlViz.DumpILBlock(bytes, bytes.Length, dst.ToStringBuilder());
            dst.AppendLine("}");
            dst.AppendLine();
        }

        public void EmitMsilData(Index<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Count;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<MsilDataRow>(dst);
                var view = src.View;

                var formatter = Tables.formatter<MsilDataRow>(array<byte>(16,16,80,20));
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                for(var i=0u; i<count; i++)
                {
                    var row = new MsilDataRow();
                    fill(skip(view,i).Member, ref row);
                    writer.WriteLine(formatter.Format(row));
                }

                Wf.EmittedTable(flow, count);
            }
        }

        static ref MsilDataRow fill(in ApiMember src, ref MsilDataRow dst)
        {
            var cil = src.Cil;
            dst.BaseAddress = cil.BaseAddress;
            dst.MemberId = src.Token;
            dst.Uri = src.OpUri;
            dst.Encoded = cil.Encoded;
            return ref dst;
        }
    }
}