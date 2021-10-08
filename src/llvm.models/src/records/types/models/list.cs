//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RecordDataTypes
    {
        public readonly struct list : IDataType<list>
        {
            public readonly CharBlock32 ElementType;

            [MethodImpl(Inline)]
            public list(string et)
            {
                ElementType = et;
            }

            public string TypeName
                => string.Format("list<{0}>", ElementType);

            public TypeKind TypeKind
                => TypeKind.List;
        }
    }
}