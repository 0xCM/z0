//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    partial interface IEnvPaths
    {
       /// <summary>
        /// Specifies a table root for an identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FolderPath TableDir(string subject)
            => TableRoot() + FS.folder(subject);

        /// <summary>
        /// Specifies a table subdirectory
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FolderPath TableDir(FS.FolderName subject)
            => TableRoot() + subject;

        /// <summary>
        /// Specifies a table root for a type-identified subject
        /// </summary>
        /// <param name="t">The identifying type</param>
        FS.FolderPath TableDir(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => TableDir(a.TableId), () => TableDir(t.Name));

        /// <summary>
        /// Specifies a table root for a parametrically-identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        /// <typeparam name="S">The subject type</typeparam>
        FS.FolderPath TableDir<T>()
            where T : struct, IRecord<T>
                => TableDir(typeof(T));

        /// <summary>
        /// Creates a folder path of the form {DbRoot}/tables/{TableId}.{subject}
        /// </summary>
        /// <param name="subject">The subject name</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FolderPath TableDir<T>(string subject)
            where T : struct, IRecord<T>
                => TableRoot() + FS.folder(string.Format("{0}.{1}", TableId<T>(), subject));

        string TableId(Type t)
            => RecUtil.tableid(t).Identifier.Format();

        string TableId<T>()
            where T : struct, IRecord<T>
                => RecUtil.tableid<T>().Identifier.Format();

        FS.FilePath Table(string subject, PartId part)
            => TableDir(subject) + FS.file(string.Format(RP.SlotDot2, subject, part.Format()), DefaultTableExt);

        FS.FilePath Table(PartId part, string subject, FS.FileExt ext)
            => TableDir(subject) + FS.file(part.Format(), ext);

        FS.FilePath Table<T>(string subject)
            where T : struct, IRecord<T>
                => Table<T>(subject, Csv);

        FS.FilePath Table<T>(FS.FolderName subject)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(TableId<T>(), Csv);

        FS.FilePath Table<T>(FS.FolderName subject, string discriminator)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(TableId<T>() + string.Format("-{0}", discriminator), Csv);

        FS.FilePath Table<T>(string subject, FS.FileExt ext)
            where T : struct, IRecord<T>
        {
            var id = TableId<T>();
            var dir = TableDir(id);
            return dir + FS.file(string.Format("{0}.{1}", id, subject), ext);
        }

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultTableExt), () => Table(part, t.Name, DefaultTableExt));

        /// <summary>
        /// Creates a <see cref='FS.FilePath'/> of the form {DbRoot}/tables/{TableId}/{TableId}.{part}.{ext}
        /// </summary>
        /// <param name="part">The part id</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FilePath Table<T>(PartId part)
            where T : struct, IRecord<T>
                => TableDir<T>() + TableFile<T>(part);

        /// <summary>
        /// Creates a <see cref='FS.FilePath'/> of the form {DbRoot}/tables/{TableId}/{TableId}.{part}.{host}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FilePath Table<T>(ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => TableDir<T>() + TableFile<T>(host);

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(PartId part, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", TableId<T>(), part.Format()), ext ?? DefaultTableExt);

        /// <summary>
        /// Creates a <see cref='FS.FileName'/> of the form {TableId}.{part}.{host}.{ext}
        /// </summary>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FileName TableFile<T>(ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}.{2}", TableId<T>(), host.Owner.Format(), host.Name), ext ?? DefaultTableExt);

        /// <summary>
        /// Creates a <see cref='FS.FilePath'/> of the form {DbRoot}/tables/{TableId}.{subject}/{TableId}.{part}.{host}.{ext}
        /// </summary>
        /// <param name="subject">The subject name</param>
        /// <param name="host">The host uri</param>
        /// <param name="ext">The file extension</param>
        /// <typeparam name="T">The record type</typeparam>
        FS.FilePath Table<T>(string subject, ApiHostUri host, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
                => TableDir<T>(subject) + TableFile<T>(host, ext);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(DbNames.qualified, id, subject), ext ?? Csv);

        FS.FolderPath IndexDir(Type t)
            => IndexRoot() + FS.folder(TableId(t));

        FS.FolderPath IndexDir(string subject)
            => IndexRoot() + FS.folder(subject);

        FS.FolderPath IndexDir<T>()
            where T : struct, IRecord<T>
                => IndexRoot() + FS.folder(TableId<T>());

        FS.FilePath IndexTable(string id)
            => IndexRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FilePath IndexTable<T>()
            where T : struct, IRecord<T>
                => IndexTable(typeof(T));

        FS.FilePath IndexTable(Type t, string discriminator)
            => IndexDir(t) + FS.file(TableId(t) + discriminator, DefaultTableExt);

        FS.FilePath IndexTable<T>(string discriminator)
            where T : struct, IRecord<T>
                => IndexDir(typeof(T)) + FS.file(TableId<T>() + "." + discriminator, DefaultTableExt);

        FS.FileName TableFileName<T>(string id)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", TableId<T>(), id), Csv);

        FS.FileExt DefaultTableExt
             => Csv;
    }
}