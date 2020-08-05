//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines common asm workfow configuration settings
    /// </summary>
    public readonly struct AsmArchiveConfig
    {
        [MethodImpl(Inline)]
        public AsmArchiveConfig(FolderPath root)
        {
            ArchiveRoot = root;
        }

        /// <summary>
        /// Specifies the root emisson folder, bwlow which all data will be written
        /// </summary>
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public static implicit operator ArchiveConfig(AsmArchiveConfig src)
            => new ArchiveConfig(src.ArchiveRoot);        
    }
}