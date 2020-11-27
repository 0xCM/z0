//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    partial struct z
    {
        [Op]
        public static void deposit(ReadOnlySpan<string> rows, ISink<string> dst)
        {
            for(var i=0u; i<rows.Length; i++)
            {
                dst.Deposit(skip(rows, i));
                dst.Deposit(Eol);
            }
        }

        [Op]
        public static void deposit(ReadOnlySpan<string> rows, StreamWriter dst)
            => z.deposit(rows, Streams.sink<string>(dst));
    }
}