//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;

    interface IBaseHexFormatter<F,T> : IBaseHexFormatter<T>
        where F : struct, IBaseHexFormatter<F,T>
        where T : struct
    {
        
    }
}