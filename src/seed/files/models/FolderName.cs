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

        /// <summary>
        /// Defines the name of a part-owned folder
        /// </summary>
        /// <param name="part">The owning part</param>
        [MethodImpl(Inline)]
        public static FolderName Define(PartId part)
            => new FolderName(part.Format());

        /// <summary>
        /// Defines the name of an api host-owned folder
        /// </summary>
        /// <param name="part">The owning host</param>
        [MethodImpl(Inline)]
        public static FolderName Define(ApiHostUri host)
            => new FolderName(host.Name);

        [MethodImpl(Inline)]
        public static FolderName Define(string name, string description)
            => new FolderName(name, description);

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

        [MethodImpl(Inline)]
        public FolderName(string name, string description)
            : base(name)
        {
            Description = description;
        }
    }
}