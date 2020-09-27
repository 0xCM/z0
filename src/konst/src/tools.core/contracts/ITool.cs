//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITool
    {
        ToolId ToolId {get;}

        FS.FolderPath Source  => FS.FolderPath.Empty;
    }

    public interface ITool<T> : ITool
        where T : struct, ITool<T>
    {
        T Tool => default;

        ToolId ITool.ToolId
            => Tool.ToolId;

        IToolArchive<T> Archive {get;}
    }

    public interface ITool<T,F> : ITool<T>, IToolFlags<F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        ToolFlags<F> AvailableFlags {get;}
    }
}