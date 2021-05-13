//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public abstract class CodeSymbols<H,T> : ICodeSymbols<H,T>
        where H : ICodeSymbols<H,T>, new()
        where T : ICodeSymbol
    {
        protected Index<T> Data;

        protected CodeSymbols()
        {
            Data = sys.empty<T>();
        }

        protected CodeSymbols(uint count)
        {
            Data = alloc<T>(count);
        }
        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        internal ref T Subject(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public CodeSymbol<H,T> Symbol(uint index)
            => new CodeSymbol<H,T>(this,index);

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public static H Empty
        {
            [MethodImpl(Inline)]
            get => new H();
        }
    }
}