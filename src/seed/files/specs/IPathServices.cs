//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Konst;

    /// <summary>
    /// Defines stateless file system services
    /// </summary>
    public interface IPathServices
    {
        /// <summary>
        /// Nonrecursively enumerates the files in a directory owned by one of a supplied list of parts
        /// </summary>
        /// <param name="src">The directory to search</param>
        /// <param name="parts">The owning parts</param>
        FilePath[] Files(FolderPath src, params PartId[] parts) 
            =>  (from part in parts
                from file in src.Files(part)
                select file).ToArray();      

        /// <summary>
        /// Defines a part-specific folder name {part}
        /// </summary>
        /// <param name="part">The source part</param>
        [MethodImpl(Inline)]        
        FolderName PartFolder(PartId part)
            => FolderName.Define(part);
            
        /// <summary>
        /// Defines a host-specific folder name {host.Name}
        /// </summary>
        /// <param name="part">The source part</param>
        [MethodImpl(Inline)]
        FolderName HostFolder(ApiHostUri host)
            => FolderName.Define(host);

        /// <summary>
        /// Defines a type-specific folder name {t.Name}
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        FolderName TypeFolder(Type src)
            => FolderName.Define(src.Name);

        /// <summary>
        /// Defines a type-specific folder name {[T].Name} for parametric type T
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        FolderName TypeFolder<T>()
            => TypeFolder(typeof(T));        

        [MethodImpl(Inline)]
        RelativeLocation HostPart(ApiHostUri host)
            => RelativeLocation.Define(PartFolder(host.Owner), HostFolder(host));

        [MethodImpl(Inline)]
        FolderPath HostPartDir(FolderPath root, ApiHostUri host)
            => root + RelativeLocation.Define(PartFolder(host.Owner), HostFolder(host));
    }
}