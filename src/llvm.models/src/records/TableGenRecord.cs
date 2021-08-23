//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public struct TableGenRecord
    {
        public string EntityName;

        public Index<TextLine> Lines;

        public Index<RecordField> Fields;
    }
}