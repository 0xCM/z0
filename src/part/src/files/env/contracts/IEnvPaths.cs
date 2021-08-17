//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public partial interface IEnvPaths
    {
        EnvData Env {get;}

       FS.FolderName PartFolder(PartId part)
            => FS.folder(part.Format());

        FS.FilePath ControlScript(FS.FileName src)
            => ControlScripts() + src;

        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FilePath SettingsPath(string id)
            => SettingsRoot() + FS.file(id, FS.Settings);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FS.FileExt DefaultTableExt
             => FS.Csv;

        FS.FolderName TableFolder<T>()
            where T : struct
                => FS.folder(TableId<T>());

        FS.FolderName TableFolder(Type t)
                => FS.folder(TableId(t));

        string TableId(Type t)
            => Z0.TableId.identify(t).Identifier.Format();

        string TableId<T>()
            where T : struct
                => Z0.TableId.identify<T>().Identifier.Format();

        FS.FileName TableFile<T>(string subject)
            where T : struct
                => FS.file(string.Format("{0}.{1}", TableId<T>(), subject), DefaultTableExt);

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
    }
}