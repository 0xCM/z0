//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    

    using static Seed;

    public interface IArchive : IService
    {
        FolderPath DefaultRootDir => Env.Current.LogDir;

        /// <summary>
        /// The folder to which all path calculation is relative
        /// </summary>
        FolderPath RootDir => DefaultRootDir;

        FolderName RootPartition 
            => ExecutingApp.IsTest() ? FolderName.Define("test") : FolderName.Define("apps");

        FolderName DataFolder
            => ExecutingApp.IsTest() ? FolderName.Define("data") : FolderName.Empty;

        /// <summary>
        /// The archive folder specific to an application
        /// </summary>
        FolderPath AppDir 
            => RootDir + RootPartition;

        [MethodImpl(Inline)]
        FolderName TypeFolder(Type t)
            => FolderName.Define(t.Name);

        [MethodImpl(Inline)]
        FolderName TypeFolder<T>()
            => TypeFolder(typeof(T));

        [MethodImpl(Inline)]
        FolderPath AppSubDir(FolderName subfolder)
            => AppDir + subfolder;                

        [MethodImpl(Inline)]
        FolderPath AppSubDir(Type t)            
            => AppSubDir(TypeFolder(t));

        [MethodImpl(Inline)]
        FolderPath AppDataDir(Type t)            
            => (AppDir + DataFolder) + TypeFolder(t);

        FileExtension HexExt => FileExtensions.Hex;

        FileExtension AsmExt => FileExtensions.Asm;

        FileExtension CilExt => FileExtensions.Il;

        FileExtension LogExt => FileExtensions.Log;

        [MethodImpl(Inline)]
        FileName OpFileName(OpIdentity id, FileExtension ext)
            => id.ToLegalFileName(ext);

        [MethodImpl(Inline)]
        FileName OpFileName(PartId part, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(part.Format(), Chars.Dot, OpFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName OpFileName(ApiHostUri host, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), Chars.Dot, host.Name, Chars.Dot, OpFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName HostFileName(ApiHostUri host, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), ext);

    }
}