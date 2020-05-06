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
    
    using static Seed;

    public interface IArchive : IService
    {
        /// <summary>
        /// The folder to which all archive path calculation is relative
        /// </summary>
        FolderPath ArchiveRoot => Env.Current.LogDir;

        /// <summary>
        /// Hex extension
        /// </summary>
        FileExtension Hex => FileExtensions.Hex;

        /// <summary>
        /// Asm extension
        /// </summary>
        FileExtension Asm => FileExtensions.Asm;

        /// <summary>
        /// Cil extension
        /// </summary>
        FileExtension Il => FileExtensions.Il;

        /// <summary>
        /// Application log extension
        /// </summary>
        FileExtension Log => FileExtensions.Log;

        /// <summary>
        /// An archive partition for files emitted during test execution
        /// </summary>
        FolderName TestPartition => FolderName.Define("test", "Test emissions");

        /// <summary>
        /// An archive partition for files emitted during application execution
        /// </summary>
        FolderName AppPartition => FolderName.Define("apps", "Application emissions");
    
        /// <summary>
        /// An archive partition for static data
        /// </summary>
        FolderName DataPartition => FolderName.Define("data", "Reference data");

        /// <summary>
        /// The folder name that corresponds to the entry process
        /// </summary>
        FolderName ExeFolder 
            => FolderName.Define(ExecutingApp);

        FolderName CodeFolder 
            => FolderName.Define("code", "Hex formatted encoded x86 assembly");

        FolderName AsmFolder 
            => FolderName.Define("asm", "Formatted x86 assembly");

        [MethodImpl(Inline)]
        FileName LegalFileName(OpIdentity id, FileExtension ext)
            => id.ToLegalFileName(ext);

        [MethodImpl(Inline)]
        FileName LegalFileName(PartId part, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(part.Format(), Chars.Dot, LegalFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName LegalFileName(ApiHostUri host, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), Chars.Dot, host.Name, Chars.Dot, LegalFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName LegalFileName(ApiHostUri host, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), ext);

        FileName AsmFileName(OpIdentity id) 
            => LegalFileName(id, Asm);

        FileName AsmFileName(ApiHostUri host)
            => LegalFileName(host, Asm);

        FileName HexFileName(OpIdentity id) 
            => LegalFileName(id, Hex);

        /// <summary>
        /// Defines a type-predicated folder name
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        FolderName TypeFolder(Type src)
            => FolderName.Define(src.Name);

        /// <summary>
        /// Defines the name of a folder predicated on a parametric type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        FolderName TypeFolder<T>()
            => TypeFolder(typeof(T));

        /// <summary>
        /// The partition to which the archive belongs
        /// </summary>
        FolderName RootPartition 
            => ExecutingApp.IsTest() ? TestPartition : AppPartition;

        /// <summary>
        /// The root directory for process-specific archive folders
        /// </summary>
        FolderPath ExeRoot 
            => ArchiveRoot + RootPartition;

        /// <summary>
        /// A process-specific directory beneath the exe root
        /// </summary>
        FolderPath ExeDir 
            => ExeRoot + ExeFolder;

        /// <summary>
        /// Nonrecursively enumerates the files in a directory owned by one of a supplied list of parts
        /// </summary>
        /// <param name="src">The directory to search</param>
        /// <param name="parts">The owning parts</param>
        FilePath[] Files(FolderPath src, params PartId[] parts) 
            =>  (from part in parts
                from file in src.Files(part)
                select file).ToArray();

        [MethodImpl(Inline)]
        FolderName PartFolder(PartId part)
            => FolderName.Define(part);

        [MethodImpl(Inline)]
        FolderName HostFolder(ApiHostUri host)
            => FolderName.Define(host);

        [MethodImpl(Inline)]
        RelativeLocation HostPart(ApiHostUri host)
            => RelativeLocation.Define(PartFolder(host.Owner), HostFolder(host));

        [MethodImpl(Inline)]
        FolderPath HostPartDir(FolderPath parent, ApiHostUri host)
            => parent + RelativeLocation.Define(PartFolder(host.Owner), HostFolder(host));

        [MethodImpl(Inline)]
        FolderPath ExeSubDir(FolderName name)
            => ExeDir + name;                

        [MethodImpl(Inline)]
        FolderPath ExeDataDir(FolderName folder)            
            => (ExeDir + DataPartition) + folder;

        [MethodImpl(Inline)]
        FolderPath ExeDataDir(Type t)            
            => ExeDataDir(TypeFolder(t));
    }
}