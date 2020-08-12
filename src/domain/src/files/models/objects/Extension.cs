//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {
        public readonly struct Extension : IFso<Extension>
        {            
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public Extension(PathPart name)
                => Name = name;

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            public static Extension Empty 
            {
                [MethodImpl(Inline)]
                get => new Extension(PathPart.Empty);
            }

            [MethodImpl(Inline)]
            public string Format()
                => Name.ToString();
        }        
    }
}