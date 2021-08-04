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

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        ByteSize CodeSize;

        Identifier RoutineName;

        AsmWs AsmWs;

        ScriptRunner ScriptRunner;

        ShellState State;

        IApiPack ApiPack;

        DevWs Ws;

        NasmCatalog NasmCatalog;

        IntelSdm SdmProcessor;

        AsmRegSets RegSets;

        AsmEnv AsmEnv;

        CmdLineRunner CmdRunner;

        IntelXed Xed;

        AsmToolchain AsmToolchain;

        AsmTables AsmTables;

        ApiPacks ApiPacks;

        NativeBufferSeq _NativeBuffers;

        AddressMap _NativeAddressMap;

        Index<ProcessAsm> _AsmGlobals;

        Index<ProcessAsm> _AsmGlobalSelection;

        byte[] _Assembled;


        const ushort _NativeBufferSize = Pow2.T14;

        const byte _NativeBufferCount = 4;

        const uint _AsmGlobalCapacity = 720000;

        uint _AsmGlobalCount;

        public AsmCmdService()
        {
            State = new ShellState();
            CodeBuffer = Buffers.native(_NativeBufferSize);
            _NativeBuffers = Buffers.native(new ByteSize[_NativeBufferCount]{_NativeBufferSize,_NativeBufferSize,_NativeBufferSize,_NativeBufferSize});
            _NativeAddressMap = AddressMap.cover(_NativeBuffers);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
            _AsmGlobals = Index<ProcessAsm>.Empty;
            _AsmGlobalSelection = Index<ProcessAsm>.Empty;
        }


        protected override void Initialized()
        {
            Ws = Wf.DevWs();
            AsmWs = Ws.Asm();
            ScriptRunner = Wf.ScriptRunner();
            ApiPacks = Wf.ApiPacks();
            ApiPack = ApiPacks.Current();
            NasmCatalog = Wf.NasmCatalog();
            SdmProcessor = Wf.IntelSdm();
            RegSets = Wf.AsmRegSets();
            AsmEnv = Wf.AsmEnv();
            CmdRunner = Wf.CmdLineRunner();
            Xed = Wf.IntelXed();
            AsmToolchain = Wf.AsmToolchain();
            AsmTables = Wf.AsmTables();
            State.DevWs(Ws);

        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
        }

        AddressMap NativeAddressMap
        {
            [MethodImpl(Inline)]
            get => _NativeAddressMap;
        }

        [MethodImpl(Inline)]
        uint AsmGlobalCount()
            => _AsmGlobalCount;

        [MethodImpl(Inline)]
        void AsmGlobalCount(uint count)
        {
            _AsmGlobalCount = min(count, _AsmGlobalCapacity);
        }

        Span<ProcessAsm> AsmGlobals()
        {
            if(_AsmGlobals.IsEmpty)
            {
                _AsmGlobals = alloc<ProcessAsm>(_AsmGlobalCapacity);
            }
            return _AsmGlobals;
        }

        [MethodImpl(Inline)]
        ref readonly NativeBufferSeq NativeBuffers()
            => ref _NativeBuffers;

        void WriteSyms<K>(Symbols<K> src)
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
        }

        IWorkspace Imports()
            => Ws.Imports();

        IWorkspace Gen()
            => Ws.Gen();

        IWorkspace OutWs()
            => Ws.Output();

        FS.FolderPath OutDir(string id)
            => OutWs().Subdir(id);

        public FS.FolderPath OutRoot()
            => OutWs().Root;

        IWorkspace LogWs()
            => Ws.Logs();

        IToolWs ToolWs()
            => Ws.Tools();

        IWorkspace TableWs()
            => Ws.Tables();

        IWorkspace Sources()
            => Ws.Sources();

        ProjectWs Projects()
            => Ws.Projects();

        FS.FolderPath ProjectHome(ProjectId id)
            => Projects().Home(id);

        FS.Files Files(FS.FileExt ext)
            => State.Files().Where(f => f.Is(ext));

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

        Outcome Run(CmdLine cmd, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(cmd, vars, ReceiveCmdStatus, ReceiveCmdError,  out response);

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

        void EmitTokens(ITokenSet src)
        {
            var dst = Ws.Output().Table<SymToken>(queries, src.Name);
            var tokens = Symbols.tokens(src.Types());
            EmitRecords(tokens, SymToken.RenderWidths, dst);
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
            var count = Tables.emit(src, dst, widths);
            RecordsEmitted(count, dst);
        }

        uint QueryOut<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, string id)
            where T : struct
        {
            var dst = OutWs().QueryOut(id, FS.Csv);
            return EmitRows(src, widths, dst);
        }

        [MethodImpl(Inline)]
        Span<ProcessAsm> AsmGlobalSelection()
            => _AsmGlobalSelection.Edit;

        Outcome LoadAsmGlobal(out ReadOnlySpan<ProcessAsm> dst)
        {
            var result = Outcome.Success;
            var count = AsmGlobalCount();
            if(count != 0)
            {
                dst = AsmGlobals();
                return result;
            }
            var archive = ApiPacks.Archive();
            var path = archive.ProcessAsmPath();
            var buffer = AsmGlobals();
            Write(string.Format("Loading global asm from {0}", path.ToUri()));
            count = AsmEtl.LoadProcessAsm(path, buffer);
            AsmGlobalCount(count);
            dst = buffer;
            _AsmGlobalSelection = alloc<ProcessAsm>(count);
            Write(string.Format("Loaded {0} global asm records from {1}", count, path.ToUri()));
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