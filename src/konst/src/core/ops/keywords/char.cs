//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {                
        [MethodImpl(Inline)]
        public static char @char<E>(in E src) 
            where E : unmanaged
                => @as<E,char>(src);
    }
}