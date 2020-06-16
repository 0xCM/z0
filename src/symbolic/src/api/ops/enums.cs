//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using static Konst;
    using static Control;

    partial class Symbolic     
    {
        public static @enum<E,T>[] enums<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dataset = Enums.dataset<E,T>();
            return enums<E,T>(dataset, new @enum<E,T>[dataset.EntryCount]);
        }

        public static @enum<E,T>[] enums<E,T>(EnumDataset<E,T> dataset, @enum<E,T>[] buffer)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = span(buffer);
            for(var i=0; i<dst.Length; i++)
            {
                var entry = dataset[i];
                Control.seek(dst,i) = @enum.define(entry.Token, entry.Index, entry.Name, entry.Literal, entry.Scalar);
            }
            return buffer;
        }
    }
}