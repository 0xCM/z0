//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;


    [ApiHost]
    partial class ApiExtractor : AppService<ApiExtractor>
    {
        ApiExtractParser Parser;

        Z0.ApiExtractor Extractor;

        ApiResolver Resolver;

        AsmRoutineDecoder Decoder;

        ApiDecoder ApiDecoder;

        AsmFormatter Formatter;

        HexPacks HexPacks;

        ApiExtractObserver Observer;

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Extractor = Wf.ApiExtractor();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.HexPacks();
            ApiDecoder = Wf.ApiDecoder();
            Observer = new ApiExtractObserver(Wf);
        }

        void Run3()
        {
            var selected = root.hashset(PartId.Cpu, PartId.Math, PartId.GMath);
            var flow = Wf.Running(string.Format("Exracting parts {0}", selected.Delimit(Chars.Comma)));
            var catalog = Wf.ApiCatalog;
            var parts = catalog.Parts.Where(p => selected.Contains(p.Id));
            var count = parts.Length;
            var resolved = @readonly(parts.Select(ResolvePart));
            var datasets = root.list<ApiHostDataset>();
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(resolved,i);
                counter += ExtractPart(part, datasets);
            }
            Wf.Ran(flow, string.Format("Extracted {0} host routines from {1} parts", counter, selected.Count));
        }


        public void Run()
        {
            RootDir().Clear(true);
            Run3();
        }

        public void Run(ApiExtractObserver observer)
        {
            Observer = observer;
            Run();
        }
    }
}