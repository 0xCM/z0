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

        AsmWs AsmWs;

        ScriptRunner ScriptRunner;

        byte[] _Assembled;

        ShellState State;

        IApiPack ApiPack;

        DevWs Ws;

        NasmCatalog NasmCatalog;

        IntelSdmProcessor SdmProcessor;

        AsmRegSets RegSets;

        AsmEnv AsmEnv;

        CmdLineRunner CmdRunner;

        NativeBufferSeq _Buffers;

        AddressMap _AddressMap;

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
            SdmProcessor = Wf.IntelSdmProcessor();
            RegSets = Wf.AsmRegSets();
            AsmEnv = Wf.AsmEnv();
            CmdRunner = Wf.CmdLineRunner();
            State.DevWs(Ws);
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
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

        Outcome RunTool(CmdArgs args, Func<ToolId,CmdArgs,Outcome> f)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : State.Tool();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());
            else
                return f(tool, args);
        }

        ref readonly ReadOnlySpan<T> Pipe<T>(in ReadOnlySpan<T> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                Write(input.ToString());
            }
            return ref src;
        }

        Outcome RunWinCmd(string spec, out ReadOnlySpan<TextLine> dst)
            => CmdRunner.Run(WinCmd.cmd(spec), out dst);

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

        FS.FolderPath ToolOutDir(ToolId tool)
            => Ws.Output().Subdir(tool.Format());

        FS.FolderPath ToolOutDir(CmdArgs args, ToolId tool)
            => args.Length > 0 ? OutRoot() + FS.folder(arg(args,0).Value) : ToolOutDir(tool);

        static MsgPattern NoToolSelected => "No tool selected";

        static MsgPattern CapacityExceeded => "Capacity exceeded";

        static MsgPattern ToolUnspecified => "Tool unspecified";

        static MsgPattern<ToolId> UndefinedTool => "Undefined tool:{0}";

        static MsgPattern<ProjectId> UndefinedProject => "Undefined project:{0}";

        static MsgPattern<Count,FS.FileUri> EmittedQueryResults => "Directed {0} query result rows to {1}";
    }
}