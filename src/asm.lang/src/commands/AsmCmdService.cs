//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Windows;

    using static IntelSdm;
    using static Root;
    using static core;

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        const string xed = nameof(xed);

        NativeBuffer CodeBuffer;

        NativeBuffer _NativeBuffer;

        AsmCmdArbiter Arbiter;

        AsmWorkspace Workspace;

        SymTypes _SymTypes;

        ToolBase _Toolbase;

        ToolId _Tool;

        ScriptRunner ScriptRunner;

        ByteSize _NativeSize;

        public AsmCmdService()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            _NativeBuffer = Buffers.native(size<Amd64Context>());
            Arbiter = AsmCmdArbiter.start(_NativeBuffer);
            _SymTypes = Z0.SymTypes.Empty;
            _Tool = ToolId.Empty;
            _NativeSize = 0;
        }

        ToolBase ToolBase()
            => _Toolbase;

        ToolId Tool()
            => _Tool;

        ToolId SelectTool(ToolId id)
        {
            _Tool = id;
            return _Tool;
        }

        ToolId SelectedTool()
            => _Tool;

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
            _Toolbase = Wf.ToolBase(Db.ToolWs());
            ScriptRunner = Wf.ScriptRunner();
        }

        protected override void Disposing()
        {
            Arbiter.Dispose();
            CodeBuffer.Dispose();
            _NativeBuffer.Dispose();
        }

        SymTypes SymTypes
        {
            get
            {
                if(_SymTypes.IsEmpty)
                    _SymTypes = Clr.symtypes(ApiRuntimeLoader.assemblies());
                return _SymTypes;
            }
        }

        Span<byte> NativeBuffer(bool clear)
        {
            if(clear)
                _NativeBuffer.Clear();
            return _NativeBuffer.Edit;
        }

        Outcome NativeLoad(ReadOnlySpan<byte> src)
        {
            var size = src.Length;
            var buffer = NativeBuffer(true);
            if(size > buffer.Length)
                return (false,CapacityExceeded.Format());
            for(var i=0; i<size; i++)
                seek(buffer,i) = skip(src,i);
            return true;
        }

        Outcome RunScript(FS.FilePath src, out ReadOnlySpan<TextLine> response)
        {
            var result = Outcome.Success;

            void OnError(Exception e)
            {
                result = e;
            }

            var cmd = Cmd.cmdline(src.Format(PathSeparator.BS));
            response = ScriptRunner.RunCmd(cmd, OnError);
            return result;
        }

        Outcome RunTool(CmdArgs args, Func<ToolId,CmdArgs,Outcome> f)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());
            else
                return f(tool, args);
        }

        ref readonly Table Pipe(in Table src)
        {
            var msg = string.Format("Dispatching {0} {1} rows", src.RowCount, src.Kind);
            Status(msg);
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

        static Outcome argerror(string value)
            => (false, $"The argument value '{value}' is invalid");

        static CmdArg arg(in CmdArgs src, int index)
        {
            if(src.IsEmpty)
                sys.@throw(EmptyArgList.Format());

            var count = src.Length;
            if(count < index - 1)
                sys.@throw(ArgSpecError.Format());
            return src[(ushort)index];
        }

        static MsgPattern NoToolSelected => "No tool selected";

        static MsgPattern EmptyArgList => "No arguments specified";

        static MsgPattern ArgSpecError => "Argument specification error";

        static MsgPattern CapacityExceeded => "Capacity exceeded";
    }
}