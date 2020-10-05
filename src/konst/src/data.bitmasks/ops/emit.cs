//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitMasks
    {
        [Op]
        public static uint emit(Type src, FS.FilePath dst)
        {
            var records = @readonly(rows(src));
            var count = records.Length;
            var f = formatter();
            using var writer = dst.Writer();
            writer.WriteLine(f.HeaderText);

            for(var i=0u; i<count; i++)
                writer.WriteLine(f.Format(skip(records,i)));

            return (uint)count;
        }

        [MethodImpl(Inline), Op]
        public static uint emit(FS.FilePath dst)
            => emit(typeof(BitMasks.Literals), dst);
    }
}