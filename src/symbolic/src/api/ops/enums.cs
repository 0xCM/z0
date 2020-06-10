//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Symbolic     
    {
        public static @enum<E,T>[] enums<E,T>(EnumDataset<E,T> dataset)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var count = dataset.EntryCount;
            var buffer = Control.alloc<@enum<E,T>>(count);
            var dst = buffer.ToSpan();
            for(var i=0; i<count; i++)
            {
                var entry = dataset[i];
                Control.seek(dst,i) = Symbolic.@enum(entry.Token, entry.Index, entry.Name, entry.Literal, entry.Scalar);
            }
            return buffer;
        }
    }
}