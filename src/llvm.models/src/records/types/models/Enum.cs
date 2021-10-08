//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public readonly struct Enum : IDataType<Enum>
        {
            public readonly CharBlock32 EnumType;

            public Enum(string et)
            {
                EnumType = et;
            }

            public string TypeName
                => string.Format("enum<{0}>", EnumType);

            public TypeKind TypeKind
                => TypeKind.Enum;
        }
    }
}