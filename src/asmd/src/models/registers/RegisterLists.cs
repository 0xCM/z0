//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using W = RegisterWidth;
    using api = RegisterKinds;

    partial class RegisterKinds
    {
        public static EnumLiterals<RegisterSymbol> Symbols
            => Enums.literals<RegisterSymbol>();

        public static RegisterKind[] SymbolKinds
            => Symbols.Convert<RegisterKind>();

        public IEnumerable<RegisterModel> Models
            => SymbolKinds.Select(k => new RegisterModel(
                    api.identify(k), 
                    (RegisterSymbol)k, 
                    api.width(k), 
                    api.slot(k)));

        public static IEnumerable<RegisterKind> Gp8 
            => SymbolKinds.Where(r => width(r) == W.W8);

        public static IEnumerable<RegisterKind> Gp16 
            => SymbolKinds.Where(r => width(r) == W.W16);

        public static IEnumerable<RegisterKind> Gp32
            => SymbolKinds.Where(r => width(r) == W.W32);

        public static IEnumerable<RegisterKind> Gp64
            => SymbolKinds.Where(r => width(r) == W.W64);

        public static IEnumerable<RegisterKind> V128
            => SymbolKinds.Where(r => width(r) == W.W128);

        public static IEnumerable<RegisterKind> V256
            => SymbolKinds.Where(r => width(r) == W.W256);

        public static IEnumerable<RegisterKind> V512
            => SymbolKinds.Where(r => width(r) == W.W512);
    }
}
