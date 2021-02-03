//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SymbolAttribute : Attribute
    {
        public string Symbol {get;}


        public string Description {get;}

        public SymbolAttribute(string symbol)
        {
            Symbol = symbol;
            Description = string.Empty;
        }

        public SymbolAttribute(string symbol, string description)
        {
            Symbol = symbol;
            Description = description;
        }
    }
}