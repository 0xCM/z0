//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static EmitHostArtifactsStep;

    public readonly struct EmitHostArtifactsStep
    {
        public const string WorkerName = nameof(EmitHostArtifactsStep);

        public const WfStepId StepId = WfStepId.EmitHostArtifacts;
    }

    [Step]
    public ref struct EmitHostArtifacts
    {
        public WfState Wf {get;}

        readonly CorrelationToken Ct;

        //readonly IApiHost Source;
        
        readonly ExtractedCode[] Extractions;

        readonly ApiHostUri Source;

        readonly THostCaptureArchive Target;       

        readonly IExtractParser Parser;

        public ParsedExtract[] Parsed;

        readonly FilePath ParsedPath;

        readonly FilePath HexPath;
        
        readonly FilePath AsmPath;

        public EmitHostArtifacts(WfState wf, ApiHostUri src, ExtractedCode[] extracts, TPartCaptureArchive dst, CorrelationToken ct)    
        {
            Wf = wf;
            Ct = ct;
            Source = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, Source);
            Extractions = extracts;
            ParsedPath = Target.ParseFilePath(Source);
            HexPath = Target.HexPath(Source);
            AsmPath = Target.AsmPath(Source);
            Parsed = new ParsedExtract[0]{};
            Parser = Extracts.Services.ExtractParser(Extracts.DefaultBufferLength);
            Wf.Created(WorkerName, Ct);            
        }

        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            
            try
            {
                Parse();
                SaveParseReport();
                SaveHex();        
                Decode();            
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }

            Wf.Ran(WorkerName, Ct);

        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        void Parse()
        {
            var result = Parser.Parse(Extractions);                    
            for(var i = 0; i<result.Failed.Length; i++)
                Wf.Raise(ExtractParseFailed.create(result.Failed[i]));

            var report = ParseFailureReport.Create(Source, result.Failed);
            report.Save(Target.UnparsedPath(Source));

            Parsed = result.Parsed;

            Wf.Raise(new ExtractsParsed(Source, Parsed));
        }
        
        void SaveParseReport()
        {
            using var step = new EmitParsedReport(Wf, Source, Parsed, ParsedPath, Ct);            
            step.Run();
        }

        void SaveHex()
        {
            var hex = IdentifiedCodeWriter.save(Source, Parsed, HexPath);                
            Wf.Raise(new HexCodeSaved(Source,  hex, ParsedPath));
        }

        void Decode()
        {
            using var step = new DecodeParsed(Wf, Wf.CWf.Context, Ct);
            var decoded = step.Run(Source,Parsed);
            if(decoded.Length != 0)
            {
                step.SaveDecoded(decoded, AsmPath);
                Wf.CWf.MatchAddresses.Run(Source, Extractions, decoded);
            }
        }

    }
}