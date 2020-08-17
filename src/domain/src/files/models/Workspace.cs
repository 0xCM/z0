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
        public readonly FS.Entry Root;                
        
        public readonly FS.Entry[] Files;   

        [MethodImpl(Inline)]
        public Workspace(FS.Entry root, FS.Entry[] files)
        {
            Root = root;
            Files = files;
        }
    }
}