//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
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