//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CacheRoot()
            => Env.CacheRoot.Value;

        FS.FolderPath CacheRoot(FS.FolderPath root)
            => root;

        FS.FolderPath SymbolCacheRoot()
            => CacheRoot() + FS.folder(symbols);

        FS.FolderPath DefaultSymbolCache()
            => SymbolCacheRoot() + FS.folder(@default);

        FS.FolderPath DotNetSymbolRoot()
            => SymbolCacheRoot() + FS.folder(dotnet);

        Index<FS.FolderPath> DotNetSymbolDirs()
            => DotNetSymbolRoot().SubDirs();

        FS.Files DotNetSymbolFiles(FS.FolderName folder)
            => DotNetSymbolDir(folder).Files(false);

        FS.FolderPath DotNetSymbolDir(FS.FolderName folder)
            => DotNetSymbolRoot() + folder;

        FS.FolderPath DotNetSymbolDir(byte major, byte minor, byte revision)
            => DotNetSymbolRoot() + VersionFolderName(major,minor,revision);

        FS.FolderName VersionFolderName(byte major, byte minor, byte revision)
            => FS.folder(string.Format("{0}.{1}.{2}", major, minor, revision));

        FS.FolderPath ProcessContextRoot()
            => CacheRoot() + FS.folder(context);

        FS.FolderPath ProcessContextRoot(FS.FolderPath root)
            => CacheRoot(root) + FS.folder(context);

        FS.FilePath ContextTable<T>(Timestamp ts)
            where T : struct, IRecord<T>
                => CaptureContextRoot() + FS.file(string.Format("{0}.{1}", Tables.identify<T>(), ts.Format()), FS.Csv);

        FS.FilePath ContextTable<T>(FS.FolderPath root, Timestamp ts)
            where T : struct, IRecord<T>
                => CaptureContextRoot(root) + FS.file(string.Format("{0}.{1}", Tables.identify<T>(), ts.Format()), FS.Csv);

        FS.FolderPath ImageDumpRoot()
            => CacheRoot() + FS.folder(dumps) + FS.folder(images);

        FS.FolderPath ImageDumpRoot(FS.FolderPath root)
            => CacheRoot(root) + FS.folder(dumps) + FS.folder(images);

        FS.FolderPath DotNetImageDumpRoot()
            => ImageDumpRoot() + FS.folder(dotnet);

        FS.FolderPath DotNetImageDumpRoot(FS.FolderPath root)
            => ImageDumpRoot(root) + FS.folder(dotnet);

        FS.FolderPath DotNetImageDumpDir(byte major, byte minor, byte revision)
            => DotNetImageDumpRoot() + VersionFolderName(major, minor, revision);

        FS.FolderPath DotNetImageDumpDir(FS.FolderPath root, byte major, byte minor, byte revision)
            => DotNetImageDumpRoot(root) + VersionFolderName(major, minor, revision);
    }
}