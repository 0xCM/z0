//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct JsonFileKind
    {
        public const string ExtensionName = "json";

        public const PartFileClass FileKind = PartFileClass.Json;

        public PartFileClass Classifier 
            => FileKind;

        public string Ext 
            => ExtensionName;

        public string Format()
            => ExtensionName;

        public override string ToString()
            => ExtensionName;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(JsonFileKind src)
            => new PartFileKind(FileKind, ExtensionName);
    }
}