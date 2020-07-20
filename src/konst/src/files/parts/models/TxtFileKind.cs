//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TxtFileKind
    {
        public const string ExtensionName = "txt";

        public const PartFileClass FileKind = PartFileClass.Txt;

        public PartFileClass Classifier 
            => FileKind;

        public string Ext 
            => ExtensionName;

        public string Format()
            => ExtensionName;

        public override string ToString()
            => ExtensionName;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(TxtFileKind src)
            => new PartFileKind(FileKind, ExtensionName);
    }
}