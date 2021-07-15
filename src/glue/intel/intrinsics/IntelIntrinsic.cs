//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static XedModels;

    [Record(TableId)]
    public struct IntelIntrinsic : IRecord<IntelIntrinsic>
    {
        public const string TableId = "intel.intrinsics";

        public const byte FieldCount = 3;

        public string Instruction;

        public IFormType IForm;

        public string Signature;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{56,56,120};
    }
}