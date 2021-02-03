//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    using static memory;
    using static TextRules;

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

        void ParseSpec(AsmSpecifierExpr src)
        {
            var sig = src.Sig;
            TextBuffer.Clear();
            TextBuffer.AppendFormat("{0,-12}", src.Seq);
            if(AsmParser.Mnemonic(sig, out var monic))
            {
                TextBuffer.AppendFormat(" | {0,-16}", monic);
                if(Parse.after(sig.Content, monic.Content, out var remainder))
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
            ParseSigs();

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