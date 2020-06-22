//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartDescription
    {
        [MethodImpl(Inline)]
        public PartDescription(FilePath path)
        {
            Path = path;
        }

        public readonly FilePath Path {get;}
    }
}