//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = ImageMaps;

    /// <summary>
    /// Describes a PE image from the perspective of process entry point
    /// </summary>
    [Datatype]
    public readonly struct LocatedImage : ILocatedImage<LocatedImage>
    {
        /// <summary>
        /// The image source path
        /// </summary>
        public FS.FilePath ImagePath {get;}

        /// <summary>
        /// The image part identifier, if any
        /// </summary>
        public PartId PartId {get;}

        /// <summary>
        /// The process entry point
        /// </summary>
        public MemoryAddress EntryAddress {get;}

        /// <summary>
        /// The image's memory base
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The image size
        /// </summary>
        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public LocatedImage(FS.FilePath path, PartId part, MemoryAddress entry, MemoryAddress @base, uint size)
        {
            ImagePath = path;
            PartId = part;
            EntryAddress = entry;
            BaseAddress = @base;
            Size = size;
        }

        /// <summary>
        /// The <see cref='ImagePath'/> filename without the extension
        /// </summary>
        public string Name
        {
            [MethodImpl(Inline)]
            get => ImagePath.FileName.WithoutExtension.Name;
        }

        /// <summary>
        /// The terminal address as determined by <see cref='BaseAddress'/> + <see cref='Size'/>
        /// </summary>
        public MemoryAddress EndAddress
        {
            [MethodImpl(Inline)]
            get => BaseAddress + Size;
        }

        /// <summary>
        /// The memory range occupied by the image
        /// </summary>
        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => (BaseAddress, EndAddress);
        }

        MemoryAddress IAddressable<MemoryAddress>.Address
            => BaseAddress;

        public int CompareTo(LocatedImage src)
            => BaseAddress.CompareTo(src.BaseAddress);

        public string Format()
            => api.format(this);


        public override string ToString()
            => Format();
    }
}