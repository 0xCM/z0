//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;
    using static AsmRecords;

    public sealed class AsmThumbprints : AppService<AsmThumbprints>
    {
        public static AsmThumbprint from(AsmApiStatement src)
            => AsmThumbprints.define(src.Expression, src.Sig, src.OpCode, src.Encoded);

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Asm);

        public Index<AsmThumbprint> LoadThumbprints()
            => LoadThumbprints(DefaultPath());

        public Index<AsmThumbprint> LoadThumbprints(FS.FilePath src)
        {
            var dst = root.list<AsmThumbprint>();
            var tpPipe = AsmThumbprints.create(Wf);
            using var reader = src.Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = AsmCore.statement(data.LeftOfFirst(Chars.Semicolon));
                var tpResult = AsmParser.thumbprint(data, out var thumbprint);
                if(tpResult)
                    dst.Add(thumbprint);
                else
                    Wf.Error(tpResult.Message);
            }
            return dst.ToArray();
        }

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src)
        {
            var dst = DefaultPath();
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void ShowThumprintCatalog()
        {
            var src = LoadThumbprints().View;
            var count = src.Length;
            using var log = ShowLog(FS.Asm, "thumbprints");
            for(var i=0; i<count; i++)
                log.Show(AsmRender.format(skip(src,i)));
        }

        public void EmitThumbprints(Index<AsmApiStatement> src)
        {
            var distinct = root.hashset<AsmThumbprint>();
            root.iter(src, s => distinct.Add(AsmThumbprints.from(s)));
            Wf.Status(Msg.CollectedThumbprints.Format(distinct.Count, src.Count));
            EmitThumbprints(distinct.ToArray());
        }

        [MethodImpl(Inline),Op]
        public static AsmThumbprint from(in AsmApiStatement src)
            => define(src.Expression, src.Sig, src.OpCode, src.Encoded);

        [MethodImpl(Inline),Op]
        public static AsmThumbprint define(AsmStatementExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprint(statement, sig, opcode, encoded);

        [MethodImpl(Inline),Op]
        public static AsmThumbprint define(AsmStatementExpr statement, AsmFormExpr form, AsmHexCode encoded)
            => new AsmThumbprint(statement, form.Sig, form.OpCode, encoded);
    }
}