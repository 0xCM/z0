//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocatedImage
    {
        /// <summary>
        /// The image source path
        /// </summary>
        FS.FilePath ImagePath {get;}

        /// <summary>
        /// The image part identifier, if any
        /// </summary>
        PartId PartId {get;}

        /// <summary>
        /// The process entry point
        /// </summary>
        MemoryAddress EntryAddress {get;}

        /// <summary>
        /// The image's memory base
        /// </summary>
        MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The image size
        /// </summary>
        ByteSize Size {get;}
    }

    public interface ILocatedImage<H> : ILocatedImage, IDataTypeComparable<H>, IAddressable<H, MemoryAddress>
        where H : struct, ILocatedImage<H>
    {

    }
}