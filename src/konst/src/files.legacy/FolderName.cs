//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a folder name in isolation without ascribing additional path content
    /// </summary>
    public class FolderName : PathComponent<FolderName>
    {
        /// <summary>
        /// Describes the sort of file contained by the folder
        /// </summary>
        public string Description {get;}

        [MethodImpl(Inline)]
        public static FolderName Define(string Name)
            => new FolderName(Name);

        [MethodImpl(Inline)]
        public static FolderName operator + (FolderName lhs, FolderName rhs)
            => Define(Path.Join(lhs.Name, "/", rhs.Name));

        public FolderName()
        {
            Description = string.Empty;
        }

        [MethodImpl(Inline)]
        public FolderName(string name)
            : base(name)
        {
            Description = string.Empty;
        }

    }
}