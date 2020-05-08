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

    public class SemanticFormatter : ISemanticFormatter
    {
        public static ISemanticFormatter Create(IMachineContext context)
            => new SemanticFormatter(context, context.TargetRoot);

        public IMachineContext Context {get;}
        
        List<string> Descriptions;


        public SemanticFormatter(IMachineContext context, FolderPath root)
        {
            Context = context;
            Descriptions = list<string>();
        }

        void Reset()
        {
            Descriptions.Clear();
        }

        public void Render(PartInstructions src)        
        {
            var part = src.Part;
            var inxs = src.Instructions;
            var archive = Archives.Services.Semantic;
            var dir = archive.SemanticDir(part).Clear();

            for(var i = 0; i < src.Instructions.Length; i++)
                Render(src.Instructions[i]);
        }

        public void Render(HostInstructions src)        
        {
            var host = src.Host;
            var part = host.Owner;
            var inxs = src.Instructions;
            var archive = Archives.Services.Semantic;
            var path = archive.SemanticPath(host);  
            var opcount = src.OpCount;
            
            var renderSvc = RenderSemantic.Create();

            using var writer = path.Writer();

            for(var i=0; i<opcount; i++)
            {
                var f = inxs[i];
                var @base = f.BaseAddress;
                var opId = f.OpUri;
                OpAddress located = (opId, @base);
                var opInxs = f.Instructions.Map(x => x.Instruction);
                Descriptions.AddRange(renderSvc.Render(located, opInxs));

                Emit(writer);
                
                if(i != opcount - 1)
                    writer.WriteLine();
                
                Reset();
            }
        }

        void Emit(StreamWriter dst)
        { 
            if(Descriptions.Count != 0)
                Control.iter(Descriptions, dst.WriteLine);                         
        }
    }
}