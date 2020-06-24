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

        void GenerateMasks()
        {
            var literals = BitMask.NumericLiterals;
            for(var i=0; i < literals.Length; i++)
            {
                ref readonly var literal = ref skip(literals,i);
                var x = $"{literal.Name} = {literal.Text}";
                term.print(x);
            }
        }

        public static void CaptureResBytes(ISuiteContext context)
        {

            var src = FilePath.Define(@"J:\dev\projects\z0-logs\res\bin\lib\netcoreapp3.0\z0.res.bytes.dll");
            Demands.insist(src.Exists);

            // var dir = context.AsmContext.AppPaths.CaptureRoot;

            // var svc = AccessorCapture.Service(context.AsmContext);
            // var captured = svc.Capture(src, CasePath(FileExtensions.Asm));
            // var addresses = CasePath(FileExtensions.Csv);            
            // svc.CollectAddresses(captured, addresses);

        }

        void GenerateDocs()
        {   
            var docs = Commented.collect();
        }

        void GenerateResources()
        {   
             var src = Archives.Services.CaptureRoot;
             var dst = Z0.AppPaths.Default.ResourceRoot + FolderName.Define("bytes");
             var service = HostCodeResources.Service(src, dst);
             service.Emit();
        }

        void EmitMetadata()
        {   
            var service = MetadataEmitter.Service();
            service.Emit();
        }

        public void Generate(IAppContext app)
        {            
            GenerateDocs();
            GenerateResources();
            EmitMetadata();
            var suite = ContextFactory.CreateSuiteContext(app);
            //EnumGenerator.Service.Generate();
        }
    }
}