//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolConfig : ITooling
    {
        FilePath Source {get;}
    }

    public interface IToolConfig<T> : IToolConfig, ITooling<T>
        where T : struct, ITool<T>
    {

    }

    public interface IToolConfig<T,F> : IToolConfig<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {

    }
}