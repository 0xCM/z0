//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CodeRepoLink
    {
        public string Http {get;}

        [MethodImpl(Inline)]
        public CodeRepoLink(string http)
        {
            Http = http;
        }

        [MethodImpl(Inline)]
        public static implicit operator CodeRepoLink(string src)
            => new CodeRepoLink(src);
    }

    public readonly struct CodeRepoLinks
    {
        public static CodeRepoLink DiaSymReaderXmlConverter => "https://github.com/dotnet/symreader-converter/src/Microsoft.DiaSymReader.Converter.Xml";

        public static CodeRepoLink DiaSymReaderConverter => "https://github.com/dotnet/symreader-converter/src/Microsoft.DiaSymReader.Converter";

    }

    public readonly struct ExternalModules
    {

    }

    public readonly struct ExternalModule
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public ExternalModule(string name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator ExternalModule(string name)
            => new ExternalModule(name);
    }

    public readonly struct ModuleArrow
    {



    }

    public readonly struct ModuleArrows
    {

    }

}