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
    using static z;
    using static EmitHostArtifactsStep;

    public ref struct EmitHostArtifacts
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly X86MemberExtract[] Extracts;

        readonly ApiHostUri Source;

        readonly IHostCapturePaths Target;

        readonly IExtractionParser Parser;

        public X86MemberRefinement[] Parsed;

        readonly FilePath ExtractPath;

        readonly FilePath ParsedPath;

        readonly FilePath HexPath;

        readonly FilePath CilDataPath;

        readonly FilePath AsmPath;

        readonly IWfShell Wf;

        public EmitHostArtifacts(IWfCaptureState state, ApiHostUri src, X86MemberExtract[] extracts, IPartCapturePaths dst, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Ct = ct;
            Source = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, Source);
            Extracts = extracts;
            ExtractPath = Target.HostExtractPath;
            ParsedPath = Target.ParsedPath;
            HexPath = Target.HostHexPath;
            AsmPath = Target.HostAsmPath;
            CilDataPath = Target.CilDataPath;
            Parsed = new X86MemberRefinement[0]{};
            Parser = Extractors.Services.ExtractParser(Extractors.DefaultBufferLength);
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                SaveExtracts();
                Parse();
                SaveParseReport();
                SaveHex();
                SaveCil();
                Decode();
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId);
        }

        void SaveExtracts()
        {
            try
            {
                if(Extracts.Length == 0)
                    return;

                using var step = new EmitExtractReport(State, Source, Extracts, ExtractPath, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void Parse()
        {
            if(Extracts.Length == 0)
                return;

            var result = Parser.Parse(Extracts);

            if(result.Failed.Length != 0)
            {
                for(var i = 0; i<result.Failed.Length; i++)
                    Wf.Raise(ExtractParseFailed.create(result.Failed[i]));

                var report = ParseFailureReport.Create(Source, result.Failed);
                report.Save(Target.UnparsedPath(Source));
            }

            Parsed = result.Parsed;
            Wf.Raise(new ExtractsParsed(StepName, Source, Parsed, Ct));
        }

        void SaveParseReport()
        {
            if(Parsed.Length == 0)
                return;
            using var step = new EmitParsedReport(State, Source, Parsed, ParsedPath, Ct);
            step.Run();
        }

        void SaveHex()
        {
            if(Parsed.Length == 0)
                return;

            var hex = IdentifiedCodeWriter.save(Source, Parsed, HexPath);
            Wf.Raise(new HexCodeSaved(StepId, Source, hex, ParsedPath, Ct));
        }

        void SaveCil()
        {
            if(Parsed.Length == 0)
                return;

            var src = span(Parsed);
            var count = src.Length;
            using var dst = CilDataPath.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var parsed = ref skip(src,i);
                var cil = FunctionDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                dst.WriteLine(cil.Format());

            }
            Wf.Raise(new CilCodeSaved(StepId, Source, (uint)src.Length, ParsedPath, Ct));
        }

        void Decode()
        {
            if(Parsed.Length == 0)
                return;

            using var step = new DecodeParsed(State.Wf, State.CWf.Context, Ct);
            var decoded = step.Run(Source, Parsed);
            if(decoded.Length != 0)
            {
                step.SaveDecoded(decoded, AsmPath);
                Wf.Status(StepId, text.format(RenderPatterns.PSx3, decoded.Length,Source.Format(), AsmPath));

                using var match = new MatchAddresses(State, Extracts, decoded, Ct);
                match.Run();
            }
        }
    }
}