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

        IAsmWorkspace AsmWs;

        ScriptRunner ScriptRunner;

        AsmShellState State;

        IApiPack ApiPack;

        NasmCatalog NasmCatalog;

        IntelSdm SdmSvc;

        AsmRegSets RegSets;

        CmdLineRunner CmdRunner;

        IntelXed Xed;

        AsmToolchain AsmToolchain;

        AsmTables AsmTables;

        AsmLoader AsmLoader;

        ApiPacks ApiPacks;

        ApiHexPacks ApiHexPacks;

        ApiPackArchive ApiArchive;

        ApiCatalogs ApiCatalogs;

        NativeBufferSeq _NativeBuffers;

        AddressMap _NativeAddressMap;

        // Index<ProcessAsmRecord> _ProcessAsm;

        // Index<ProcessAsmRecord> _ProcessAsmSelection;

        CliMemoryMap ResPack;

        IPolyrand Random;

        IWorkspace ApiWs;

        IWorkspace OutWs;

        IWorkspace LogWs;

        ProjectWs ProjectWs;

        IWorkspace DataSources;

        AsmTools AsmToolSvc;

        ShellEnv ShellEnv;

        byte[] _Assembled;

        const ushort _NativeBufferSize = Pow2.T14;

        const byte _NativeBufferCount = 4;

        public AsmCmdService()
        {
            State = new AsmShellState();
            CodeBuffer = Buffers.native(_NativeBufferSize);
            _NativeBuffers = Buffers.native(new ByteSize[_NativeBufferCount]{_NativeBufferSize,_NativeBufferSize,_NativeBufferSize,_NativeBufferSize});
            _NativeAddressMap = AddressMap.cover(_NativeBuffers);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
            ResPack = CliMemoryMap.Empty;
            ShellEnv = ShellEnv.Empty();
        }

        protected override void Initialized()
        {
            AsmWs = Ws.Asm();
            ScriptRunner = Wf.ScriptRunner();
            ApiPacks = Wf.ApiPacks();
            ApiPack = ApiPacks.Current();
            ApiArchive = ApiPack.Archive();
            NasmCatalog = Wf.NasmCatalog();
            SdmSvc = Wf.IntelSdm();
            RegSets = Wf.AsmRegSets();
            CmdRunner = Wf.CmdLineRunner();
            Xed = Wf.IntelXed();
            AsmToolchain = Wf.AsmToolchain();
            AsmTables = Wf.AsmTables();
            Random = Rng.wyhash64();
            AsmLoader = Wf.AsmLoader();
            ApiHexPacks = Wf.ApiHexPacks();
            ApiWs = Ws.Api();
            OutWs = Ws.Output();
            LogWs = Ws.Logs();
            ProjectWs = Ws.Projects();
            DataSources = Ws.Sources();
            ApiCatalogs = Wf.ApiCatalogs();
            AsmToolSvc = Wf.AsmTools();
            State.DevWs(Ws);
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

        AddressMap NativeAddressMap
        {
            [MethodImpl(Inline)]
            get => _NativeAddressMap;
        }

        [MethodImpl(Inline)]
        ref readonly NativeBufferSeq NativeBuffers()
            => ref _NativeBuffers;

        IWorkspace Imports()
            => Ws.Imports();

        IWorkspace Gen()
            => Ws.Gen();

        IWorkspace Docs()
            => Ws.Docs();

        FS.FolderPath OutDir(string id)
            => OutWs.Subdir(id);

        public FS.FolderPath OutRoot()
            => OutWs.Root;

        IWorkspace ToolWs()
            => Ws.Tools();

        FS.FilePath ToolScript(ToolId tool, string id)
            => ToolWs().Script(tool, id);

        IWorkspace TableWs()
            => Ws.Tables();

        FS.FolderPath ProjectHome(ProjectId id)
            => ProjectWs.Home(id);

        FS.Files Files(FS.Files src, bool write = true)
        {
            State.Files(src);
            if(write)
                iter(src.View, f => Write(f.ToUri()));
            return src;
        }

        void Emitted(FS.FilePath dst)
            => Write(string.Format("Emitted {0}", dst.ToUri()));

        void EmitRecords<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct
        {
            var count = Tables.emit(src, widths, dst);
            RecordsEmitted(count, dst);
        }

        void EmitAsciRecords<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct
        {
            var count = Tables.emit(src, widths, TextEncodingKind.Asci, dst);
            RecordsEmitted(count, dst);
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
            return Run(cmd, vars, out var response);
        }

        ReadOnlySpan<ProcessAsmRecord> GetProcessAsm()
        {
            if(State.ProcessAsmCount != 0)
                return State.ProcessAsm();

            var path = ApiArchive.ProcessAsmPath();
            var buffer = alloc<ProcessAsmRecord>(AsmLoader.ProcessAsmCount(path));
            Write(string.Format("Loading process asm from {0}", path.ToUri()));
            var result = AsmLoader.LoadProcessAsm(path, buffer);
            if(result.Fail)
            {
                Error(result.Message);
                return default;
            }

            var loaded = State.ProcessAsm(buffer);
            Write(string.Format("Loaded {0} process asm records from {1}", loaded.Length, path.ToUri()));
            return loaded;
        }

        void RecordsEmitted(Count count, FS.FilePath dst)
        {
            Write(string.Format("Emitted {0} records to {1}", count, dst.ToUri()));
        }
    }
}