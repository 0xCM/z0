//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiParseFile  : IFileKind<ApiParseFile,PartFileKind>
    {
        public const string ExtensionName = "p.csv";

        public const PartFileKind Classifier = PartFileKind.Parsed;

        [MethodImpl(Inline)]
        public static implicit operator FileKind<PartFileKind>(ApiParseFile src)
            => FileKinds.define(Classifier, ExtensionName);
        
        [MethodImpl(Inline)]
        public static implicit operator FileKind(ApiParseFile src)
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