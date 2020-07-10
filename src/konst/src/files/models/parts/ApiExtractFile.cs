//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = PartFileKind;

    public readonly struct ApiExtractFile : IFileKind<ApiExtractFile,PartFileKind>
    {
        public const string ExtensionName = "x.csv";

        public const PartFileKind Classifier = PartFileKind.Extract;

        [MethodImpl(Inline)]
        public static implicit operator FileKind<PartFileKind>(ApiExtractFile src)
            => FileKinds.define(Classifier,ExtensionName);

        [MethodImpl(Inline)]
        public static implicit operator FileKind(ApiExtractFile src)
            => FileKinds.define(Classifier,ExtensionName);

        public PartFileKind Kind 
        {
            [MethodImpl(Inline)]
            get => Classifier;
        }

        public StringRef Ext 
        {
            [MethodImpl(Inline)]
            get => ExtensionName;
        }
    }

}