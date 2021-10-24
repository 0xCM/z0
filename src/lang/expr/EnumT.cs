//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Defines an indexed sequence of homogenous literal values
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Enum<V>
    {
        public Label Name {get;}

        Index<Literal<V>> Data;

        [MethodImpl(Inline)]
        public Enum(Label name, Literal<V>[] src)
        {
            Name = name;
            Data = src;
        }

        public ref Literal<V> this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref Literal<V> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public uint LiteralCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<Literal<V>> Literals
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}