//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class TableModels
    {
        Type[] Data;

        Type Empty;

        public uint Count {get;}

        public static TableModels create()
            => new TableModels(typeof(TableModels).GetNestedTypes());

        TableModels(Type[] src)
        {
            Data = src;
            Count = (uint)src.Length;
            Empty = typeof(void);
        }

        [MethodImpl(Inline)]
        public Type Model(uint index)
            => index < Count ? Data[index] : Empty;

        public Type this[uint index]
            => Model(index);

        public ReadOnlySpan<Type> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public readonly struct T00
        {
            public readonly byte F00;

            public readonly ushort F01;

            public readonly uint F02;

            public readonly uint F03;
        }
    }
}