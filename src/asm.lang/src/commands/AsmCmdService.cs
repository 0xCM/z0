//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Windows;

    using static Root;
    using static core;

    public sealed partial class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        NativeBuffer ContextBuffer;

        AsmCmdArbiter Arbiter;

        AsmWorkspace Workspace;

        SymTypes _SymTypes;

        public AsmCmdService()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            ContextBuffer = Buffers.native(size<Amd64Context>());
            Arbiter = AsmCmdArbiter.start(ContextBuffer);
            _SymTypes = Z0.SymTypes.Empty;
        }

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
        }

        protected override void Disposing()
        {
            Arbiter.Dispose();
            CodeBuffer.Dispose();
            ContextBuffer.Dispose();
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