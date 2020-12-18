//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct FileKind : IKinded<ulong>
    {
        public Type Type {get;}

        public ulong Kind {get;}

        [MethodImpl(Inline)]
        public FileKind(Type type, ulong kind)
        {
            Type = type;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public FileKind(ulong kind)
        {
            Type = typeof(ulong);
            Kind = kind;
        }
    }

    public readonly struct FileType
    {
        public MimeType ContentType {get;}

        public Index<FS.FileExt> Extensions {get;}

        [MethodImpl(Inline)]
        public FileType(MimeType kind, FS.FileExt[] extensions)
        {
            ContentType = kind;
            Extensions = extensions;
        }

        public string Format()
            => FileTypes.format(this);

        public override string ToString()
            => Format();
    }
}