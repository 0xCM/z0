//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LocatedImage<T> : IAddressable<LocatedImage<T>, MemoryAddress>
    {
        /// <summary>
        /// The image source path
        /// </summary>
        public readonly FilePath ImagePath;        

        /// <summary>
        /// The address at which image data begins
        /// </summary>
        public readonly MemoryAddress StartAddress;

        /// <summary>
        /// The address at which image data ends
        /// </summary>
        public readonly MemoryAddress EndAddress;

        [MethodImpl(Inline)]
        public LocatedImage(FilePath path, MemoryAddress start, MemoryAddress end)
        {
            ImagePath = path;
            StartAddress = start;
            EndAddress = end;
        }
        
        MemoryAddress IAddressable<MemoryAddress>.Address 
            => StartAddress;

        public MemoryRange Segment
        {
            [MethodImpl(Inline)]
            get =>  (StartAddress, EndAddress);
        }
    }
}