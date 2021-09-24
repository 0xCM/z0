//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.IO;

    [Tool(LlvmToolNames.clang_query)]
    public sealed class ClangQuery : LlvmTool<ClangQuery>
    {
        Interpreter Controller;

        StreamWriter Writer;

        uint Sequence;

        public ClangQuery()
        {

        }

        protected override System.Action Initializer
            => Init;

        FS.FileName NextOutFile()
            => FS.file(string.Format("QueryOut{0}",Sequence++), FS.Txt);

        StreamWriter NextWriter()
        {
            if(Writer != null)
            {
                Writer.Flush();
                Writer.Dispose();
                Writer = null;
            }
            Writer = (Ws.Sources().Dataset(GetType().Name) + NextOutFile()).Writer();
            Writer.AutoFlush = true;
            return Writer;
        }

        StreamWriter CurrentWriter()
        {
            return Writer;
        }

        protected override Outcome Dispatch(string command, CmdArgs args)
        {
            var writer = NextWriter();
            var query = string.Format("{0} {1}", command, args.Format());
            writer.WriteLine(string.Format("query:{0}", query));
            return Controller.Submit(query);
        }

        void Init()
        {
            Writer = NextWriter();
            var src = FS.path(@"J:\llvm\source\llvm\include\llvm\CodeGen\ISDOpcodes.h");
            var args = string.Format("-p \"{0}\" \"{1}\"", LlvmWs.BuildRoot.Format(PathSeparator.FS), src.Format(PathSeparator.FS));
            Controller = Interpreter.create(ToolPath, args, OnStatus, OnError, OnExit);
            Controller.Start();
            Controller.Submit("set output dump");
        }

        void OnStatus(string msg)
        {
            Write(msg);
            CurrentWriter().WriteLine(msg);
        }

        void OnError(string msg)
        {
            Error(msg);
            CurrentWriter().WriteLine(msg);
        }

        void OnExit(int code)
        {
            Write(string.Format("Exit ({0})", code));
        }
    }
}