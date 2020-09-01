//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CachedSource<T>
        where T : struct
    {
        readonly T[] Data;

        readonly int[] Current;
     
        [MethodImpl(Inline)]
        public CachedSource(T[] src, int[] index)
        {
            Data = src;
            Current = index;
        }   

        ref int Index
        {
            [MethodImpl(Inline)]
            get => ref Current[0];
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
        
        [MethodImpl(Inline)]
        int Take()
        {
            var i = Index;
            if(i < CellCount - 1)
                Index++;
            else
                Index = 0;
            return i;
        }
        
        [MethodImpl(Inline)]
        public ref readonly T Next()
            => ref Data[Take()];
    }
}