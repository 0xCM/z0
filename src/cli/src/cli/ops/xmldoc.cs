//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;
    using System.Reflection.PortableExecutable;
    using Microsoft.CodeAnalysis;

    using static Part;
    using static core;

    partial struct Cli
    {
       public static XmlDocProvider xmldoc(FS.FilePath src)
            => new XmlDocProvider(src.Name);
    }
}