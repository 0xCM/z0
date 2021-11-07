//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".repo/headers")]
        Outcome LlvmHeaders(CmdArgs args)
            => Flow(LlvmRepo.Files(FS.H).ToUri());

        [CmdOp(".repo/cpp")]
        Outcome LlvmCpp(CmdArgs args)
            => Flow(LlvmRepo.Files(FS.Cpp).ToUri());

        [CmdOp(".repo/defs")]
        Outcome LlvmDefs(CmdArgs args)
            => Flow(LlvmRepo.Files(FS.Def).ToUri());

        [CmdOp(".repo/inc")]
        Outcome LlvmInc(CmdArgs args)
            => Flow(LlvmRepo.Files(FS.Inc).ToUri());

        [CmdOp(".repo/table-defs")]
        Outcome LlvmTableDefs(CmdArgs args)
            => Flow(LlvmRepo.Files(FS.Td).ToUri());

        [CmdOp(".repo/build/headers")]
        Outcome LLvmBuildHeaders(CmdArgs args)
            => Flow(LlvmRepo.BuildOutput(FS.H).ToUri());

        [CmdOp(".repo/build/exe")]
        Outcome LLvmBuildTargets(CmdArgs args)
            => Flow(LlvmRepo.BuildOutput(FS.Exe).ToUri());

        [CmdOp(".repo/build/lib")]
        Outcome LLvmBuildLibs(CmdArgs args)
            => Flow(LlvmRepo.BuildOutput(FS.Lib).ToUri());

        [CmdOp(".repo/build/obj")]
        Outcome LLvmBuildObj(CmdArgs args)
            => Flow(LlvmRepo.BuildOutput(FS.Obj).ToUri());

        [CmdOp(".repo/build/inc")]
        Outcome LLvmBuildInc(CmdArgs args)
            => Flow(LlvmRepo.BuildOutput(FS.Inc).ToUri());

    }
}