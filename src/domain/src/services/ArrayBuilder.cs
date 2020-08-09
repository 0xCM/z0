//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct ArrayBuilder
    {
        [MethodImpl(Inline)]
        public static ArrayBuilder<T> Create<T>(int? capacity = null)
            => new ArrayBuilder<T>(capacity ?? 128);

        [MethodImpl(Inline)]
        public static ArrayBuilder<T> Create<T>(params T[] src)
            => new ArrayBuilder<T>(src);
    }
    
    public readonly struct ArrayBuilder<T>
    {
        readonly List<T> Items;

        [MethodImpl(Inline)]
        internal ArrayBuilder(int capacity)
        {
            Items = new List<T>(capacity);
        }

        [MethodImpl(Inline)]
        internal ArrayBuilder(params T[] src)
        {
            Items = new List<T>();
            Items.AddRange(src);
        }

        [MethodImpl(Inline)]
        public void Include(params T[] src)
            => Items.AddRange(src);

        [MethodImpl(Inline)]
        public T[] Create(bool clear = true)
        {
            var dst = Items.ToArray();
            if(clear)
                Items.Clear();
            return dst;
        }
    }
}