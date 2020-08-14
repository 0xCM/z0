//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface IToolFile
    {
        ToolId ToolId {get;}

        FilePath EmissionPath {get;}
    }

    public interface IToolFile<T> : IToolFile
        where T : struct, ITool<T>
    {
        T Tool => default(T);

        ToolId IToolFile.ToolId 
            => Tool.ToolId;
    }

    public interface IToolFile<T,F> : IToolFile<T>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        
    }
}