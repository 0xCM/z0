//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    
    public readonly struct MemStore
    {        
        readonly MemoryRef[] Refs;

        [MethodImpl(Inline)]
        public static MemStore Service(MemoryRef[] src) 
            => new MemStore(src);                
        
        public ReadOnlySpan<MemoryRef> Sources 
        {
            [MethodImpl(Inline), Op]
            get => Refs;                
        }
        
        [MethodImpl(Inline), Op]
        MemStore(MemoryRef[] src)
            => Refs = src;
    }
}