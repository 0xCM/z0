//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static SuperSym supersym(int n)
            => n switch {
            0 => SuperSym.Sup0,
            1 => SuperSym.Sup1,
            2 => SuperSym.Sup2,
            3 => SuperSym.Sup3,
            4 => SuperSym.Sup4,
            5 => SuperSym.Sup5,
            6 => SuperSym.Sup6,
            _  => SuperSym.H            
        };   

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ReadOnlySpan<BinarySymbol> src)
            => cast<BinarySymbol,char>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ReadOnlySpan<HexSymbol> src)
            => cast<HexSymbol,char>(src);
    }
}