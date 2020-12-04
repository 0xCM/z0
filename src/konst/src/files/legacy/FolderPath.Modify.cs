//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    partial class FolderPath
    {
        /// <summary>
        /// Creates the represented directory in the file system if it doesn't exist
        /// </summary>
        /// <param name="dst">The target path</param>
        public FolderPath Create()
        {
            if(!Directory.Exists(Name))
                Directory.CreateDirectory(Name);
            return this;
        }

        /// <summary>
        /// Deletes all files in the directory, but neither does it recurse nor delete folders
        /// </summary>
        /// <param name="owners">If nonempty, restricts the deletion operation to only files owned by a specified owner</param>
        public FolderPath Clear(PartId[] owners)
        {
            if(Directory.Exists(Name))
            {
                if(owners.Length != 0)
                {
                    foreach(var owner in owners)
                        foreach(var file in Files(owner))
                            file.Delete();
                }
                else
                {
                    foreach(var f in AllFiles)
                        f.Delete();
                }
            }
            return this;
        }

        public FolderPath Clear()
        {
            if(Directory.Exists(Name))
            {
                foreach(var f in AllFiles)
                    f.Delete();
            }
            return this;
        }
    }
}