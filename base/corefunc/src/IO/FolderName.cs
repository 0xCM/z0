//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    /// <summary>
    /// Defines a folder name in isolation without ascribing additional path content
    /// </summary>
    public class FolderName : PathComponent<FolderName>
    {
        
        public static FolderName Empty => Define(string.Empty);

        public static FolderName Define(string Name)
            => new FolderName(Name);

        public static FolderName operator + (FolderName lhs, FolderName rhs)
            => Define(Path.Join(lhs.Name, "/", rhs.Name));

        public FolderName(string Name)
            : base(Name)
        {

        }
    }


}