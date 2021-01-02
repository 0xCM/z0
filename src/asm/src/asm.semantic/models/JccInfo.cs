//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct JccInfo : IRecord<JccInfo>
    {
        public const string TableId = "asm.jcc";

        public OpCodeId Code;

        public ConditionCode ConditionCode;

        public bool IsJccNear;

        public bool IsJccShort;
    }
}