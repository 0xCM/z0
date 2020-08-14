//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolConfig
    {
        ToolId ToolId {get;}
        
        FolderPath Source {get;}

        FolderPath Target {get;}
    }

    public interface IToolConfig<T> : IToolConfig
        where T : struct, ITool<T>
    {

    }
}