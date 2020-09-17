//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class Enums
    {
        public static WfDataFlow<EnumLiteral[],FilePath> emit<E>(EnumLiteral[] src, FilePath dst)
            where E : unmanaged, Enum
        {
            var literals = @readonly(src);
            var count = literals.Length;
            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<E>());
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(literals,i).DelimitedText(FieldDelimiter));
            return (src,dst);
        }
    }
}