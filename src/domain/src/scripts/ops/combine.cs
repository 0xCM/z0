//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [Op]
        public static Symbol combine(Symbol a, Symbol b)
            => new Symbol(string.Format("{0}{1}", a, b));

        [Op]
        public static Dir combine(Dir a, Dir b)
        {
            var symbol = a.Symbol + PathSep + b.Symbol;
            var value = Path.Combine(a.Value, b.Value);
            return (symbol,value);
        }
    }
}