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

    [Step]
    public sealed class EmitCaptureArtifacts : WfHost<EmitCaptureArtifacts>
    {

    }

    public ref struct EmitCaptureArtifactsStep
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly ApiMemberExtract[] Extracts;

        readonly ApiHostUri HostUri;

        readonly IHostCapturePaths Target;

        readonly IExtractParser Parser;

        public ApiMemberCodeBlocks ParsedBlocks;

        readonly FilePath ExtractPath;

        readonly FS.FilePath ParsedPath;

        readonly FS.FilePath CilDataPath;

        readonly FS.FilePath AsmPath;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitCaptureArtifactsStep(IWfCaptureState state, WfHost host, ApiHostUri src, ApiMemberExtract[] extracts, IPartCapturePaths dst)
        {
            Wf = state.Wf.WithHost(host);
            Host = host;
            State = state;
            Ct = Wf.Ct;
            HostUri = src;
            Target = HostCaptureArchive.create(dst.ArchiveRoot, HostUri);
            Extracts = extracts;
            ExtractPath = Target.HostExtractPath;
            ParsedPath = FS.path(Target.ParsedPath.Name);
            AsmPath = Target.HostAsmPath;
            CilDataPath = FS.path(Target.CilPath.Name);
            Parser = ApiExtractParsers.member();
            ParsedBlocks = default;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();

            try
            {
                Run(new EmitExtractReport());
                ParseMembers();
                EmitApiCodeBlocks.create(HostUri, ParsedBlocks).Run(Wf);
                EmitHostCil.create(HostUri).Run(Wf, ParsedBlocks, out var _);
                DecodeMembers();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }

        void Run(EmitExtractReport host)
        {
            try
            {
                if(Extracts.Length == 0)
                    return;

                using var step = new EmitExtractReportStep(Wf, host, HostUri, Extracts, FS.path(ExtractPath.Name));
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void ParseMembers()
        {
            if(Extracts.Length == 0)
                return;

            ParsedBlocks = Parser.ParseMembers(Extracts);
            Wf.Raise(new ExtractsParsed(Host, HostUri, ParsedBlocks.Count, Ct));

            if(ParsedBlocks.Count == 0)
                return;

            EmitHostCodeBlockReport.run(Wf, HostUri, ParsedBlocks, ParsedPath, out var payload);
        }

        void DecodeMembers()
        {
            var host = EmitHostAsm.create(State.CWf.Context, HostUri);
            host.Run(Wf, ParsedBlocks, out var decoded);
            if(decoded.Count != 0)
            {
                using var match = new MatchAddressesStep(State, new MatchAddresses(), Extracts, decoded.Storage, Ct);
                match.Run();
            }
       }
    }
}