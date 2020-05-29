//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]   
        public static Symbol<E,T> symbol<E,T>(T data, E rep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => new Symbol<E,T>(data);
    }
}