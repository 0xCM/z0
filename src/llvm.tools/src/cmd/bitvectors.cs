//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;
    using static WsAtoms;

    partial class LlvmCmd
    {
        IProjectWs LlvmData => Ws.Project("llvm.data");


        [CmdOp(".bitvectors")]
        Outcome EmitBitVectors(CmdArgs args)
        {
            var result = Outcome.Success;
            var dir = LlvmData.Tables(lists);
            var src = @readonly(dir.Files(FS.Csv));
            var dst = LlvmData.Subdir("bitvectors");
            Wf.Bitfields().EmitBitVectors(src,dst);
            return result;
        }

        [CmdOp(".bitfields")]
        Outcome EmitBitfield(CmdArgs args)
        {
            var result = Outcome.Success;
            var syms = Symbols.index<Bf1>();
            var dst = LlvmData.Subdir("bitfields");
            var model = Wf.Bitfields().EmitBitfield(syms, nameof(Bf1), dst);
            return result;
        }

        public enum Bf1 : uint
        {
            Field0 = 3,

            Field1 = 7,

            Field2 = 1,

            Field3 = 2,
        }
    }

}