//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct Records
    {
        public static bool parse<T>(RecordFields fields, string src, out T dst)
            where T : struct, IRecord<T>
        {
            dst = default;

            var parts = src.SplitClean(Chars.Pipe);
            if(parts.Length == fields.Length)
            {

            }

            return false;
        }

    }
}