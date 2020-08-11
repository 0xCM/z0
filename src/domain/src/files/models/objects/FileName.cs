//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {
        public readonly struct FileName
        {
            public PathPart Name {get;}

            public Extension Ext {get;}
            
            [MethodImpl(Inline)]
            public FileName(PathPart name)
            {
                Name = name;
                Ext = Extension.Empty;
            }

            [MethodImpl(Inline)]
            public FileName(PathPart name, Extension ext)
            {
                Name = name;
                Ext = ext;
            }

            public bool HasExtension
            {
                [MethodImpl(Inline)]
                get => Ext.IsNonEmpty;
            }
            
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            public static FileName Empty 
            {
                [MethodImpl(Inline)]
                get => new FileName(PathPart.Empty);
            }
        }        
    }
}