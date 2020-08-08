//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public interface IToolArchive<T> : ITooling<T>
        where T : struct, ITool<T>
    {
        FolderPath Root {get;}                         
    }

    public interface IToolArchive<T,F> : IToolArchive<T>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        IExtensionMap<F> Map {get;}

        FolderPath Dir(F f)
            => ToolArchive.dir(this, f);

        FolderName Folder(F f)
            => ToolArchive.folder(this, f);

        FileExtension Ext(F f)
            => ToolArchive.ext(this, f);

        void MapExtension(F f, FileExtension ext)
            => ToolArchive.map(this, f, ext);

        ToolFiles<T,F> Files(F f)
            => ToolArchive.files(this,f);
    }
}