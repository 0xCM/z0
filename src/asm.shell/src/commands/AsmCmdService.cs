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

        byte[] _Assembled;

        ShellState State;

        IApiPack ApiPack;

        DevWs Ws;

        NasmCatalog NasmCatalog;

        IntelSdm SdmProcessor;

        AsmRegSets RegSets;

        AsmEnv AsmEnv;

        CmdLineRunner CmdRunner;

        NativeBufferSeq _Buffers;

        AddressMap _AddressMap;

        IntelXed Xed;

        AsmToolchain AsmToolchain;

        AsmTables AsmTables;

        const ushort BufferSize = Pow2.T14;

        const byte BufferCount = 4;

        public AsmCmdService()
        {
            State = new ShellState();
            CodeBuffer = Buffers.native(BufferSize);
            _Buffers = Buffers.native(new ByteSize[BufferCount]{BufferSize,BufferSize,BufferSize,BufferSize});
            _AddressMap = AddressMap.cover(_Buffers);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
        }

        AddressMap AddressMap
        {
            [MethodImpl(Inline)]
            get => _AddressMap;
        }


        [MethodImpl(Inline)]
        ref readonly NativeBufferSeq Memory()
            => ref _Buffers;

        protected override void Initialized()
        {
            Ws = Wf.DevWs();
            AsmWs = Ws.Asm();
            ScriptRunner = Wf.ScriptRunner();
            ApiPack = Wf.ApiPacks().Current();
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

        Workspace WsDefine(Scope scope)
            => new Workspace(Wf.Env.DevWs + FS.folder(scope.Name));

        IWorkspace ImportWs()
            => Ws.Imports();

        IWorkspace GenWs()
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

        void EmitRecords<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct
        {
            var count = Tables.emit(src, dst, widths);
            RecordsEmitted(count, dst);
        }

        void RecordsEmitted(Count count, FS.FilePath dst)
        {
            Write(string.Format("Emitted {0} records to {1}", count, dst.ToUri()));
        }

        static MsgPattern NoToolSelected => "No tool selected";

        static MsgPattern CapacityExceeded => "Capacity exceeded";

        static MsgPattern ToolUnspecified => "Tool unspecified";

        static MsgPattern<ToolId> UndefinedTool => "Undefined tool:{0}";

        static MsgPattern<ProjectId> UndefinedProject => "Undefined project:{0}";

        static MsgPattern<Count,FS.FileUri> EmittedQueryResults => "Directed {0} query result rows to {1}";
    }
}