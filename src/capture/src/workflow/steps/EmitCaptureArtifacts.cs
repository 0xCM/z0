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

    public ref struct EmitCaptureArtifacts
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly ApiMemberExtract[] Extracts;

        readonly ApiHostUri HostUri;

        readonly IHostCapturePaths Target;

        readonly IExtractParser Parser;

        public ApiMemberCodeTable ParsedMembers;

        readonly FilePath ExtractPath;

        readonly FS.FilePath ParsedPath;

        readonly FS.FilePath HexPath;

        readonly FS.FilePath CilDataPath;

        readonly FilePath AsmPath;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitCaptureArtifacts(IWfCaptureState state, WfHost host, ApiHostUri src, ApiMemberExtract[] extracts, IPartCapturePaths dst)
        {
            Wf = state.Wf;
            Host = host;
            State = state;
            Ct = Wf.Ct;
            HostUri = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, HostUri);
            Extracts = extracts;
            ExtractPath = Target.HostExtractPath;
            ParsedPath = FS.path(Target.ParsedPath.Name);
            HexPath = FS.path(Target.HostX86Path.Name);
            AsmPath = Target.HostAsmPath;
            CilDataPath = FS.path(Target.CilPath.Name);
            Parser = ApiExtractParsers.member();
            ParsedMembers = default;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                Run(new EmitExtractReportHost());
                Run(new EmitParsedReportHost());
                Run(new EmitX86HexHost());
                Run(new EmitCilMembersHost());
                Run(new DecodeApiMembersHost());
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host);
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


        void Run(EmitParsedReportHost host)
        {
            if(Extracts.Length == 0)
                return;

            ParsedMembers = Parser.ParseMembers(Extracts);
            Wf.Raise(new ExtractsParsed(Host, HostUri, ParsedMembers.Count, Ct));

            if(ParsedMembers.Count == 0)
                return;

            using var step = new EmitApiParseReport(Wf, host, HostUri, ParsedMembers, ParsedPath);
            step.Run();
        }

        void Run(EmitX86HexHost host)
        {
            if(ParsedMembers.Count== 0)
                return;

            using var step = new EmitApiCodeTable(Wf, host, HostUri, ParsedMembers);
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

            Wf.Raise(new CilDataSaved(Host, HostUri, src.Length, CilDataPath, Ct));
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
                Wf.Status(Host, text.format(RP.PSx3, decoded.Length,HostUri.Format(), AsmPath));

                using var match = new MatchAddresses(State, Extracts, decoded, Ct);
                match.Run();
            }
        }
    }
}