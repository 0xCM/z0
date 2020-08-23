//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        public readonly struct Drive : IEntry<Drive>
        {
            public DriveLetter Name {get;}

            PathPart IEntry.Name 
                => new PathPart(Name.ToString());

            [MethodImpl(Inline)]
            public Drive(DriveLetter name)
                => Name = name;

            [MethodImpl(Inline)]
            public string Format()
                => Name.ToString();
        }        
    }
}