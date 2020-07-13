//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    public readonly struct PartFileKind
    {        
        public readonly PartFileClass Class;
        
        public readonly FileExt Ext;

        [MethodImpl(Inline)]
        public PartFileKind(PartFileClass @class, FileExt ext)
        {
            Class = @class;
            Ext = ext;
        }
    }
}