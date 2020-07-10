//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiAsmFile  : IFileKind<ApiAsmFile,PartFileKind>
    {
        public const string ExtensionName = "asm";

        public const PartFileKind Classifier = PartFileKind.Asm;

        [MethodImpl(Inline)]
        public static implicit operator FileKind<PartFileKind>(ApiAsmFile src)
            => FileKinds.define(Classifier, ExtensionName);            

        [MethodImpl(Inline)]
        public static implicit operator FileKind(ApiAsmFile src)
            => FileKinds.define(Classifier,ExtensionName);

        public PartFileKind Kind 
        {
            [MethodImpl(Inline)]
            get => Classifier;
        }

        public StringRef Ext 
        {
            [MethodImpl(Inline)]
            get => FileTypeLiterals.Asm;
        }
    }
}