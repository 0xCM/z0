//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;

    /// <summary>
    /// Describes a PE image from the perspective of process entry point
    /// </summary>    
    public readonly struct LocatedImage : IAddressable<LocatedImage, MemoryAddress>, IComparable<LocatedImage>
    {
        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcesModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage from(ProcessModule src)
        {
            var path = FilePath.Define(src.FileName);
            var part = Tables.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

        /// <summary>
        /// The image source path
        /// </summary>
        public readonly FilePath ImagePath;        

        /// <summary>
        /// The image part identifier, if any
        /// </summary>
        public readonly PartId PartId;

        /// <summary>
        /// The process entry point
        /// </summary>
        public readonly MemoryAddress EntryAddress;
        
        /// <summary>
        /// The image's memory base
        /// </summary>
        public readonly MemoryAddress BaseAddress;

        /// <summary>
        /// The image size
        /// </summary>
        public readonly ByteSize Size;

        [MethodImpl(Inline)]
        public LocatedImage(FilePath path, PartId part, MemoryAddress entry, MemoryAddress @base, uint size)
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
            get => BaseAddress + (uint)Size;
        }

        /// <summary>
        /// The memory range occupied by the image
        /// </summary>
        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get =>  (BaseAddress, EndAddress);
        }

        MemoryAddress IAddressable<MemoryAddress>.Address 
            => BaseAddress;

        public int CompareTo(LocatedImage src)
            => BaseAddress.CompareTo(src.BaseAddress);
        
        public string Format()
        {            
            var expression = text.bracket(text.concat(BaseAddress, Chars.Comma, Chars.Space, EndAddress, Chars.Colon, Size));
            return text.assign(Name, expression);
        }

        public override string ToString()
            => Format();                
    }
}