//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static char @char<E,T>(Symbol<E,T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => head(cast<char>(bytes(src.Data).Slice(0,2)));        
    }
}