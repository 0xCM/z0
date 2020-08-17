//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static Konst;
    using static ProcessInstructionsStep;
    
    using api = Processors;    
            
    public class ProcessInstructions 
    {
        public static ProcessInstructions create(IWfContext wf, FolderPath dst)
            => new ProcessInstructions(wf, dst);

        public IWfContext Wf {get;}
        
        readonly ProcessAsmJmp Processor;

        public ProcessInstructions(IWfContext wf, FolderPath root)
        {
            Wf = wf;
            Processor = api.jmp(wf);            
        }

        public void Run(PartAsmFx src)        
        {            
            Process(src);            
        }

        public void Process(PartAsmFx src)
        {
            api.processor(Wf).Process(src);
        }
 
        public void Render(PartAsmFx src)
        {
            var part = src.Part;
            var archive = Archives.Services.Semantic;
            var dir = archive.SemanticDir(part).Clear();

            for(var i = 0; i < src.Data.Length; i++)
                Render(src.Data[i]);
        }

        public void Render(HostAsmFx src)        
        {
            var archive = Archives.Services.Semantic;
            var path = archive.SemanticPath(src.Host);  
            var semantic = RenderSemantic.Create();
            using var writer = path.Writer();
            semantic.Render(src,writer);
        }
    }
}