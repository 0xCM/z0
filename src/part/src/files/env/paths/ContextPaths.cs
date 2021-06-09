//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath ProcessContextRoot()
            => CacheRoot() + FS.folder(context);

        FS.FolderPath ProcessContextRoot(FS.FolderPath root)
            => CacheRoot(root) + FS.folder(context);

        FS.FilePath ContextTable<T>(Timestamp ts)
            where T : struct, IRecord<T>
                => CaptureContextRoot() + FS.file(string.Format("{0}.{1}", Z0.TableId.identify<T>(), ts.Format()), FS.Csv);

        FS.FilePath ContextTable<T>(FS.FolderPath root, Timestamp ts)
            where T : struct, IRecord<T>
                => CaptureContextRoot(root) + FS.file(string.Format("{0}.{1}", Z0.TableId.identify<T>(), ts.Format()), FS.Csv);
    }
}