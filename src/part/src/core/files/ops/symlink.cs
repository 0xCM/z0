//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Windows;

    using static Root;

    partial struct FS
    {
        [Op]
        public static Outcome symlink(FS.FolderPath link, FS.FolderPath target, bool deleteExising = false)
        {
            try
            {
                if(deleteExising)
                    link.Delete();

                var outcome = Kernel32.CreateSymLink(link.Name, target.Name, SymLinkKind.Directory);
                if(outcome)
                    return true;
                else
                    return (false, DirectoryLinkCreationFailed.Format(link, target, EmptyString));
            }
            catch(Exception e)
            {
                return (false, DirectoryLinkCreationFailed.Format(link, target, e.ToString()));
            }
        }

        [Op]
        public static Outcome symlink(FS.FilePath link, FS.FilePath target, bool deleteExising = false)
        {
            try
            {
                if(deleteExising)
                    link.Delete();

                var outcome = Kernel32.CreateSymLink(link.Name, target.Name, SymLinkKind.File);
                if(outcome)
                    return true;
                else
                    return (false, FileLinkCreationFailed.Format(link, target, EmptyString));

            }
            catch(Exception e)
            {
                return (false, FileLinkCreationFailed.Format(link, target, e.ToString()));
            }
        }

        static MsgPattern<FS.FileUri, FS.FileUri, string> FileLinkCreationFailed => "Failed to create link {0} -> {1}:{2}";

        static MsgPattern<FS.FolderPath, FS.FolderPath, string> DirectoryLinkCreationFailed => "Failed to create link {0} -> {1}:{2}";
    }
}