//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static unsafe E eval<E,V>(V v)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<E>((E*)&v);

        public static void emit<E>(EnumLiteral[] src, FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var literals = @readonly(src);
            var count = literals.Length;
            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<E>());
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(literals,i).DelimitedText(FieldDelimiter));
        }
    }
}