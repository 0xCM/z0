//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmTableSeg<T>
    {
        public T Key {get;}

        public ArraySegment<AsmRow> Content {get;}

        [MethodImpl(Inline)]
        public AsmTableSeg(T key, ArraySegment<AsmRow> data)
        {
            Key = key;
            Content = data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Content.Count;
        }
    }
}