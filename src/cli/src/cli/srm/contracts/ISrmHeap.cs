//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class SRM
    {
        public interface ISrmHeap
        {
            MemoryBlock Block {get;}

            CliHeapKind HeapKind {get;}
        }

        public interface ISrmHeap<T> : ISrmHeap
            where T : struct, ISrmHeap<T>
        {

        }
    }
}