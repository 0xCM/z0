//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CodeSolutions;
    using static CodeSymbolModels;

    using static memory;

    sealed class ToolShell : AppService<ToolShell>
    {
        void CheckSolutionParser()
        {
            var src = FS.path(@"C:\Dev\z0\z0.machine.sln");
            var flow = Wf.Running(string.Format("Processing {0}", src.ToUri()));
            var tool = Wf.Roslyn();
            var sln = tool.LoadSolution(src);
            var projects = sln.Projects.AsSpan();
            Process(projects);
            var count = projects.Length;
            Wf.Ran(flow, string.Format("Processed {0} with {1} projects", src.ToUri(), count));
        }

        void Process(ReadOnlySpan<ProjectBlock> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var project = ref skip(src,i);
                var path = FS.path(project.RelativePath);
                var sections = project.Sections.AsSpan();
                Wf.Status(string.Format("Processing {0} from {1} with {2} sections", project.ProjectName, path.Format(PathSeparator.FS), sections.Length));
                Process(sections);
            }
        }

        void Process(ReadOnlySpan<SectionBlock> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var section = ref skip(src,i);
                Wf.Row(section.Name);
                var props = section.Properties.AsSpan();
                Process(props);
            }
        }

        void Process(ReadOnlySpan<Property> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var prop = ref skip(src,i);
                Wf.Row(string.Format("{0}:{1}", prop.Name, prop.Value));
            }
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

        public void Run()
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
                var shell = ToolShell.create(Wf);
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