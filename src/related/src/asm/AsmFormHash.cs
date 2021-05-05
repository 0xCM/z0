//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using Z0.Asm;

    partial struct AsmRecords
    {
        [Record(TableId)]
        public struct AsmFormHash : IRecord<AsmFormHash>
        {
            public const string TableId = "asm.forms.hashed";

            public Hex32 HashCode;

            public uint IndexKey;

            public AsmFormExpr Form;
        }
    }
}