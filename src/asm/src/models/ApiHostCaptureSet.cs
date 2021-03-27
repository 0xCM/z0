//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiHostCaptureSet
    {
        public ApiHostCatalog Catalog {get;}

        public ApiCaptureBlocks Blocks {get;}

        public AsmRoutineIndex Routines {get;}

        [MethodImpl(Inline)]
        public ApiHostCaptureSet(ApiHostCatalog catalog, ApiCaptureBlocks blocks, AsmRoutineIndex routines)
        {
            Catalog = catalog;
            Blocks = blocks;
            Routines = routines;
        }

        public MemoryAddress StartAddress
        {
            [MethodImpl(Inline)]
            get => Catalog.MinAddress;
        }

        public MemoryAddress EndAddress
        {
            [MethodImpl(Inline)]
            get => Catalog.MaxAddress + Blocks.Last.OutputSize;
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => (StartAddress, EndAddress);
        }

        public ByteSize ExtractSize
        {
            [MethodImpl(Inline)]
            get => Blocks.ExtractSize;
        }

        public ByteSize ParsedSize
        {
            [MethodImpl(Inline)]
            get => Blocks.ParsedSize;
        }
    }
}