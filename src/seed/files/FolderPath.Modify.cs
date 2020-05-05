//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class FolderPath
    {
        /// <summary>
        /// Consigns the folder and its contents to oblivion
        /// </summary>
        /// <param name="recursive">How sure are you?</param>
        public Option<int> Delete(bool recursive = true)
        {
            try
            {
                if(Directory.Exists(Name))
                    Directory.Delete(Name, recursive);
                return 0;
            }
            catch(Exception e)
            {
                e.Report();
                return Option.none<int>();
            }
        }

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
        public FolderPath Clear(params PartId[] owners)
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
    }
}