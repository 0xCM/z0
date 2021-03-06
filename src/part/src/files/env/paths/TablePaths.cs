//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath TableRoot()
            => DbRoot() + FS.folder(tables);

        FS.FolderPath TableRoot(FS.FolderPath root)
            => DbRoot(root) + FS.folder(tables);

        FS.FolderPath TableDir(string subject)
            => TableRoot() + FS.folder(subject);

        FS.FolderPath TableDir(FS.FolderName subject)
            => TableRoot() + subject;

        FS.FolderPath TableDir(FS.FolderPath root, FS.FolderName subject)
            => TableRoot(root) + subject;

        FS.FolderPath TableDir(FS.FolderPath root, string subject)
            => TableRoot(root) + FS.folder(subject);

        FS.FolderPath TableDir(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => TableDir(a.TableId), () => TableDir(t.Name));

        FS.FolderPath TableDir(FS.FolderPath root, Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => TableDir(root, a.TableId), () => TableDir(root, t.Name));

        FS.FolderPath TableDir<T>()
            where T : struct, IRecord<T>
                => TableDir(typeof(T));

        FS.FolderPath TableDir<T>(FS.FolderPath root)
            where T : struct, IRecord<T>
                => TableDir(root, typeof(T));

        FS.FolderName TableFolder<T>()
            where T : struct, IRecord<T>
                => FS.folder(TableId<T>());

        FS.FolderName TableFolder(Type t)
                => FS.folder(TableId(t));

        FS.FolderPath TableDir<T>(string subject)
            where T : struct, IRecord<T>
                => TableRoot() + FS.folder(string.Format("{0}.{1}", TableId<T>(), subject));

        string TableId(Type t)
            => Z0.TableId.identify(t).Identifier.Format();

        string TableId<T>()
            where T : struct, IRecord<T>
                => Z0.TableId.identify<T>().Identifier.Format();

        FS.FilePath Table(string subject, PartId part)
            => TableDir(subject) + FS.file(string.Format(RP.SlotDot2, subject, part.Format()), DefaultTableExt);

        FS.FilePath Table(FS.FolderPath dir, string subject, PartId part)
            => dir + FS.file(string.Format(RP.SlotDot2, subject, part.Format()), DefaultTableExt);

        FS.FilePath Table<T>(PartId part)
            where T : struct, IRecord<T>
                => TableDir<T>() + FS.file(string.Format("{0}.{1}", TableId<T>(), part.Format()), DefaultTableExt);

        FS.FilePath Table<T>(string subject)
            where T : struct, IRecord<T>
                => Table<T>(subject, FS.Csv);

        FS.FileName TableFile<T>(string subject)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", TableId<T>(), subject), DefaultTableExt);

        FS.FolderPath GenTables()
            => DbRoot() + FS.folder("generators");

        FS.FilePath GenTable<T>(string subject)
            where T : struct, IRecord<T>
                => GenTables() + FS.file(subject, FS.Csv);

        FS.FilePath Table<T>(FS.FolderName subject)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(TableId<T>(), DefaultTableExt);

        FS.FilePath Table<T>(FS.FolderPath dir, string subject)
            where T : struct, IRecord<T>
                => dir + FS.file(string.Format("{0}.{1}", TableId<T>(), subject), DefaultTableExt);

        FS.FilePath Table<T>(FS.FolderPath dir)
            where T : struct, IRecord<T>
                => dir + FS.file(TableId<T>(), DefaultTableExt);

        FS.FilePath Table<T>(FS.FolderName subject, string discriminator)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(TableId<T>() + string.Format("-{0}", discriminator), DefaultTableExt);

        FS.FilePath Table<T>(string subject, FS.FileExt ext)
            where T : struct, IRecord<T>
        {
            var id = TableId<T>();
            var dir = TableDir(id);
            return dir + FS.file(string.Format("{0}.{1}", id, subject), ext);
        }

        /// <summary>
        /// Creates a <see cref='FS.FolderPath'/> of the form {DbRoot}/tables/{TableId}/{PartId}
        /// </summary>
        /// <param name="part">The part id</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FolderPath TableDir<T>(PartId host)
            where T : struct, IRecord<T>
                => TableDir<T>() + FS.folder(host.Format());

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{host}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}.{2}", TableId<T>(), host.Part.Format(), host.HostName), ext ?? DefaultTableExt);

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(PartId part, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", TableId<T>(), part.Format()), ext ?? DefaultTableExt);

        FS.FilePath Table<T>(ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => TableDir<T>(host.Part) + TableFile<T>(host, ext);

        FS.FilePath Table<T>(PartId part, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => TableDir<T>() + FS.folder(part.Format()) + TableFile<T>(part, ext);

        FS.FilePath Table<T>(string subject, ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => TableDir<T>(subject) + TableFile<T>(host, ext);

        FS.FilePath Table<S>(string id, S subject)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(EnvFolders.qualified, id, subject), DefaultTableExt);

        FS.FilePath Table<S>(FS.FolderPath dir, S subject)
            => dir + FS.file(subject.ToString(), DefaultTableExt);

        FS.FolderPath IndexDir(string subject)
            => IndexRoot() + FS.folder(subject);

        FS.FilePath IndexTable(string id)
            => IndexRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FilePath IndexTable<T>()
            where T : struct, IRecord<T>
                => IndexTable(typeof(T));

        FS.FileName TableFileName<T>(string id)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", TableId<T>(), id), DefaultTableExt);

        FS.FileExt DefaultTableExt
             => FS.Csv;

        FS.FolderPath AppTableRoot
            => AppLogDir() + FS.folder(tables);

        FS.FolderPath AppTableDir<T>()
            where T : struct, IRecord<T>
                => AppTableRoot + TableFolder<T>();

        FS.FolderPath AppTableDir(Type t)
            => AppTableRoot + TableFolder(t);

        FS.FilePath AppTablePath<T>(FS.FileExt? ext = null)
            where T : struct, IRecord<T>
        {
            var id = TableId<T>();
            var dir = AppTableDir<T>();
            return dir + FS.file(id, ext ?? FS.Csv);
        }

        FS.FilePath AppTablePath(Type t, string subject, FS.FileExt? ext = null)
        {
            var id = TableId(t);
            var dir = AppTableDir(t);
            return dir + FS.file(string.Format("{0}.{1}", id, subject), ext ?? FS.Csv);
        }
    }
}