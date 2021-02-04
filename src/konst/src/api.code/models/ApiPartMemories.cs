//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiPartMemories : ISortedIndex<MethodAddress>
    {
        public static ApiPartMemories load(Assembly component, MethodAddress[] addresses)
        {
            Array.Sort(addresses);
            return new ApiPartMemories(component, addresses);
        }

        readonly Index<MethodAddress> Data;

        public Assembly Component {get;}

        [MethodImpl(Inline)]
        ApiPartMemories(Assembly component, MethodAddress[] addresses)
        {
            Component = component;
            Data = addresses;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<MethodAddress> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref readonly MethodAddress First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref readonly MethodAddress Last
        {
            [MethodImpl(Inline)]
            get => ref Data.Last;
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => (First.Address, Last.Address);
        }
    }
}