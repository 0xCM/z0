//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITablePaths
    {
        FS.FileExt DefaultTableExt
             => FS.Csv;

        string TableId(Type t)
            => Z0.TableId.identify(t).Identifier.Format();

        string TableId<T>()
            where T : struct
                => Z0.TableId.identify<T>().Identifier.Format();

        FS.FolderName TableFolder<T>()
            where T : struct
                => FS.folder(TableId<T>());

        FS.FileName TableFile<T>()
            where T : struct
                => FS.file(TableId<T>(), DefaultTableExt);

        FS.FileName TableFile<T>(string subject)
            where T : struct
                => FS.file(string.Format("{0}.{1}", TableId<T>(), subject), DefaultTableExt);

        FS.FolderName TableFolder(Type t)
            => FS.folder(TableId(t));

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{host}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(ApiHostUri host, FS.FileExt? ext = null)
            where T : struct
                => FS.file(string.Format("{0}.{1}.{2}", TableId<T>(), host.Part.Format(), host.HostName), ext ?? DefaultTableExt);

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(PartId part, FS.FileExt? ext = null)
            where T : struct
                => FS.file(string.Format("{0}.{1}", TableId<T>(), part.Format()), ext ?? DefaultTableExt);

        FS.FileName TableName(TableId id)
            => FS.file(id.Format(), FS.Csv);

        FS.FileName TableName(string id)
            => FS.file(id, FS.Csv);

        FS.FileName TableName(TableId id, string suffix)
            => FS.file(string.Format("{0}.{1}", id, suffix), FS.Csv);

        FS.FileName TableName<T>()
            where T : struct
                => FS.file(Z0.TableId.identify<T>().Format(), FS.Csv);

        FS.FileName TableName<T>(string suffix)
            where T : struct
                => TableName(Z0.TableId.identify<T>(), suffix);
    }
}