//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class AsmModelFactory<T> : Service<T>
        where T : AsmModelFactory<T>,new()
    {


    }

}