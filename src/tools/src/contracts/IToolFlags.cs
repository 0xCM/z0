//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface IToolFlags<F> : ITool
        where F : unmanaged, Enum
    {
        IExtensionMap<F> Map {get;}
    }

    public interface IToolFlags<T,F> : IToolFlags<F>, ITooling<T>
        where F : unmanaged, Enum
        where T : struct, ITool<T>
    {


    }
}