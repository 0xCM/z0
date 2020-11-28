//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static void emit<T>(T[] src, StreamWriter dst)
            where T : struct, ITabular
                => Sinks.deposit(Table.rows(src), dst);

        [Op]
        public static void emit(ReadOnlySpan<string> rows, FileStream dst)
            => Sinks.deposit(rows, Sinks.create<string>(dst));

        [MethodImpl(Inline)]
        public static void emit<T>(T[] src, FileStream dst)
            where T : struct, ITabular
                => emit(Table.rows(src), dst);
    }
}