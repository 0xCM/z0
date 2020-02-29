//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    public readonly struct AsmFunctionList : IAnyListProvider<AsmFunction>
    {
        public static AsmFunctionList Empty => Define(new AsmFunction[]{});
        
        [MethodImpl(Inline)]
        public static AsmFunctionList Define(AsmFunction[] src)
            => new AsmFunctionList(src);

        [MethodImpl(Inline)]
        AsmFunctionList(AsmFunction[] src)
            => Items = src;
        
        public AnyList<AsmFunction> Items {get;}
    }

    public static class AnyList
    {
        [MethodImpl(Inline)]
        public static AnyList<T> Define<T>(T[] src)
            => new AnyList<T>(src);
         
        [MethodImpl(Inline)]
        public static AnyList<T> Define<T>(IEnumerable<T> src)
            => new AnyList<T>(src.ToArray());
    }

    public interface IAnyListProvider<T>
    {
        AnyList<T> Items {get;}
    }
    public readonly struct AnyList<T> : IReadOnlyList<T>
    {
        public static AnyList<T> Empty => new AnyList<T>(new T[]{});
        
        readonly T[] Items;

        [MethodImpl(Inline)]
        public AnyList(T[] items)
            => this.Items = items;

        [MethodImpl(Inline)]
        public static implicit operator T[](AnyList<T> src)
            => src.Items;

        [MethodImpl(Inline)]
        public static implicit operator AnyList<T>(T[] src)
            => new AnyList<T>(src);

        public T this[int index] 
        {
            [MethodImpl(Inline)]
            get => Items[index];
        }

        public int Count 
        {
            [MethodImpl(Inline)]
            get => Items.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Items.Length;
        }

        public bool IsEmpty => Items == null || Items.Length == 0;

        public IEnumerator<T> GetEnumerator()
            => ((IReadOnlyList<T>)Items).GetEnumerator();            
        
        IEnumerator IEnumerable.GetEnumerator()
            => Items.GetEnumerator();
    }   
}