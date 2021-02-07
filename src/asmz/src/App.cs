//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    using static memory;
    using static TextRules;
    using static AsmExpr;

    class App : WfService<App,App>
    {
        public App()
        {

        }

        protected override void OnInit()
        {
            Etl = AsmEtl.catalog(Wf);
            AsmParser = AsmExpr.parser(Wf);
            TextBuffer = text.buffer();

        }

        AsmCatalogEtl Etl;

        AsmExprParser AsmParser;

        ITextBuffer TextBuffer;

        void ShowSigOpTokens()
        {
            var tokens = AsmExpr.SigOpTokens();
            root.iter(tokens, item => Wf.Row(item.Format()));
        }

        [Op]
        Index<ApiAddressRecord> Summarize(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiAddressRecord>(count);
            ref var dst = ref first(buffer);
            var rebase = first(members).BaseAddress;
            for(uint seq=0; seq<count; seq++)
            {
                ref var record = ref seek(dst,seq);
                ref readonly var member = ref skip(members, seq);
                record.Sequence = seq;
                record.ProcessBase = @base;
                record.MemberBase = member.BaseAddress;
                record.MemberOffset = member.BaseAddress - @base;
                record.MemberRebase = member.BaseAddress - rebase;
                record.MaxSize = seq < count - 1 ? (ulong)(skip(members, seq + 1).BaseAddress - record.MemberBase) : 0ul;
                record.HostName = member.Host.Name;
                record.PartName = member.Host.Owner.Format();
                record.Identifier = member.Id;
            }
            return buffer;
        }

        public Index<ApiAddressRecord> EmitCatalog(BasedApiMembers src)
        {
            var dst = Db.IndexTable<ApiAddressRecord>();
            Wf.Status($"Summarizing {src.MemberCount} members");
            var summaries = Summarize(src.Base, src.Members.View);
            Wf.Status($"Summarized {summaries.Count} members");
            var emitting = Wf.EmittingTable<ApiAddressRecord>(dst);
            var emitted = Records.emit<ApiAddressRecord>(summaries, dst);
            Wf.EmittedTable<ApiAddressRecord>(emitting, emitted, dst);
            return summaries;
        }

        void Jit()
        {
            var jitter = ApiServices.create(Wf).ApiJit();
            var members = jitter.JitApi();
            Wf.Status($"Jitted {members.MemberCount}");
            var records = EmitCatalog(members);
        }

        void EmitApiClasses()
        {
            var dst = Db.IndexTable("api.classes");
            var flow = Wf.EmittingTable<EnumLiteral>(dst);
            var service = ApiCatalogs.classes(Wf);
            var formatter = Records.formatter<EnumLiteral>();
            var classifiers = service.Classifiers();
            var literals = classifiers.SelectMany(x => x.Literals);
            var count = Records.emit(literals,dst);
            Wf.EmittedTable(flow, count);
        }

        void CreateLookup()
        {
            var tokens = AsmExpr.SigOpTokens();
            var lu = SymbolTables.create(tokens, t => t.Symbol);
            var count = tokens.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref tokens[i];
                if(token.IsNonEmpty)
                {
                    if(!lu.Index(token.Symbol, out var index))
                    {
                        Wf.Error($"Index for {token.Name} not found");
                    }
                    ref readonly var found = ref lu.Entry(index);

                    Wf.Row(found.Format());
                }
                else
                {
                    if(token.Index!=0)
                        Wf.Error($"Empty token has a nonzero index!");
                }
            }

        }

        void ShowSpecifiers()
        {
            var specifiers = Etl.Specifiers();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers,i);
                Wf.Row(spec.Format());
            }
        }

        void EmitSpecifiers()
        {
            var specifiers = Etl.Specifiers();
            Etl.Emit(specifiers);
        }

        void ParseSpec(OperationSpec src)
        {
            var sig = src.Sig;
            TextBuffer.Clear();
            TextBuffer.AppendFormat("{0,-12}", src.Seq);
            if(AsmParser.Mnemonic(sig, out var monic))
            {
                TextBuffer.AppendFormat(" | {0,-16}", monic);
                if(Parse.after(sig.Content, monic.Name, out var remainder))
                {
                    var operands = AsmParser.Operands(remainder).View;
                    var count = operands.Length;
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var op = ref skip(operands,i);

                        if(AsmParser.Decompose(op, out var pair))
                            TextBuffer.AppendFormat(" | (({0} // {1}))", pair.Left, pair.Right);
                        else
                            TextBuffer.AppendFormat(" | {0}", op.Content);
                    }

                }

            }

            Wf.Row(TextBuffer.Emit());
        }

        void ParseSigs()
        {
            var specifiers = Etl.Specifiers();
            var tokens = AsmExpr.SigOpTokens();
            var count = specifiers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specifiers, i);
                var sig = spec.Sig;
                ParseSpec(spec);
            }
        }

        public void Run()
        {
            Jit();

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args).WithRandom(Rng.@default());
                App.create(wf).Run();

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}