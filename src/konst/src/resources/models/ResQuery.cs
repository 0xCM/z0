//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ResDescriptors
    {
        readonly Index<ResDescriptor> Data;

        public Assembly Source {get;}

        [MethodImpl(Inline)]
        internal ResDescriptors(Assembly src, Index<ResDescriptor> descriptors)
        {
            Data = descriptors;
            Source = src;
        }

        public uint ResourceCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<ResDescriptor> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref readonly ResDescriptor this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public ref readonly ResDescriptor Descriptor(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ResDescriptors Filter(string match)
            => new ResDescriptors(Source, Data.Storage.Where(x => x.NameLike(match)));

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Content(uint index)
            => Resources.view(Descriptor(index));
    }
}