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
    using static Chars;
    using static memory;
    using static Rules;

    public sealed class AsmThumbprints : WfService<AsmThumbprints>
    {
        public static AsmThumbprint from(AsmApiStatement src)
            => AsmThumbprints.define(src.Expression, src.Sig, src.OpCode, src.Encoded);

        const string Implication = " => ";

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Extensions.Asm);

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
                if(tpPipe.ParseThumbprint(data, out var thumbprint))
                    dst.Add(thumbprint);
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
                writer.WriteLine(format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void ShowThumprintCatalog()
        {
            var src = LoadThumbprints().View;
            var count = src.Length;
            using var log = ShowLog(FS.Asm, "thumbprints");
            for(var i=0; i<count; i++)
                log.Show(AsmThumbprints.format(skip(src,i)));
        }

        public void EmitThumbprints(Index<AsmApiStatement> src)
        {
            var distinct = root.hashset<AsmThumbprint>();
            root.iter(src, s => distinct.Add(AsmThumbprints.from(s)));
            Wf.Status(Msg.CollectedThumbprints.Format(distinct.Count, src.Count));
            EmitThumbprints(distinct.ToArray());
        }

        public Outcome ParseThumbprint(string src, out AsmThumbprint thumbprint)
        {
            thumbprint = AsmThumbprint.Empty;
            var outcome = Outcome.Empty;
            var a = src.LeftOfFirst(Semicolon);
            var offset = HexNumericParser.parse16u(a.LeftOfFirst(Chars.Space)).ValueOrDefault();
            AsmStatementExpr statement = a.RightOfFirst(Semicolon);

            var parts = @readonly(src.RightOfFirst(Semicolon).SplitClean(Implication));
            if(parts.Length == 2)
            {
                var lhs = skip(parts,0);
                var rhs = skip(parts,1);
                if(text.unfence(lhs, SigFence, out var sigexpr))
                {
                    if(AsmSyntax.sig(sigexpr, out var sig, out outcome))
                    {
                        if(!AsmSyntax.code(sig.Mnemonic, out var monic))
                            Wf.Warn(Msg.MonicCodeParseFailed.Format(sig.Mnemonic));

                        if(text.unfence(lhs, OpCodeFence, out var opcode))
                        {
                            if(AsmBytes.hexcode(rhs, out var encoded))
                            {
                                thumbprint = new AsmThumbprint(statement, sig, AsmCore.opcode(opcode), encoded);
                                return true;
                            }
                            else
                                Wf.Error($"Could not parse the encoded bytes");
                        }
                        else
                            Wf.Error(Msg.OpCodeFenceNotFound.Format(OpCodeFence));

                    }
                    else
                        Wf.Error($"Could not parse sig expression from ${sigexpr}");
                }
                else
                    Wf.Error($"Could not locate the signature fence {SigFence}");
            }
            else
                Wf.Error($"Could not dichotomize {src} ");

            return false;
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

        [Op]
        public static int cmp(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).CompareTo(format(b));

        [Op]
        public static bool eq(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).Equals(format(b));

        [Op]
        public static string format(AsmThumbprint src)
            => string.Format("{0} ; ({1})<{2}>[{3}] => {4}", src.Statement.FormatFixed(), src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());
    }
}