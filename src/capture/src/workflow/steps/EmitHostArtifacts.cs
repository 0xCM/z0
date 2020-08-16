//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static EmitHostArtifactsStep;

    public ref struct EmitHostArtifacts
    {
        public WfCaptureState Wf {get;}

        readonly CorrelationToken Ct;
        
        readonly ExtractedCode[] Extractions;

        readonly ApiHostUri Source;

        readonly IHostCaptureArchive Target;       

        readonly IExtractionParser Parser;

        public ParsedExtraction[] Parsed;

        readonly FilePath ExtractPath;

        readonly FilePath ParsedPath;

        readonly FilePath HexPath;
        
        readonly FilePath AsmPath;

        public EmitHostArtifacts(WfCaptureState wf, ApiHostUri src, ExtractedCode[] extracts, IPartCaptureArchive dst, CorrelationToken ct)    
        {
            Wf = wf;
            Ct = ct;
            Source = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, Source);
            Extractions = extracts;
            ExtractPath = Target.ExtractPath;
            ParsedPath = Target.ParsedPath;
            HexPath = Target.HexPath;
            AsmPath = Target.AsmPath;
            Parsed = new ParsedExtraction[0]{};
            Parser = Extractors.Services.ExtractParser(Extractors.DefaultBufferLength);
            Wf.Created(StepName, Ct);            
        }

        public void Run()
        {
            Wf.Running(StepName, Ct);
            
            try
            {
                SaveExtracts();
                Parse();
                SaveParseReport();
                SaveHex();        
                Decode();            
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }

            Wf.Ran(StepName, Ct);

        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        void SaveExtracts()
        {            
            using var step = new EmitExtractReport(Wf, Source, Extractions, ExtractPath, Ct);
            step.Run();
        }
        
        void Parse()
        {
            var result = Parser.Parse(Extractions);                    
            for(var i = 0; i<result.Failed.Length; i++)
                Wf.Raise(ExtractParseFailed.create(result.Failed[i]));

            var report = ParseFailureReport.Create(Source, result.Failed);
            report.Save(Target.UnparsedPath(Source));

            Parsed = result.Parsed;

            Wf.Raise(new ExtractsParsed(StepName, Source, Parsed, Ct));
        }
        
        void SaveParseReport()
        {
            using var step = new EmitParsedReport(Wf, Source, Parsed, ParsedPath, Ct);            
            step.Run();
        }

        void SaveHex()
        {
            var hex = IdentifiedCodeWriter.save(Source, Parsed, HexPath);                
            Wf.Raise(new HexCodeSaved(StepName, Source, hex, ParsedPath, Ct));
        }

        void Decode()
        {
            using var step = new DecodeParsed(Wf, Wf.CWf.Context, Ct);
            var decoded = step.Run(Source,Parsed);
            if(decoded.Length != 0)
            {
                step.SaveDecoded(decoded, AsmPath);                
                
                using var match = new MatchAddresses(Wf, Extractions, decoded, Ct);
                match.Run();                
            }
        }
    }
}