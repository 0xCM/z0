//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

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

        DevWs DevWs;

        public AsmCmdService()
        {
            State = new ShellState();
            CodeBuffer = Buffers.native(Pow2.T14);
            RoutineName = Identifier.Empty;
            CodeSize = 0;
            _Assembled = array<byte>();
        }

        protected override void Initialized()
        {
            DevWs = Wf.DevWs();
            AsmWs = DevWs.Asm();
            ScriptRunner = Wf.ScriptRunner();
            ApiPack = Wf.ApiPacks().Current();
            State.DevWs(DevWs);
        }

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
        }

        Workspace WsDefine(Scope scope)
            => new Workspace(Wf.Env.DevWs + FS.folder(scope.Name));

        IWorkspace ImportWs()
            => DevWs.Imports();

        IWorkspace GenWs()
            => DevWs.Gen();

        IWorkspace OutWs()
            => DevWs.Output();

        IWorkspace LogWs()
            => DevWs.Logs();

        ToolWs Tools()
            => DevWs.Tools();

        TableWs TableWs()
            => DevWs.Tables();

        IWorkspace Sources()
            => DevWs.Sources();

        ProjectWs Projects()
            => DevWs.Projects();

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

        ref readonly Table Pipe(in Table src)
        {
            return ref src;
        }

        ref readonly FS.FilePath Pipe(in FS.FilePath src)
        {
            Write(string.Format("Path:{0}",src));
            return ref src;
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

        static MsgPattern NoToolSelected => "No tool selected";

        static MsgPattern CapacityExceeded => "Capacity exceeded";

        static MsgPattern ToolUnspecified => "Tool unspecified";

        static MsgPattern<ToolId> UndefinedTool => "Undefined tool:{0}";

        static MsgPattern<ProjectId> UndefinedProject => "Undefined project:{0}";
    }
}