//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;
    using api = TableProcessors;
    
    public readonly struct Selectors<D,S> : ISelectors<Selectors<D,S>,D,S>
        where D : unmanaged, Enum        
        where S : unmanaged
    {
        readonly Selector<D,S>[] Subjects;
        
        public S MinId {get;}

        public S MaxId {get;}

        public S[] Index {get;}
        
        public ClosedInterval<ulong> Positions {get;}

        public ClosedInterval<ulong> Indices {get;}        

        public ulong Offset {get;}

        readonly ulong Count;

        [MethodImpl(Inline)]        
        public Selectors(Selector<D,S>[] src, S min, S max)
        {
            Subjects = src;
            MinId = min;
            MaxId = max;
            Positions = api.positions(min,max);
            Count = Positions.Width;
            Index = sys.alloc<S>(Count);
            Offset = Positions.Min;
            Indices = api.indices<D,S>(Positions, MinId, MaxId);
        }

        [MethodImpl(Inline)]        
        public ref Selector<D,S> Lookup(D id)
        {
            var index = api.index<D,S>(Positions, id); 
            return ref Subjects[index];            
        }

        public ref Selector<D,S> this[D id]
        {
            [MethodImpl(Inline)]        
            get => ref Lookup(id);
        }

        public ref Selector<D,S> this[S index]
        {
            [MethodImpl(Inline)]        
            get => ref Subjects[uint64(index)];
        }

        public ref Selector<D,S> this[ulong index]
        {
            [MethodImpl(Inline)]        
            get => ref Subjects[index];
        }

        public ReadOnlySpan<Selector<D,S>> View
        {
            [MethodImpl(Inline)]        
            get => Subjects;
        }

        public Span<Selector<D,S>> Edit
        {
            [MethodImpl(Inline)]        
            get => Subjects;
        }
    }
}