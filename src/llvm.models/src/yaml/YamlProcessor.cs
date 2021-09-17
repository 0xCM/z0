//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;
    using static Root;
    using static FileTypes;

    public class YamlTokenProcessor
    {
        Symbols<YamlTokenKind> Symbols;

        public YamlTokenProcessor()
        {
            Symbols = Z0.Symbols.index<YamlTokenKind>();

        }

        public void Process(YamlTokenFile src)
        {

        }

    }

}