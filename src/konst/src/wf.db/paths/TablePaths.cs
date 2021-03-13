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

        string TableId(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => a.TableId, () => t.Name);

        string TableId<T>()
            => TableId(typeof(T));

        FS.FilePath Table(string id, PartId part)
            => TableDir(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), DefaultTableExt);

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableDir(id) + FS.file(part.Format(), ext);

        FS.FilePath Table<T>(string name)
            where T : struct, IRecord<T>
                => Table<T>(name, Csv);

        FS.FilePath Table<T>(FS.FolderName subject)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(RecUtil.tableid<T>().Identifier.Format(), Csv);

        FS.FilePath Table<T>(FS.FolderName subject, string discriminator)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(RecUtil.tableid<T>().Identifier.Format() + string.Format("-{0}", discriminator), Csv);

        FS.FilePath Table<T>(string name, FS.FileExt ext)
            where T : struct, IRecord<T>
        {
            var id = RecUtil.tableid<T>().Identifier;
            var dir = TableDir(id);
            return dir + FS.file(string.Format("{0}.{1}", id, name), ext);
        }

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultTableExt), () => Table(part, t.Name, DefaultTableExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct, IRecord<T>
                => Table(typeof(T), part);

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
    }
}