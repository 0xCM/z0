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
        public readonly T Key;

        public readonly ArraySegment<AsmRecord> Content;
    
        [MethodImpl(Inline)]
        public AsmTableSeg(T key, ArraySegment<AsmRecord> data)
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