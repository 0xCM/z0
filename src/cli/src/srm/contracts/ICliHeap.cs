//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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