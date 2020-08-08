//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITooling
    {
        ToolId ToolId {get;}
    }

    public interface ITooling<T> : ITooling
        where T : struct, ITool<T>
    {
        T Tool => default;

        ToolId ITooling.ToolId 
            => Tool.ToolId;
    }

    public interface ITooling<T,F> : ITooling<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {

    }
}