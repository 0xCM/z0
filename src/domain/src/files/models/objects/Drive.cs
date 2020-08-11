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
        public readonly struct Drive : IFileSystemObject<Drive>
        {
            public DriveLetter Name {get;}

            PathPart IFileSystemObject.Name 
                => new PathPart((char)Name);

            [MethodImpl(Inline)]
            public Drive(DriveLetter name)
                => Name = name;
        }        
    }
}