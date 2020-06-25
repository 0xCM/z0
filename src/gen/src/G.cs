//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static Root;

    public readonly struct G 
    {
        public static G Service => default(G);

        void EmitMasks(IAppContext context)
        {
            var literals = span(BitMaskCollector.collect());
            for(var i=0; i <literals.Length; i++)
            {
                ref readonly var literal = ref skip(literals,i);
                
                //var x = $"{literal.Name} = {literal.Text}";
                //term.print(x);
            }
        }

        void EmitDocs(IAppContext app)
        {   
            Commented.collect();
        }

        void EmitResources(IAppContext app)
        {   
            HostCodeResources.Service(app).Emit();
        }

        void CaptureEmissions(IAppContext app)
        {
            var suite = ContextFactory.CreateSuiteContext(app);
            var ac = AccessorCapture.Service(suite.AsmContext);
            ac.CaptureResBytes();        
        }
        void EmitMetadata(IAppContext app)
        {   
            var service = MetadataEmitter.Service();
            service.Emit();
        }

        public void Generate(IAppContext app)
        {            
            EmitMetadata(app);
            EmitDocs(app);
            EmitResources(app);
            CaptureEmissions(app);
        }
    }
}