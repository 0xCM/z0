//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static CodeSymbolModels;
    using static core;

    public class TextDocParser
    {
        List<TextLine> Lines;

        TextDocParser()
        {
            Lines = new();
        }

        public void Parse(FS.FilePath src, FS.FolderPath dst)
        {

            using var reader = src.Reader();
            var counter = 1u;
            var data = reader.ReadLine();
            while(text.nonempty(data))
            {
                Parse(new TextLine(counter++, data));
            }
        }

        void Parse(in TextLine src)
        {

        }
    }

    sealed class ToolShell : AppService<ToolShell>
    {
        void EmitPartSymbols()
        {
            var svc = Wf.Symbolism();
            svc.EmitLiterals<PartId>();

        }

        public class SymbolCollector
        {
            DataList<MethodSymbol> Symbols;

            public SymbolCollector()
            {
                Symbols = new();
            }

            public void Deposit(ReadOnlySpan<MethodSymbol> src)
            {
                var count = src.Length;
                for(var i=0; i<count; i++)
                    Symbols.Add(skip(src,i));
            }

            public ReadOnlySpan<MethodSymbol> Collected
                => Symbols.View();
        }

        void Symbolize()
        {
            var assemblies = Wf.ApiCatalog.Components;
            var flow = Wf.Running(string.Format("Collecting method symbols for {0} assemblies", assemblies.Length));
            var symbolic = Wf.SourceSymbolic();
            var collector = new SymbolCollector();
            symbolic.SymbolizeMethods(assemblies, collector.Deposit);
            var collected = collector.Collected;
            var count = collected.Length;
            Wf.Ran(flow, string.Format("Collected {0} method symbols", count));
            var dst = Db.AppLog("methods", FS.Cs);
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(collected,i);
                var doc = method.Docs;
                writer.WriteLine(string.Format("{0}; {1}", method.Format(), doc != null ? "//" + doc.SummaryText : EmptyString));
            }
            Wf.EmittedFile(emitting, count);
        }

        void EmitDependencyGraph()
        {
            var svc = Wf.CliPipe();
            var refs = svc.ReadAssemblyRefs();
            var dst = Db.AppLog("dependencies", FS.Dot);
            var flow = Wf.EmittingFile(dst);
            var count = refs.Length;
            var parts = Wf.ApiCatalog.ComponentNames.ToHashSet();
            using var writer = dst.Writer();
            writer.WriteLine("digraph dependencies{");
            writer.WriteLine(string.Format("label={0}", text.enquote("Assembly Dependencies")));
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(refs,i);
                if(parts.Contains(x.Target.Name))
                {
                    var source = x.Source.Name.Replace(Chars.Dot, Chars.Underscore);
                    var target = x.Target.Name.Replace(Chars.Dot, Chars.Underscore);
                    var arrow = string.Format("{0}->{1}", source, target);
                    writer.WriteLine(arrow);
                }
            }
            writer.WriteLine("}");
            Wf.EmittedFile(flow, count);
        }

        void CalcRelativePaths()
        {
            var @base = Db.DbRoot();
            var files = Db.AsmCapturePaths().View;
            var relative = files.Map(f => f.Relative(@base));
            var count = relative.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(relative,i);
                var link = Markdown.link(path);
                Wf.Row(link);
            }
        }

        void GenSlnScript()
        {
            const string Pattern = "dotnet sln add {0}";
            var src = FS.dir(@"C:\Dev\z0");
            var dst = Db.AppLog("create-sln", FS.Cmd);
            var projects = src.Files(FS.CsProj, true);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            root.iter(projects,project => writer.WriteLine(string.Format(Pattern, project.Format(PathSeparator.BS))));
            Wf.EmittedFile(flow,projects.Length);
        }

        public void Parse()
        {
            const char Delimiter = ':';
            var input = "a:x:b: y: d";

            var parser = TextParsers.CreateCharSeqParser(Delimiter);
            var result = parser.Parse(input, out var output);
            if(result)
            {
                root.iter(output, x => Wf.Row(new string(x)));
            }
        }

        void ParseDump()
        {
            using var clrmd = ClrMdSvc.create(Wf);
            clrmd.ParseDump();

        }

        public void Run()
        {

        }
    }


    class App
    {
        public static void run(string[] args)
            => app(shell(args)).Run();

        static App app(IWfRuntime wf)
            => new App(wf);

        static IWfRuntime shell(string[] args)
            => WfRuntime.create(ApiQuery.parts(root.controller(), args), args).WithSource(Rng.@default());

        IWfRuntime Wf;

        App(IWfRuntime wf)
        {
            Wf = wf;
        }

        void Run()
        {
            try
            {
                using var shell = ToolShell.create(Wf);
                shell.Run();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public static void Main(params string[] args)
            => run(args);
    }

    public static partial class XTend {}
}