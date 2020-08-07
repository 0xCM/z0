//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static Konst;

    using static ProcessInstructionsStep;
    using API = Processors;    
            
    public class ProcessInstructions 
    {
        public static ProcessInstructions create(WfContext wf, FolderPath dst)
            => new ProcessInstructions(wf, dst);

        readonly WfContext Context;
        
        readonly IDataProcessor<LocatedInstruction> Processor;

        public ProcessInstructions(WfContext wf, FolderPath root)
        {
            Context = wf;
            Processor = API.jmp(wf);            
        }

        public void Run(PartInstructions src)        
        {            
            Process(src);            
        }

        public void Process(PartInstructions src)
        {
            var processor = API.part(Context);
            processor.Process(src);
        }
 
        public void Render(PartInstructions src)
        {
            var part = src.Part;
            var inxs = src.Content;
            var archive = Archives.Services.Semantic;
            var dir = archive.SemanticDir(part).Clear();

            for(var i = 0; i < src.Content.Length; i++)
                Render(src.Content[i]);
        }

        public void Render(HostInstructions src)        
        {
            var archive = Archives.Services.Semantic;
            var path = archive.SemanticPath(src.Host);  
            var semantic = RenderSemantic.Create();
            using var writer = path.Writer();
            semantic.Render(src,writer);
        }
    }
}