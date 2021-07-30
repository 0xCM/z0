//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct SymbolStores
    {
        const NumericKind Closure = UnsignedInts;

        public static SymbolStore<T> create<T>(ushort capacity)
            => new SymbolStore<T>(capacity);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static bit deposit<T>(in T src, ref SymbolStore<T> dst, out Symbol s)
            => dst.Deposit(src, out s);

        public readonly struct Symbol
        {
            public uint Key {get;}

            [MethodImpl(Inline)]
            public Symbol(uint index)
            {
                Key = index;
            }

            public string Format()
                => Key.ToString();

            public override string ToString()
                => Format();
        }

        public struct SymbolStore<T>
        {
            readonly Index<T> Data;

            uint k;

            internal SymbolStore(ushort capacity)
            {
                Data = alloc<T>(capacity);
                k = 0;
            }

            [MethodImpl(Inline)]
            public T Extract(in Symbol src)
                => Data[src.Key];

            [MethodImpl(Inline)]
            public bit Deposit(in T src, out Symbol dst)
            {
                if(k < Data.Length - 1)
                {
                    Data[k] = src;
                    dst = new Symbol((ushort)k);
                    k++;
                    return true;
                }
                else
                {
                    dst = default;
                    return false;
                }
            }
        }
    }
}