//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public enum TypeKind
        {
            None,

            Bits,

            Enum,

            Bit,

            Int,

            String,

            Dag,

            List
        }
    }
}