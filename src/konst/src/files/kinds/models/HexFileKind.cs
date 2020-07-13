//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexFileKind  : IFileKind<PartFileClass>
    {
        public const string ExtensionName = "hex";

        public const PartFileClass FileKind = PartFileClass.Hex;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(HexFileKind src)
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
        }    }
}