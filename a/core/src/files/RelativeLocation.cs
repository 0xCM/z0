//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Represents a relative folder name
    /// </summary>
    public class RelativeLocation : PathComponent<RelativeLocation>
    {        
        [MethodImpl(Inline)]
        public static RelativeLocation Define(params FolderName[] folders)
            => Define(folders.Select(s => s.Name).Concat(Path.DirectorySeparatorChar));

        [MethodImpl(Inline)]
        public static RelativeLocation Define(params string[] parts)
            => Define(parts.Concat(Path.DirectorySeparatorChar));

        [MethodImpl(Inline)]
        public static RelativeLocation Define(string name)
            => new RelativeLocation(name);
        
        public static RelativeLocation operator + (RelativeLocation a, RelativeLocation b)
            => RelativeLocation.Define(Path.Join(a.Name, b.Name));

        public static FilePath operator + (RelativeLocation location, FileName file)
            => new FilePath(Path.Join(location.Name, file.Name));

        public RelativeLocation()
        {

        }
        
        public RelativeLocation(string name)
            : base(name)
        {

        }
    }
}