//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public sealed partial class LlvmCmd : AppCmdService<LlvmCmd>
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

        IProjectWs _Project;

        IProjectWs Project()
            => _Project;

        IProjectWs Project(string id)
        {
            _Project = Ws.Project(id);
            return Project();
        }

        protected override void Initialized()
        {
            LlvmEtl = Wf.LlvmEtl();
            Toolbase = Wf.LLvmToolbase();
            LlvmPaths = Wf.LlvmPaths();
            _Project = Ws.Project("llvm.data");
        }
    }
}