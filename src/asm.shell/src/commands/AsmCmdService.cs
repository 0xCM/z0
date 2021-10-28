//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        ByteSize CodeSize;

        Identifier RoutineName;

        IWorkspace AsmWs;

        ScriptRunner ScriptRunner;

        AsmShellState State;

        IApiPack ApiPack;

        IntelSdm Sdm;

        AsmRegSets RegSets;

        IntelXed Xed;

        AsmToolchain AsmToolchain;

        IntelIntrinsics IntelIntrinsics;

        AsmTables AsmTables;

        ApiPacks ApiPacks;

        ApiHexPacks ApiHexPacks;

        ApiPackArchive ApiArchive;

        ApiCatalogs ApiCatalogs;

        NativeBufferSeq _NativeBuffers;

        CliMemoryMap ResPack;

        IPolyrand Random;

        AsmEtl AsmEtl;

        IWorkspace OutWs;

        IProjectSet ProjectWs;

        IWorkspace DataSources;

        OmniScript OmniScript;

        TableLoaders Loaders;

        TableEmitters Emitters;

        llvm.LlvmNm LlvmNm;

        ProjectScripts ProjectScripts;

        FS.FolderPath AsmRoot
        {
            get => AsmWs.Root;
        }

        byte[] _Assembled;

        const ushort _NativeBufferSize = Pow2.T14;

        const byte _NativeBufferCount = 4;

        public AsmCmdService()
        {
            State = new AsmShellState();
            CodeBuffer = memory.native(_NativeBufferSize);
            _NativeBuffers = memory.native(new ByteSize[_NativeBufferCount]{_NativeBufferSize,_NativeBufferSize,_NativeBufferSize,_NativeBufferSize});
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
            ResPack = CliMemoryMap.Empty;
        }

        protected override void Initialized()
        {
            AsmWs = Ws.Asm();
            ApiPacks = Wf.ApiPacks();
            ApiPack = ApiPacks.Current();
            ApiArchive = ApiPack.Archive();
            Sdm = Wf.IntelSdm();
            RegSets = Wf.AsmRegSets();
            Xed = Wf.IntelXed();
            AsmToolchain = Wf.AsmToolchain();
            AsmTables = Wf.AsmTables();
            Random = Rng.wyhash64();
            ApiHexPacks = Wf.ApiHexPacks();
            OutWs = Ws.Output();
            ProjectWs = Ws.Projects();
            DataSources = Ws.Sources();
            ApiCatalogs = Wf.ApiCatalogs();
            AsmEtl = Wf.AsmEtl();
            Loaders = Wf.TableLoaders();
            Emitters = Wf.TableEmitters();
            OmniScript = Wf.OmniScript();
            IntelIntrinsics = Wf.IntelIntrinsics();
            LlvmNm = Wf.LlvmNm();
            State.Init(Wf,Ws);
            State.Project("cmodels");
            ProjectScripts = Wf.ProjectScripts();
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
            ResPack.Dispose();
        }

        protected override void Error<T>(T content)
        {
            Write(content, FlairKind.Error);
        }

        CliMemoryMap OpenResPack()
        {
            if(ResPack.IsEmpty)
                ResPack = CliMemoryMap.create(Db.Package("respack") + FS.file("z0.respack", FS.Dll));
            return ResPack;
        }

        FS.FolderPath OutDir(string id)
            => OutWs.Subdir(id);

        public FS.FolderPath OutRoot()
            => OutWs.Root;

        FS.Files Files(FS.Files src, bool write = true)
        {
            State.Files(src);
            if(write)
                iter(src.View, f => Write(f.ToUri()));
            return src;
        }

        Outcome BuildAsmExe(string id)
        {
            const string ScriptId = "build-exe";
            var result = Outcome.Success;
            var script = (AsmWs as IWorkspace).Script(ScriptId);
            var vars = Cmd.vars(
                ("SrcId", id)
                );
            var cmd = Cmd.cmdline(script.Format(PathSeparator.BS));
            return OmniScript.Run(cmd, vars, out var response);
        }
    }
}