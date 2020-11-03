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

    public abstract class ApiIndex
    {
        public const uint SlotCount = ushort.MaxValue;

        public abstract uint EntryCount {get;}
    }

    public abstract class ApiIndex<H> : ApiIndex
        where H : ApiIndex<H>, new()
    {
        public static H init()
            => new H();
    }

    public abstract class ApiIndex<H,T> : ApiIndex<H>
        where H : ApiIndex<H,T>, new()
    {
        uint SealedCount;

        protected T[] EntryData;

        protected ApiIndex()
        {
            EntryData = alloc<T>(SlotCount);
        }

        public Span<T> Entries
        {
            [MethodImpl(Inline)]
            get => EntryData;
        }

        public ref T LeadingEntry
        {
            [MethodImpl(Inline)]
            get => ref first(EntryData);
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(LeadingEntry, index);
        }

        public override uint EntryCount
            => SealedCount;

        public H SealEntries(uint count)
        {
            SealedCount = count;
            return (H)this;
        }
    }
}