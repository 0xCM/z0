//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolCmd : ITooling
    {
        
    }

    public interface IToolCmd<T> : IToolCmd, ITooling<T>
        where T : struct, ITool<T>
    {

    }

    public interface IToolCmd<T,F> : IToolCmd<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {

    }
}