//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    public readonly struct ResDescriptors : IIndex<ResDescriptor>
    {
        [Op]
        public static ResDescriptors from(Assembly src)
            => new ResDescriptors(src, collect(src));

        [Op]
        static unsafe Index<ResDescriptor> collect(Assembly src)
        {
            var resnames = @readonly(src.GetManifestResourceNames());
            var count = resnames.Length;
            if(count == 0)
                return sys.empty<ResDescriptor>();

            var buffer = alloc<ResDescriptor>(count);
            var target = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var name = ref skip(resnames, i);
                var stream = (UnmanagedMemoryStream)src.GetManifestResourceStream(name);
                seek(target,i) = Resources.descriptor(name, stream.PositionPointer, (uint)stream.Length);
            }
            return buffer;
        }

        readonly Index<ResDescriptor> Data;

        public Assembly Source {get;}

        [MethodImpl(Inline)]
        public ResDescriptors(Assembly src, Index<ResDescriptor> descriptors)
        {
            Data = descriptors;
            Source = src;
        }

        public uint ResourceCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ResDescriptor[] Storage
        {
            get => Data.Storage;
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
        {
            ref readonly var src = ref Descriptor(index);
            return memory.view(src.Address, src.Size);
        }
    }
}