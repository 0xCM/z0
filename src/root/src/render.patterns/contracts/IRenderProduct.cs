//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IRenderProduct<T>
    {
        IRenderPattern Pattern {get;}

        T Product {get;}
    }
}