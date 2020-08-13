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
    
    public readonly struct ArrayBuilder<T>
    {
        readonly List<T> Items;

        [MethodImpl(Inline)]
        internal ArrayBuilder(int capacity)
            => Items = new List<T>(capacity);

        [MethodImpl(Inline)]
        internal ArrayBuilder(params T[] src)
        {
            Items = new List<T>();
            Items.AddRange(src);
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Items.Count;
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

        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
        {
            ref var target = ref z.first(dst);
            for(var i=0; i<Items.Count; i++)
                z.seek(target,i) = Items[i];
        }

        /// <summary>
        /// Copies the accumulated items to the target beginning at a specified offset
        /// </summary>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst, uint offset)
        {
            ref var target = ref z.seek(dst, offset);
            for(var i=offset; i<Items.Count; i++)
                z.seek(target,i) = Items[(int)i];
        }        
    }
}