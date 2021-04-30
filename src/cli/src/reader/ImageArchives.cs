//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;
    using static Images;

    [ApiHost]
    public readonly struct ImageArchives
    {
        [Op]
        public static void EmitBuildArchiveList(IWfRuntime wf, string label)
        {
            var builder = wf.CmdBuilder();
            var archive = WfRuntime.RuntimeArchive(wf);
            var types = array(FS.Dll, FS.Exe, FS.Pdb, FS.Lib, FS.Xml, FS.Json);
            var cmd = builder.ListFiles(label + ".build-artifacts", archive.Root, types);
            wf.Router.Dispatch(cmd);
        }

        /// <summary>
        /// Creates an archive that contains csv-formatted image files
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive tables(IWfRuntime wf)
            => new FileArchive(wf.Db().TableDir<ImageContent>());

        /// <summary>
        /// Creates an archive over the runtime directory
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive runtime(IWfRuntime wf)
            => new FileArchive(wf.Controller.ImageDir);

        /// <summary>
        /// Creates an archive that contains build image artifacts
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive build(IWfRuntime wf)
            => new FileArchive(wf.Db().BuildArchiveRoot());
    }
}