//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public readonly struct dag : IDataType<dag>
        {
            public string TypeName
                => nameof(dag);

            public TypeKind TypeKind
                => TypeKind.Dag;
        }
    }
}