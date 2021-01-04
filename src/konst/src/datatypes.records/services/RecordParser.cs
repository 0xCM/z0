//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    public readonly struct RecordParser<T> : IRecordParser<T>
        where T : struct
    {
        static readonly RecordFields Fields;

        static RecordParser()
        {
            Fields = Records.fields<T>();
        }

        public Outcome Parse(string src, out T dst)
        {

            dst = default;
            return default;
        }
    }
}