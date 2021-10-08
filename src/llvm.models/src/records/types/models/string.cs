//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public readonly struct @string : IDataType<@string>
        {
            public string TypeName
                => "string";

            public TypeKind TypeKind
                => TypeKind.String;
        }
    }
}