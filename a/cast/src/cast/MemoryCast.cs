//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;
    using System.Buffers;
    
    using static Components;
    
    //https://stackoverflow.com/questions/54511330/how-can-i-cast-memoryt-to-another
    public sealed class MemoryCast<S, T> : MemoryManager<T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly Memory<S> source;

        [MethodImpl(Inline)]
        public MemoryCast(Memory<S> source) 
            => this.source = source;

        public override Span<T> GetSpan()
            => MemoryMarshal.Cast<S, T>(source.Span);

        protected override void Dispose(bool disposing) {}

        public override MemoryHandle Pin(int elementIndex = 0)
            => throw new NotSupportedException();

        public override void Unpin()
            => throw new NotSupportedException();
    }
}