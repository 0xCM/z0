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
        readonly MemRef[] Refs;

        [MethodImpl(Inline)]
        public static MemStore Create(params MemRef[] src) 
            => new MemStore(src);                

        [MethodImpl(Inline)]
        public static MemStore Create(MemoryAddress src, ByteSize length) 
            => Create(new MemRef(src,length));                

        public ReadOnlySpan<MemRef> Sources 
        {
            [MethodImpl(Inline)]
            get => Refs;                
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Refs.Length;
        }

        [MethodImpl(Inline)]
        public ref readonly MemRef Source(int index)
            => ref Refs[index];        
        
        /// <summary>
        /// Loads the data tracked by an index-identified memory reference
        /// </summary>
        /// <param name="index">The ref index</param>    
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load(int index)
            => Refs[index].Load();
        
        [MethodImpl(Inline)]
        MemStore(MemRef[] src)
            => Refs = src;        
    }
}