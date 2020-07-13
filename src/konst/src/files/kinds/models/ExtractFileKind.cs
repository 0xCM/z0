//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExtractFileKind : IFileKind<PartFileClass>
    {
        public const string ExtensionName = "x.csv";

        public const PartFileClass FileKind = PartFileClass.Extract;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(ExtractFileKind src)
            => PartFileKinds.define(FileKind, ExtensionName);

        public PartFileClass Classifier 
        {
            [MethodImpl(Inline)]
            get => FileKind;
        }

        public FileExt Ext 
        {
            [MethodImpl(Inline)]
            get => ExtensionName;
        }
    }

}