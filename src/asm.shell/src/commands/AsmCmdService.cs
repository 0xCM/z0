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
    using static WsAtoms;

    public class AsmShellState : ShellState
    {
        Index<SdmOpCodeRecord> _OpCodes;

        public AsmShellState()
        {
            _OpCodes = array<SdmOpCodeRecord>();
        }

        [MethodImpl(Inline)]
        public void OpCodes(SdmOpCodeRecord[] src)
        {
            _OpCodes = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<SdmOpCodeRecord> OpCodes()
            => _OpCodes.View;
    }

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        ByteSize CodeSize;

        Identifier RoutineName;

        DevWs Ws;

        AsmWs AsmWs;

        ScriptRunner ScriptRunner;

        AsmShellState State;

        IApiPack ApiPack;

        NasmCatalog NasmCatalog;

        IntelSdm SdmSvc;

        AsmRegSets RegSets;

        AsmEnv AsmEnv;

        CmdLineRunner CmdRunner;

        IntelXed Xed;

        AsmToolchain AsmToolchain;

        AsmTables AsmTables;

        AsmLoader AsmLoader;

        ApiPacks ApiPacks;

        ApiHexPacks HexPacks;

        ApiPackArchive ApiArchive;

        NativeBufferSeq _NativeBuffers;

        AddressMap _NativeAddressMap;

        Index<ProcessAsm> _ProcessAsm;

        Index<ProcessAsm> _AsmGlobalSelection;

        CliMemoryMap ResPack;

        IPolyrand Random;

        IWorkspace ApiWs;

        IWorkspace OutWs;

        IWorkspace LogWs;

        ProjectWs ProjectWs;

        IWorkspace DataSources;

        byte[] _Assembled;

        const ushort _NativeBufferSize = Pow2.T14;

        const byte _NativeBufferCount = 4;

        const uint _ProcessAsmCapacity = 720000;

        uint _AsmGlobalCount;

        public AsmCmdService()
        {
            State = new AsmShellState();
            CodeBuffer = Buffers.native(_NativeBufferSize);
            _NativeBuffers = Buffers.native(new ByteSize[_NativeBufferCount]{_NativeBufferSize,_NativeBufferSize,_NativeBufferSize,_NativeBufferSize});
            _NativeAddressMap = AddressMap.cover(_NativeBuffers);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
            _ProcessAsm = Index<ProcessAsm>.Empty;
            _AsmGlobalSelection = Index<ProcessAsm>.Empty;
            ResPack = CliMemoryMap.Empty;
        }

        protected override void Initialized()
        {
            Ws = Wf.DevWs();
            AsmWs = Ws.Asm();
            ScriptRunner = Wf.ScriptRunner();
            ApiPacks = Wf.ApiPacks();
            ApiPack = ApiPacks.Current();
            NasmCatalog = Wf.NasmCatalog();
            SdmSvc = Wf.IntelSdm();
            RegSets = Wf.AsmRegSets();
            AsmEnv = Wf.AsmEnv();
            CmdRunner = Wf.CmdLineRunner();
            Xed = Wf.IntelXed();
            AsmToolchain = Wf.AsmToolchain();
            AsmTables = Wf.AsmTables();
            Random = Rng.wyhash64();
            ApiArchive = ApiPack.Archive();
            AsmLoader = Wf.AsmLoader();
            HexPacks = Wf.ApiHexPacks();
            ApiWs = Ws.Api();
            OutWs = Ws.Output();
            LogWs = Ws.Logs();
            ProjectWs = Ws.Projects();
            DataSources = Ws.Sources();
            State.DevWs(Ws);
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
            ResPack.Dispose();
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
        uint ProcessAsmCount()
            => _AsmGlobalCount;

        [MethodImpl(Inline)]
        void ProcessAsmCount(uint count)
        {
            _AsmGlobalCount = min(count, _ProcessAsmCapacity);
        }

        Span<ProcessAsm> ProcessAsm()
        {
            if(_ProcessAsm.IsEmpty)
                _ProcessAsm = alloc<ProcessAsm>(_ProcessAsmCapacity);
            return _ProcessAsm;
        }

        [MethodImpl(Inline)]
        ref readonly NativeBufferSeq NativeBuffers()
            => ref _NativeBuffers;

        Outcome WriteSyms<K>(Symbols<K> src)
            where K : unmanaged
        {
            const string Pattern1 = "{0,-4} {1}";
            const string Pattern2 = "{0,-4} {1}('{2}')";
            var count = src.Length;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(view,i);
                var key = symbol.Key;
                var name = symbol.Name.Format();
                var expr = symbol.Expr.Format();
                if(name.Equals(expr))
                    Write(string.Format(Pattern1, key, expr));
                else
                    Write(string.Format(Pattern2, key, name, expr));
            }
            return true;
        }

        IWorkspace Imports()
            => Ws.Imports();

        IWorkspace Gen()
            => Ws.Gen();

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

        FS.Files Files()
            => State.Files();

        FS.Files Files(FS.FileExt ext)
            => State.Files().Where(f => f.Is(ext));

        FS.Files Files(FS.FileExt a, FS.FileExt b)
            => State.Files().Where(f => f.Is(a) || f.Is(b));

        FS.Files Files(FS.FileExt a, FS.FileExt b, FS.FileExt c)
            => State.Files().Where(f => f.Is(a) || f.Is(b) || f.Is(c));

        FS.Files Files(FS.FileExt a, FS.FileExt b, FS.FileExt c, FS.FileExt d)
            => State.Files().Where(f => f.Is(a) || f.Is(b) || f.Is(c) || f.Is(d));

        FS.FilePath TablePath<T>()
            where T : struct
                => TableWs().Table<T>(FS.Csv);

        FS.FilePath TablePath<T>(Scope scope)
            where T : struct
                => TableWs().Table<T>(scope);

        FS.FilePath TablePath<T>(Scope scope, string suffix)
            where T : struct
                => TableWs().Table<T>(scope, suffix);

        FS.Files Files(FS.Files src, bool write = true)
        {
            State.Files(src);
            if(write)
                iter(src.View, f => Write(f));
            return src;
        }

        void ReceiveCmdStatus(in string src)
        {

        }

        void ReceiveCmdError(in string src)
        {
            Error(src);
        }

        void ParseCmdResponse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            if(count == 0)
                Warn("No response to parse");

            for(var i=0; i<count; i++)
            {
                if(CmdResponse.parse(skip(src,i).Content, out var response))
                    Write(response);
            }
        }

        Outcome Run(CmdLine cmd, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(cmd, vars, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(ToolScript spec, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(spec, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome RunWinCmd(string spec, out ReadOnlySpan<TextLine> response)
            => CmdRunner.Run(WinCmd.cmd(spec), out response);

        Outcome RunScript(FS.FilePath src, out ReadOnlySpan<TextLine> response)
        {
            var result = Outcome.Success;

            void OnError(Exception e)
            {
                result = e;
                Error(e);
            }

            var cmd = Cmd.cmdline(src.Format(PathSeparator.BS));
            response = ScriptRunner.RunCmd(cmd, OnError);
            return result;
        }

        Outcome ToolOutDir(CmdArgs args, out FS.FolderPath dir)
        {
            dir = FS.FolderPath.Empty;
            if(args.Length == 0)
                return (false, ToolUnspecified.Format());

            var id = arg(args,0).Value;
            dir = OutRoot() + FS.folder(id);
            return true;
        }

        Outcome LoadOpcodes()
        {
            var result = Outcome.Success;
            var srcpath = TableWs().Table<SdmOpCodeRecord>();
            var lines = srcpath.ReadLines().View;
            result = TextGrids.load(lines, out var grid);
            if(result.Fail)
                return result;
            var count = grid.RowCount;

            var dst = alloc<SdmOpCodeRecord>(count);
            result = AsmParser.parse(grid,dst);
            if(result.Fail)
                return result;

            State.OpCodes(dst);

            return result;
        }

        void EmitTokens(ITokenSet src)
        {
            var dst = Ws.Output().Table<SymToken>(queries, src.Name);
            var tokens = Symbols.tokens(src.Types());
            EmitRecords(tokens, SymToken.RenderWidths, dst);
            var count = tokens.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref skip(tokens,i);
                Write(string.Format("{0,-16}: {1,-14} - {2}", token.TokenType.Format().Replace("Token", EmptyString), token.Expr, token.Description));
            }
        }

        FS.FolderPath ToolOutDir(ToolId tool)
            => Ws.Output().Subdir(tool.Format());

        FS.FolderPath ToolOutDir(CmdArgs args, ToolId tool)
            => args.Length > 0 ? OutRoot() + FS.folder(arg(args,0).Value) : ToolOutDir(tool);

        void Write<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths)
            where T : struct
        {
            var formatter = Tables.formatter<T>(widths);
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                Write(formatter.Format(record));
            }
        }

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

        uint QueryOut<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, string id)
            where T : struct
        {
            var dst = OutWs.QueryOut(id, FS.Csv);
            return TableEmit(src, widths, dst);
        }

        [MethodImpl(Inline)]
        Span<ProcessAsm> AsmGlobalSelection()
            => _AsmGlobalSelection.Edit;

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

        Outcome LoadProcessAsm(out ReadOnlySpan<ProcessAsm> dst)
        {
            if(ProcessAsmCount() != 0)
            {
                dst = ProcessAsm();
                return true;
            }
            dst = default;
            var path = ApiPacks.Archive().ProcessAsmPath();
            var buffer = ProcessAsm();
            Write(string.Format("Loading process asm from {0}", path.ToUri()));
            var result = AsmLoader.LoadProcessAsm(path, buffer);
            if(result.Fail)
                return result;

            var count = result.Data;
            ProcessAsmCount(count);
            dst = buffer;
            _AsmGlobalSelection = alloc<ProcessAsm>(count);
            Write(string.Format("Loaded {0} process asm records from {1}", count, path.ToUri()));
            return result;
        }

        void RecordsEmitted(Count count, FS.FilePath dst)
        {
            Write(string.Format("Emitted {0} records to {1}", count, dst.ToUri()));
        }

        static MsgPattern CapacityExceeded => "Capacity exceeded";

        static MsgPattern ToolUnspecified => "Tool unspecified";

        static MsgPattern<ToolId> UndefinedTool => "Undefined tool:{0}";

        static MsgPattern<ProjectId> UndefinedProject => "Undefined project:{0}";

        static MsgPattern<Count,FS.FileUri> EmittedQueryResults => "Directed {0} query result rows to {1}";
    }
}