//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    public sealed partial class LlvmCmd : AppCmdService<LlvmCmd,CmdShellState>
    {
        LlvmEtlServices LlvmEtl;

        LlvmToolbase Toolbase;

        LlvmPaths LlvmPaths;

        new LlvmDb Db
        {
            get
            {
                if(_Db == null)
                    _Db = Wf.LlvmDb();
                return _Db;
            }
        }

        LlvmDb _Db;

        IProjectWs Data;

        IProjectWs Project()
            => State.Project();

        protected override void Initialized()
        {
            LlvmEtl = Wf.LlvmEtl();
            Toolbase = Wf.LLvmToolbase();
            LlvmPaths = Wf.LlvmPaths();
            Data = Ws.Project("llvm.data");
            State.Init(Wf, Ws);
            State.Project(Data);
        }

        Outcome ObjDump(FS.FilePath src, FS.FolderPath dst)
        {
            var tool = LlvmNames.Tools.llvm_objdump;
            var cmd = Cmd.cmdline(Ws.Tools().Script(tool, "run").Format(PathSeparator.BS));
            var vars = WsVars.create();
            vars.DstDir = dst;
            vars.SrcDir = src.FolderPath;
            vars.SrcFile = src.FileName;
            var result = OmniScript.Run(cmd, vars.ToCmdVars(), out var response);
            if(result)
            {
               var items = ParseCmdResponse(response);
               iter(items, item => Write(item));
            }
            return result;
        }
    }
}