//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Workspace
    {
        public readonly FileSystemObject Root;                
        
        public readonly FileSystemObjects[] Members;   

        [MethodImpl(Inline)]
        public Workspace(FileSystemObject root, FileSystemObjects[] members)
        {
            Root = root;
            Members = members;
        }
    }
}