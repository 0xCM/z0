//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ImageRecords
    {
        public interface IHeapKey
        {
            HeapKind HeapKind {get;}

            uint Value {get;}
        }

        public interface IHeapKey<K> : IHeapKey
            where K : struct, IHeapKey<K>
        {

        }
    }
}