//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public readonly struct bit : IDataType<bit>
        {
            public string TypeName
                => nameof(bit);

            public TypeKind TypeKind
                => TypeKind.Bit;
        }
    }
}