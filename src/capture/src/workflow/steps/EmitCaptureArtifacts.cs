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

        public X86ApiMembers ParsedMembers;

        readonly FilePath ExtractPath;

        readonly FilePath ParsedPath;

        readonly FS.FilePath HexPath;

        readonly FilePath CilDataPath;

        readonly FilePath AsmPath;

        readonly IWfShell Wf;

        public EmitCaptureArtifacts(IWfCaptureState state, ApiHostUri src, X86ApiExtract[] extracts, IPartCapturePaths dst)
        {
            Wf = state.Wf;
            State = state;
            Ct = Wf.Ct;
            HostUri = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, HostUri);
            Extracts = extracts;
            ExtractPath = Target.HostExtractPath;
            ParsedPath = Target.ParsedPath;
            HexPath = FS.path(Target.HostX86Path.Name);
            AsmPath = Target.HostAsmPath;
            CilDataPath = Target.CilPath;
            Parser = ExtractParsers.member();
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
                Run(new EmitExtractReportHost());
                Parse();
                if(ParsedMembers.Count != 0)
                {
                    SaveParseReport();
                    Run(new EmitX86HexHost());
                    Run(new EmitCilMembersHost());
                    Run(new DecodeApiMembersHost());
                }
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId);
        }

        void Run(EmitExtractReportHost host)
        {
            try
            {
                if(Extracts.Length == 0)
                    return;

                using var step = new EmitExtractReport(Wf, host, HostUri, Extracts, FS.path(ExtractPath.Name));
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

            using var step = new EmitX86ApiMembers(Wf, host, HostUri, ParsedMembers);
            step.Run();

        }

        void Run(EmitCilMembersHost host)
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

        void Run(DecodeApiMembersHost host)
        {
            if(ParsedMembers.Count== 0)
                return;

            using var step = new DecodeApiMembers(State.Wf, host, State.CWf.Context);
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