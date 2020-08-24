//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
        
    /// <summary>
    /// Indexes a sequence of memory references
    /// </summary>
    public readonly struct MemoryStore
    {        
        readonly SegRef[] Refs;

        [MethodImpl(Inline)]
        public static MemoryStore Create(params SegRef[] src) 
            => new MemoryStore(src);                

        [MethodImpl(Inline)]
        public static MemoryStore Create(MemoryAddress src, uint size) 
            => Create(new SegRef(src,size));                

        public ReadOnlySpan<SegRef> Sources 
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
        public ref readonly SegRef Source(int index)
            => ref Refs[index];        
        
        /// <summary>
        /// Loads the data tracked by an index-identified memory reference
        /// </summary>
        /// <param name="index">The ref index</param>    
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load(int index)
            => Refs[index].Load();
        
        [MethodImpl(Inline)]
        internal MemoryStore(SegRef[] src)
            => Refs = src;        
    }
}