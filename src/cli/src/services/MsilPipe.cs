//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Reflection.Metadata;

    using static memory;

    public sealed class MsilPipe : WfService<MsilPipe, MsilPipe>
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

        public void EmitCilCode(Index<ApiMemberCode> src, FS.FilePath dst)
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

        public void Render(CilMethod src, ITextBuffer dst)
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

        static ref MsilDataRow fill(in ApiMember src, ref MsilDataRow dst)
        {
            var cil = src.Cil;
            dst.BaseAddress = cil.BaseAddress;
            dst.MemberId = src.Token;
            dst.Uri = src.OpUri;
            dst.Encoded = cil.Encoded;
            return ref dst;
        }

        public void EmitCilData(Index<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Count;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<MsilDataRow>(dst);
                var view = src.View;

                var formatter = Records.formatter<MsilDataRow>(array<byte>(16,16,80,20));
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
    }
}