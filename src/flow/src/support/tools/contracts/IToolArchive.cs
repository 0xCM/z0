//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IToolArchive
    {
        /// <summary>
        /// The identifier of the owning tool
        /// </summary>
        ToolId OwnerId {get;}

        /// <summary>
        /// The tool output directory
        /// </summary>
        FolderPath ToolOutput {get;}

        /// <summary>
        /// The process root folder
        /// </summary>
        FolderPath Processed {get;}        
    }

    public interface IToolArchive<T> : IToolArchive
        where T : struct, ITool<T>
    {        
        /// <summary>
        /// The tool that owns the archive
        /// </summary>
        T Owner => default(T);

        /// <summary>
        /// The identifier of the owning tool
        /// </summary>
        ToolId IToolArchive.OwnerId 
            => Owner.ToolId;
        
        ToolFiles<T> Dir()
            => ToolArchive.output(this).Map(f => new ToolFile<T>(f));
    }

    // public interface IToolArchive<T,F> : IToolArchive<T>
    //     where T : struct, ITool<T>
    //     where F : unmanaged, Enum
    // {        
    //     IExtensionMap<F> Map {get;}

    //     FileExtension Ext(F f)
    //         => ToolArchive.ext(this, f);

    //     void MapExtension(F f, FileExtension ext)
    //         => ToolArchive.map(this, f, ext);

    //     ToolFiles<T,F> Dir(F f)
    //         => ToolArchive.dir(this, f);

    //     ToolFiles<T,F> Dir()
    //         => ToolArchive.dir(this);
    //}
}