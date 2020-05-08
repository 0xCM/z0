//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using System.IO;
    using static Seed;
    using static Memories;

    public class MachineWorkflow : IMachineWorkflow
    {
        public static IMachineWorkflow Create(IMachineContext context)
            => new MachineWorkflow(context, context.TargetRoot);

        public IMachineContext Context {get;}
        
        readonly IDataProcessor<LocatedCode> Processor;

        public MachineWorkflow(IMachineContext context, FolderPath root)
        {
            Context = context;
            Processor = JmpProcessors.Create(context);            

        }

        public void Run(PartInstructions src)        
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