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

    public ref struct EmitCaptureArtifactsStep
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly ApiMemberExtract[] Extracts;

        readonly ApiHostUri HostUri;

        readonly IHostCapturePaths Target;

        readonly IExtractParser Parser;

        public ApiMemberCodeBlocks ParsedMembers;

        readonly FilePath ExtractPath;

        readonly FS.FilePath ParsedPath;

        readonly FS.FilePath CilDataPath;

        readonly FS.FilePath AsmPath;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitCaptureArtifactsStep(IWfCaptureState state, WfHost host, ApiHostUri src, ApiMemberExtract[] extracts, IPartCapturePaths dst)
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
                Run(new EmitExtractReport());
                Run(new EmitParsedReportHost());
                EmitApiCodeBlocks.create(HostUri, ParsedMembers).Run(Wf);
                Run(new EmitCilMembersHost());
                DecodeMembers();
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host);
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
                var cil = ApiDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                dst.WriteLine(cil.Format());
            }

            Wf.Raise(new CilDataSaved(Host, HostUri, src.Length, CilDataPath, Ct));
        }

        void SaveDecoded(AsmRoutine[] src, FS.FilePath dst)
        {
            using var writer = State.CWf.Context.AsmWriter(FS.path(dst.Name));
            writer.WriteAsm(src);
        }

        void DecodeMembers()
        {
            var host = DecodeApiMembers.create(State.CWf.Context, HostUri);
            var decoded = host.Run(Wf, ParsedMembers, out var _).Storage;
            if(decoded.Length != 0)
            {
                SaveDecoded(decoded, AsmPath);
                Wf.Status(Host, text.format(RP.PSx3, decoded.Length,HostUri.Format(), AsmPath.ToUri()));

                using var match = new MatchAddressesStep(State, new MatchAddresses(), Extracts, decoded, Ct);
                match.Run();
            }
        }
    }
}