//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    using API = Processors;
        
    public class MachineWorkflow : IMachineWorkflow
    {
        public static IMachineWorkflow Create(IMachineContext context)
            => new MachineWorkflow(context, context.TargetRoot);

        public IMachineContext Context {get;}
        
        readonly IDataProcessor<LocatedInstruction> Processor;

        public MachineWorkflow(IMachineContext context, FolderPath root)
        {
            Context = context;
            Processor = API.jmp(context);            
        }

        public void Process(PartInstructions src)
        {
            var processor = API.part(Context);
            processor.Process(src);
        }

        public void Run(PartInstructions src)        
        {            
            Process(src);
            
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