//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;

    using R = System.Reflection;

    partial struct DataModel
    {
        public struct Assembly : ILanguageTable<Assembly>
        {

        }

        public struct AssemblyDescriptor
        {
            public string SimpleName;

            public Version Version;

            public string Culture;

            public R.AssemblyNameFlags NameFlags;

            public R.AssemblyContentType ContentType;

            public BinaryCode PublicKey;
        }
    }
}