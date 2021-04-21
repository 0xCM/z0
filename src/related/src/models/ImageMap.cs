//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = Windows;

    partial struct Images
    {

        public readonly struct ImageMap
        {
            public ProcessState Process {get;}

            public Index<LocatedImage> Images {get;}

            public Index<MemoryAddress> Locations {get;}

            public Index<ProcessModuleRow> Modules {get;}

            [MethodImpl(Inline)]
            public ImageMap(ProcessState state, LocatedImage[] images, Index<MemoryAddress> locations, ProcessModuleRow[] modules)
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
}