//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Windows;

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

        public AsmCmdService()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            _NativeBuffer = Buffers.native(size<Amd64Context>());
            Arbiter = AsmCmdArbiter.start(_NativeBuffer);
            _SymTypes = Z0.SymTypes.Empty;
            _Tool = ToolId.Empty;
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

        ToolBase ToolBase(string name, FS.FolderPath root)
        {
           _Toolbase.Configure(name, root);
           return _Toolbase;
        }

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
            _Toolbase = Wf.ToolBase("tools", Db.Toolsets());
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

        static Outcome argerror(string value)
            => (false, $"The argument value '{value}' is invalid");

        static CmdArg arg(in CmdArgs src, int index)
        {
            if(src.IsEmpty)
                sys.@throw("The argument list is empty");

            var count = src.Length;
            if(count < index - 1)
                sys.@throw("Argument specification error");
            return src[(ushort)index];
        }
    }
}