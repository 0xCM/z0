//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct LiteralIndex<F>
        where F : unmanaged
    {
        readonly FieldInfo[] Fields;

        public readonly string[] Names;

        public readonly F[] Values;

        [MethodImpl(Inline)]
        internal LiteralIndex(FieldInfo[] fields, string[] names, F[] values)
        {
            Fields = fields;
            Names = names;
            Values = values;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Fields.Length;
        }

        public F[] Literals
        {
            [MethodImpl(Inline)]
            get => Values;
        }

        [MethodImpl(Inline)]
        public uint Index(in F f)
            => Numeric.scalar(f, out uint _ );

        [MethodImpl(Inline)]
        public F Literal(uint index)
            => Literals[index];

        public F this[uint index]
        {
            [MethodImpl(Inline)]
            get => Literal(index);
        }
    }
}