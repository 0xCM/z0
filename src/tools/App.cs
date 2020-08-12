//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Tools;
    
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
            Ct = CorrelationToken.define(Part);   
            Raise(status(ActorName, "Application created", Ct));        
        }

        void RunDumpBin()
        {
            var tool = DumpBin.create(Wf);
            var archive = tool.Target;
            var files  = archive.Files(DumpBinFlag.Disasm);
            var listed = Tooling.listed(files);
            var formatted = FileSystem.format(listed);
            
            using var processor = tool.processor(default(FileKinds.Asm));
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