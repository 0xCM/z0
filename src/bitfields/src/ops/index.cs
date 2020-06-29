//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;    

    partial class BitFields
    {
       public static BitFieldIndex<I,W> index<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
        {
            var indices = typeof(I).LiteralFields().ToArray();
            var widths = typeof(W).LiteralFields().ToArray();
            var count = indices.Length;
            var indexed = new BitFieldIndexEntry<I,W>[count];
            for(var i=0; i < count; i++)
                indexed[i] = entry<I,U,W>(i, indices, widths);
            return indexed;
        }

        [MethodImpl(Inline)]
        static BitFieldIndexEntry<I,W> entry<I,U,W>(int i, FieldInfo[] indices, FieldInfo[] widths)
            where U : unmanaged
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => new BitFieldIndexEntry<I,W>(
                    index: Enums.literal<I,U>(NumericCast.convert<int,U>(i)), 
                    name: indices[i].Name,  
                    width: (W)widths[i].GetRawConstantValue()
                    );
    }
}