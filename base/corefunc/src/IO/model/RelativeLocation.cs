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

    using static zfunc;

    /// <summary>
    /// Represents a relative folder name
    /// </summary>
    public class RelativeLocation : PathComponent<RelativeLocation>
    {        
        public static RelativeLocation Define(params FolderName[] folders)
            => Define(folders.Map(s => s.Name).Concat(System.IO.Path.DirectorySeparatorChar));

        public static RelativeLocation Define(params string[] parts)
            => Define(parts.Concat(System.IO.Path.DirectorySeparatorChar));

        public static RelativeLocation Define(string Name)
            => new RelativeLocation(Name);
        
        public static RelativeLocation operator + (RelativeLocation lhs, RelativeLocation rhs)
            => RelativeLocation.Define(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (RelativeLocation lhs, FileName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public RelativeLocation(string Name)
            : base(Name)
        {

        }
    }
}