//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DocFileKind
    {
        public const string ExtensionName = "doc";

        public const PartFileClass FileKind = PartFileClass.Doc;

        public PartFileClass Classifier 
            => FileKind;

        public string Ext 
            => ExtensionName;

        public string Format()
            => ExtensionName;

        public override string ToString()
            => ExtensionName;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(DocFileKind src)
            => new PartFileKind(FileKind, ExtensionName);
    }
}