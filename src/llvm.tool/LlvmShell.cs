//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    sealed class LlvmShell : WfApp<LlvmShell>, IToolCmdShell
    {
        IAppCmdService CmdService;

        protected override void Initialized()
        {
            var result = SelectTool(LlvmToolNames.clang_query);
            if(result.Fail)
                Error(result.Message);
            else
                Status(string.Format("Selected {0}", LlvmToolNames.clang_query));

        }

        public Outcome SelectTool(ToolId tool)
        {
            var next = default(IAppCmdService);
            switch(tool)
            {
                case LlvmToolNames.clang_query:
                    next = ClangQuery.create(Wf).With(this);
                    break;
            }

            if(next != null)
            {
                CmdService?.Dispose();
                CmdService = next;
            }
            return CmdService != null ? true : (false, string.Format("Tool {0} unknown", tool));
        }

        protected override void Disposing()
        {
            CmdService?.Dispose();
        }

        protected override void Run()
            => CmdService.Run();

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Run();
        }
    }
}