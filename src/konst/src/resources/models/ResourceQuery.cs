//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ResourceQuery
    {
        readonly TableSpan<ResourceDescriptor> Data;

        public Assembly Source {get;}

        [MethodImpl(Inline)]
        internal ResourceQuery(Assembly src, ResourceDescriptor[] descriptors)
        {
            Data = descriptors;
            Source = src;
        }

        public uint ResourceCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ref readonly ResourceDescriptor Descriptor(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ReadOnlySpan<ResourceDescriptor> Descriptors()
            => Data.View;

        [MethodImpl(Inline)]
        public ResourceQuery Filter(string match)
            => new ResourceQuery(Source, Data.Storage.Where(x => x.NameLike(match)));

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Content(uint index)
            => Resources.data(Descriptor(index));
    }

    partial class XTend
    {
        public static ReadOnlySpan<char> Utf8(this ResourceDescriptor src)
            => Resources.utf8(src);
    }
}