//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CilFileKind  : IFileKind<PartFileClass>
    {
        public const string ExtensionName = "cil";

        public const PartFileClass FileKind = PartFileClass.Cil;

        [MethodImpl(Inline)]
        public static implicit operator PartFileKind(CilFileKind src)
            => PartFileKinds.define(FileKind,ExtensionName);

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