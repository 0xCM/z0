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

    public readonly struct ResQuery
    {
        readonly TableSpan<ResDescriptor> Data;

        public Assembly Source {get;}

        [MethodImpl(Inline)]
        internal ResQuery(Assembly src, ResDescriptor[] descriptors)
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
        public ref readonly ResDescriptor Descriptor(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ReadOnlySpan<ResDescriptor> Descriptors()
            => Data.View;

        [MethodImpl(Inline)]
        public ResQuery Filter(string match)
            => new ResQuery(Source, Data.Storage.Where(x => x.NameLike(match)));

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Content(uint index)
            => Resources.data(Descriptor(index));
    }

    partial class XTend
    {
        public static ReadOnlySpan<char> Utf8(this ResDescriptor src)
            => Resources.utf8(src);
    }
}