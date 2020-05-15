//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    public interface ILocalArchive : IService
    {
        FolderPath ArchiveRoot {get;}

        void Clear() 
            => ArchiveRoot.Clear();

        void Clear(FolderName folder) 
            => SubFolder(folder).Clear();

        FolderPath SubFolder(FolderName folder) 
            => ArchiveRoot + folder;
    }

    public interface IRecordArchive<T> : ILocalArchive
        where T : ITabular
    {
        FilePath Deposit(T[] src, FileName filename)        
        {
            var dst = ArchiveRoot + filename;
            src.Save(dst);
            return dst;
        }           

        FilePath Deposit(T[] src,  FolderName folder, FileName filename)       
        {
            var dst = (ArchiveRoot + folder) + filename;
            src.Save(dst);
            return dst;
        }    
    }

    public interface IPublicArchive : IRecordArchive<PatternSummary>
    {
        
    }

    partial class Archives
    {
        public readonly struct PublicArchive : IPublicArchive
        {
            [MethodImpl(Inline)]
            public static IPublicArchive Service(FolderPath root)
                => new PublicArchive(root);

            public FolderPath ArchiveRoot {get;}


            [MethodImpl(Inline)]
            public PublicArchive(FolderPath root)
            {
                this.ArchiveRoot = root;
            }
        }
    }
}