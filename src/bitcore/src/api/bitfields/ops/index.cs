//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct BitFields
    {
      public static BitFieldIndex<I,W> index<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
        {
            var indices = typeof(I).LiteralFields();
            var widths = typeof(W).LiteralFields();
            var count = indices.Length;
            var indexed = new BitFieldIndexEntry<I,W>[count];
            for(var i=0; i < count; i++)
                indexed[i] = entry<I,U,W>(i, indices, widths);
            return indexed;
        }

        static BitFieldIndexEntry<I,W> entry<I,U,W>(int i, FieldInfo[] indices, FieldInfo[] widths)
            where U : unmanaged
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => new BitFieldIndexEntry<I,W>(
                    ClrEnums.literal<I,U>(Numeric.force<int,U>(i)), indices[i].Name, (W)widths[i].GetRawConstantValue());
    }
}