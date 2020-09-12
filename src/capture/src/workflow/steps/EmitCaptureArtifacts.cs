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

    public ref struct EmitCaptureArtifacts
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly X86ApiExtract[] Extracts;

        readonly ApiHostUri HostUri;

        readonly IHostCapturePaths Target;

        readonly IExtractParser Parser;

        //public X86MemberRefinement[] Parsed;

        public X86ApiMembers ParsedMembers;

        readonly FilePath ExtractPath;

        readonly FilePath ParsedPath;

        readonly FS.FilePath HexPath;

        readonly FilePath CilDataPath;

        readonly FilePath AsmPath;

        readonly IWfShell Wf;

        public EmitCaptureArtifacts(IWfCaptureState state, ApiHostUri src, X86ApiExtract[] extracts, IPartCapturePaths dst, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Ct = ct;
            HostUri = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, HostUri);
            Extracts = extracts;
            ExtractPath = Target.HostExtractPath;
            ParsedPath = Target.ParsedPath;
            HexPath = FS.path(Target.HostX86Path.Name);
            AsmPath = Target.HostAsmPath;
            CilDataPath = Target.CilPath;
            //Parsed = new X86MemberRefinement[0]{};
            Parser = ExtractParsers.member(Extractors.DefaultBufferLength);
            ParsedMembers = default;
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
                //SaveHex();
                Run(new EmitX86HexHost());
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

                using var step = new EmitExtractReport(State, HostUri, Extracts, ExtractPath, Ct);
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

            ParsedMembers = Parser.ParseMembers(Extracts);
            Wf.Raise(new ExtractsParsed(StepId, HostUri, ParsedMembers.Count, Ct));


            // var result = Parser.Parse(Extracts);

            // if(result.Failed.Length != 0)
            // {
            //     for(var i = 0; i<result.Failed.Length; i++)
            //         Wf.Raise(ExtractParseFailed.create(result.Failed[i]));

            //     var report = ParseFailureReport.Create(HostUri, result.Failed);
            //     report.Save(Target.UnparsedPath(HostUri));
            // }

            // Parsed = result.Parsed;
        }

        void SaveParseReport()
        {
            if(ParsedMembers.Count== 0)
                return;

            using var step = new EmitParsedReport(State, HostUri, ParsedMembers, ParsedPath, Ct);
            step.Run();
        }


        void Run(EmitX86HexHost host)
        {
            if(ParsedMembers.Count== 0)
                return;

            using var step = new EmitX86Hex(Wf, host, HostUri, ParsedMembers);
            step.Run();

        }

        void SaveHex()
        {
            if(ParsedMembers.Count== 0)
                return;

            var hex = X86ApiWriter.save(HostUri, ParsedMembers, HexPath);
            Wf.Raise(new ApiHexSaved(StepId, HostUri, hex, ParsedPath, Ct));
        }

        void SaveCil()
        {
            if(ParsedMembers.Count== 0)
                return;

            var src = ParsedMembers.View;
            var count = src.Length;
            using var dst = CilDataPath.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var parsed = ref skip(src,i);
                var cil = FunctionDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                dst.WriteLine(cil.Format());

            }
            Wf.Raise(new CilCodeSaved(StepId, HostUri, (uint)src.Length, FS.path(ParsedPath.Name), Ct));
        }

        void Decode()
        {
            if(ParsedMembers.Count== 0)
                return;

            using var step = new DecodeApiAsm(State.Wf, State.CWf.Context, Ct);
            var decoded = step.Run(HostUri, ParsedMembers);
            if(decoded.Length != 0)
            {
                step.SaveDecoded(decoded, AsmPath);
                Wf.Status(StepId, text.format(RenderPatterns.PSx3, decoded.Length,HostUri.Format(), AsmPath));

                using var match = new MatchAddresses(State, Extracts, decoded, Ct);
                match.Run();
            }
        }
    }
}