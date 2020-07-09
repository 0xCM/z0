//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;
    using static Typed;

    public readonly struct StringRefs<N>
        where N : unmanaged, ITypeNat
    {
        readonly StringRef[] Refs;

        [MethodImpl(Inline)]
        public StringRefs(StringRef[] src)
            => Refs = core.insist(src, default(N));

        [MethodImpl(Inline)]
        public ref readonly StringRef Ref<I>(I i = default)
            where I : unmanaged, ITypeNat
        {
            var idx = core.value(i);
            insist(idx < Count);
            return ref Refs[idx];
        }        

        public uint Count
            => (uint)core.value<N>();
    }
    
    public readonly struct StringRefs : ITextual
    {
        readonly Vector512<ulong> Locations;

        public StringRef Slot0
        {
            [MethodImpl(Inline)]
            get => StringRef.from(memref(Locations[n0]));
        }  

        public StringRef Slot1
        {
            [MethodImpl(Inline)]
            get => StringRef.from(memref(Locations[n1]));
        }  

        public StringRef Slot2
        {
            [MethodImpl(Inline)]
            get => StringRef.from(memref(Locations[n2]));
        }  

        [MethodImpl(Inline)]
        public StringRefs(string id, string cx, string ix)
        {                 
            Locations = v512<ulong>(memref(id), memref(cx), memref(ix), MemRef.Empty);
        }  

        public string Format()
            => Addressable.join(" ", Slot0, Slot1, Slot2);

        public string Format(bool diagnostic)
            => text.concat(
                nameof(Slot0), " := ", Slot0.Address, text.bracket(Slot0.Length), Space, text.embrace(Slot0.Text),
                nameof(Slot1), " := ", Slot1.Address, text.bracket(Slot1.Length), Space, text.embrace(Slot1.Text),
                nameof(Slot2), " := ", Slot2.Address, text.bracket(Slot2.Length), Space, text.embrace(Slot2.Text)
                );            
    }
}