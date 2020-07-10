//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiHexFile  : IFileKind<ApiHexFile,PartFileKind>
    {
        public const string ExtensionName = "hex";

        public const PartFileKind Classifier = PartFileKind.Hex;

        [MethodImpl(Inline)]
        public static implicit operator FileKind<PartFileKind>(ApiHexFile src)
            => FileKinds.define(Classifier, ExtensionName);            

        [MethodImpl(Inline)]
        public static implicit operator FileKind(ApiHexFile src)
            => FileKinds.define(Classifier,ExtensionName);

        public PartFileKind Kind 
        {
            [MethodImpl(Inline)]
            get => Classifier;
        }

        public StringRef Ext 
        {
            [MethodImpl(Inline)]
            get => FileTypeLiterals.Hex;
        }
    }
}