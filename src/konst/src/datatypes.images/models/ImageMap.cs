//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ImageMap : ITextual
    {
        public ProcessState Process {get;}

        public Index<LocatedImage> Images {get;}

        public MemoryAddresses Locations {get;}

        public Index<ProcessModuleRow> Modules {get;}

        [MethodImpl(Inline)]
        public ImageMap(ProcessState state, LocatedImage[] images, MemoryAddresses locations, ProcessModuleRow[] modules)
        {
            Process = state;
            Images = images;
            Locations = locations;
            Modules = modules;
        }

        public string Format()
            => Process.ImageName;

        public override string ToString()
            => Format();
    }
}