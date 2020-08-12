//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Konst;

    partial struct FileSystem
    {
        public readonly struct FileName : IFso<FileName>
        {
            public PathPart Name {get;}

            public Extension Ext 
            {
                [MethodImpl(Inline)]
                get => new Extension(Path.GetExtension(Name.Name));
            }
            
            [MethodImpl(Inline)]
            public FileName(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public FileName(PathPart name, Extension ext)
                => Name = text.format(ExtPattern, name, ext);

            public bool HasExtension
            {
                [MethodImpl(Inline)]
                get => Path.GetExtension(z.span(Name.Name)).Length != 0;
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

            const string ExtPattern = "{0}.{1}";

            const string Pattern = "{0}";
            
            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();
        }        
    }
}