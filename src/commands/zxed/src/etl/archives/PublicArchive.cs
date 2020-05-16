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

    public interface IPublicArchive : ITabularArchive<PatternField,PatternSummary>
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