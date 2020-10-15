//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct ClrRecords
    {
        [Op]
        public static void project(ReadOnlySpan<ClrHandle> src, Span<HandleRecord> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(src,i);
                ref var record = ref seek(dst,i);
                record.Address = handle.Pointer.Address;
                record.Key = handle.Key;
                record.Kind = handle.Kind;
            }
        }

        [Op]
        public static uint project(ReadOnlySpan<HandleRecord> src,  StreamWriter dst)
        {
            var count = src.Length;
            var counter = 0u;
            var formatter = TableRows.formatter<HandleRecord>(HandleRecord.RenderWidths);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                var row = formatter.FormatRow(record);
                dst.WriteLine(row);
                counter++;
            }
            return counter;
        }
    }
}