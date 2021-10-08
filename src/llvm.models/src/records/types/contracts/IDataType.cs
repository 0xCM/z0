//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct RecordDataTypes
    {
        public interface IDataType<T>
            where T : unmanaged, IDataType<T>
        {
            string TypeName {get;}

            TypeKind TypeKind {get;}
        }
    }
}