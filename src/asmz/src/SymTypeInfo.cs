//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct SymTypeInfo
    {
        public const string TableId = "symtype";

        public Identifier TypeName;

        public PrimalCode DataType;

        public ushort SymCount;

        public ushort TypeNameSize;

        public BinaryCode TypeNameData;
    }
}