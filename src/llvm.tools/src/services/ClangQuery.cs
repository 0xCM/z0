//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using System;
    using System.IO;

    [Tool(LlvmNames.Tools.clang_query)]
    public sealed class ClangQuery : LlvmTool<ClangQuery>
    {
        Interpreter Controller;

        FS.FilePath QueryFile;

        StreamWriter QueryWriter;

        uint Sequence;

        uint Counter;


        public ClangQuery()
        {
            Counter = 0;
        }

        protected override System.Action Initializer
            => SelectSource;

        FS.FilePath NextOutFile()
            => Ws.Project("llvm.data").OutDir(Id.Format()) + FS.file(string.Format("QueryOut{0}", Sequence++), FS.ext("tree"));

        void CloseQuery()
        {
            if(QueryWriter != null)
            {
                QueryWriter.Flush();
                QueryWriter.Dispose();
                QueryWriter = null;
            }
        }

        void QueryBegin()
        {
            CloseQuery();
            QueryFile = NextOutFile();
            QueryWriter = (QueryFile).Writer();
            QueryWriter.AutoFlush = true;
            Write(string.Format("Sending query output to {0}", QueryFile.ToUri()));
        }

        protected override Outcome Dispatch(string command, CmdArgs args)
        {
            QueryBegin();
            var query = string.Format("{0} {1}", command, args.Format());
            QueryWriter.WriteLine(string.Format("query:{0}", query));
            return Controller.Submit(query);
        }

        void SelectSource()
        {
            QueryBegin();
            var src = FS.path(@"J:\llvm\source\llvm\lib\Target\X86\X86InstrInfo.cpp");
            var args = string.Format("-p \"{0}\" \"{1}\"", LlvmWs.BuildRoot.Format(PathSeparator.FS), src.Format(PathSeparator.FS));
            Controller = Interpreter.create(ToolPath, args, OnStatus, OnError, OnExit);
            Controller.Start();
            Controller.Submit("set output dump");
        }

        void OnStatus(string msg)
        {
            QueryWriter.WriteLine(msg);
            if(msg.EndsWith(" matches."))
            {
                Write(msg);
            }
        }

        void OnError(string msg)
        {
            Write(msg);
        }

        void OnExit(int code)
        {
            Write(string.Format("Exit ({0})", code));
        }
    }
}