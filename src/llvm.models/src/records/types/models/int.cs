//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public readonly struct @int : IDataType<@int>
        {
            public string TypeName
                => "int";

            public TypeKind TypeKind
                => TypeKind.Int;
        }
    }
}