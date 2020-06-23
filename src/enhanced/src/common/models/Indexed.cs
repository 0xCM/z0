//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures a hash code for structured content
    /// </summary>
    public readonly struct Indexed<T> : IIndex<Indexed<T>,T>
    {
        public readonly T[] Data;
        
        [MethodImpl(Inline)]
        public static implicit operator T[](Indexed<T> src)
            => src.Data;
        
        [MethodImpl(Inline)]
        public static implicit operator Indexed<T>(T[] src)
            => new Indexed<T>(src);

        [MethodImpl(Inline)]
        public Indexed(T[] content)
        {
            Data = content;            
        }        
        
        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Data.Length;
        }        
    }
}