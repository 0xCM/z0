//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    
    [ApiHost]
    public readonly partial struct MemoryStore
    {        
        [MethodImpl(Inline)]
        internal static MemoryStore Service(MemoryRef[] src) 
            => new MemoryStore(src);
                
        readonly MemoryRef[] Refs;                
        
        public ReadOnlySpan<MemoryRef> Sources 
        {
            [MethodImpl(Inline), Op]
            get => Refs;                
        }
        
        [MethodImpl(Inline), Op]
        MemoryStore(MemoryRef[] src)
        {
            Refs = src;

        }        
            
        static MemoryBlocks Blocks => MemoryBlocks.Service;

        static SpanReader Reader => SpanReader.Service;
    }
}