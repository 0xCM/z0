//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;
    using static memory;
    using static Rules;
    using static TextRules.Parse;

    public sealed class AsmThumbprints : WfService<AsmThumbprints>
    {
        const string Implication = " => ";

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static Fence<char> SizeFence => (LBracket, RBracket);

        FS.FilePath ThumbprintsPath()
            => Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Extensions.Asm);

        public AsmThumprintCatalog LoadThumbprints()
        {
            var dst = root.list<Paired<AsmStatementExpr,AsmThumbprint>>();
            var tpPipe = AsmThumbprints.create(Wf);
            var source = ThumbprintsPath();
            using var reader = source.Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = asm.statement(data.LeftOfFirst(Chars.Semicolon));
                if(tpPipe.ParseThumbprint(data, out var thumbprint))
                    dst.Add(root.paired(statement,thumbprint));
            }
            return new AsmThumprintCatalog(dst.ToArray());
        }

        public void EmitThumbprints()
        {
            var counter = 0;
            var distinct = new AsmStatementSummaries();

            void receiver(AsmApiStatement src)
            {
                counter++;
                distinct.Add(src.Summary());
            }

            Wf.AsmTraverser().Traverse(receiver);
            EmitThumbprints(distinct);
        }

        public void ShowThumprintCatalog()
        {
            var src = LoadThumbprints().Entries;
            var count = src.Length;
            using var log = ShowLog(FS.Extensions.Asm, "thumbprints");
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                var output = string.Format("{0,-48} ; {1}", entry.Left, entry.Right);
                log.Show(output);
            }
        }

        public void EmitThumbprints(Index<AsmApiStatement> src)
        {
            var distinct = new AsmStatementSummaries();
            root.iter(src, s => distinct.Add(s.Summary()));
            var collected = distinct.Collected();
            Wf.Status($"Collected {collected.Length} thumbprints from {src.Count} statements");
            EmitThumbprints(distinct);
        }

        public void EmitThumbprints(AsmStatementSummaries src)
        {
            var target = ThumbprintsPath();
            var flow = Wf.EmittingFile(target);
            using var writer = target.Writer();
            var buffer = text.buffer();
            render(src, buffer);
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow,1);
        }

        static uint render(AsmStatementSummaries src, ITextBuffer dst)
        {
            var values = src.Collected();
            var counter = 0u;
            for(var i=0; i<values.Length; i++)
            {
                ref readonly var value = ref skip(values,i);
                dst.AppendLineFormat("{0,-36} ; {1}", value.Statement, value.Thumbprint);
                counter++;
            }
            return counter;
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
                if(unfence(lhs, SigFence, out var sigexpr))
                {
                    if(AsmSyntax.sig(sigexpr, out var sig, out outcome))
                    {
                        if(!AsmSyntax.code(sig.Mnemonic, out var monic))
                            Wf.Warn(Msg.MonicCodeParseFailed.Format(sig.Mnemonic));

                        if(unfence(lhs, OpCodeFence, out var opcode))
                        {
                            if(AsmBytes.hexcode(rhs, out var encoded))
                            {
                                thumbprint = new AsmThumbprint(sig, asm.opcode(opcode), encoded);
                                return true;
                            }
                            else
                                Wf.Error($"Could not parse the encoded bytes");
                        }
                        else
                            Wf.Error($"Could not located the opcode fence ${OpCodeFence}");

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

        [Op]
        public static int cmp(in AsmThumbprintExpr a, in AsmThumbprintExpr b)
        {
            var e0 = a.Format().LeftOfFirst(Implication);
            var e1 = b.Format().LeftOfFirst(Implication);
            return e0.CompareTo(e1);
        }

        [MethodImpl(Inline),Op]
        public static AsmThumbprint define(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprint(sig, opcode, encoded);

        [MethodImpl(Inline),Op]
        public static AsmThumbprint define(AsmFormExpr form, AsmHexCode encoded)
            => new AsmThumbprint(form.Sig, form.OpCode, encoded);

        [Op]
        public static AsmThumbprintExpr expression(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprintExpr(define(sig, opcode, encoded).Format());

        [Op]
        public static int cmp(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).CompareTo(format(b));

        [Op]
        public static bool eq(in AsmThumbprint a, in AsmThumbprint b)
            => format(a).Equals(format(b));

        [Op]
        public static string format(AsmThumbprint src)
        {
            var lhs = string.Format("({0})<{1}>[{2}]", src.Sig, src.OpCode, src.Encoded.Size);
            var encoded = src.Encoded.Format();
            return string.Concat(lhs,Implication, encoded);
        }
    }
}