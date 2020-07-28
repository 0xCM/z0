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
        public static LocatedImage from(ProcessModule src)
            => new LocatedImage(FilePath.Define(src.FileName), src.EntryPointAddress, src.BaseAddress, (uint)src.ModuleMemorySize);

        /// <summary>
        /// The image source path
        /// </summary>
        public readonly FilePath ImagePath;        

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
        public readonly uint Size;

        [MethodImpl(Inline)]
        public LocatedImage(FilePath path, MemoryAddress entry, MemoryAddress @base, uint size)
        {
            ImagePath = path;
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