//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public abstract class FunctionTable<H,I,S,T>
        where H : FunctionTable<H,I,S,T>
        where I : unmanaged
    {

    }
}