//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static Flow;
    using static z;

    class App : AppShell<App,IAppContext>
    {        
        public const PartId Part = PartId.Tools;
        
        public const string PartName = nameof(PartId.Tools);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         

        IWfContext Wf;
        
        public App()
            : base(Flow.app())
        {
            Ct = CorrelationToken.define((byte)Part);   
            Raise(status(ActorName, "Application created", Ct));        
        }

        void RunDumpBin()
        {
            var tool = Tools.dumpbin(Wf);
            var archive = tool.Target;
            var files  = archive.Files(DumpBin.Flag.Disasm);
            var listed = ListedFiles.from(files);
            var formatted = ListedFiles.format(listed);
            
            // term.print(tool.Flags);
            // term.print(formatted);

            using var processor = tool.processor(default(AsmFileKind));
            for(var i=0u; i <files.Count; i++)
            {
                processor.Process(files[i]);
            }                           
        }

        public override void RunShell(params string[] args)
        {                        
            Raise(status(ActorName, new {Message ="Running shell", Args = text.bracket(args.FormatList())},Ct));            
        
            try
            {
                var config = Flow.configure(Context, args, Ct);            
                Wf = Flow.context(Context, config, Ct);
                RunDumpBin();
                
            }
            catch(Exception e)
            {
                Raise(error(ActorName, e, Ct));                
            }

            Raise(status(ActorName, "Shell run complete", Ct));
        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {
            Wf.Dispose();
            Raise(status(ActorName, "Shell finished", Ct));
        }
    }

    public static partial class XTend
    {

    }
}