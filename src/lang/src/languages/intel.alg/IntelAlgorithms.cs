//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct IntelAlgorithms
    {
        const Z0.NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static BitVector bitvector(string name, ushort size)
            => new BitVector(name,size);

        [MethodImpl(Inline), Op]
        public static BitSection section(ushort min, ushort max)
            => new BitSection(min,max);

        [MethodImpl(Inline), Op]
        public static Operator op(string symbol, OperatorKind kind)
            => new Operator(symbol, kind);

        [MethodImpl(Inline), Op]
        public static Function function(string name)
            => new Function(name);
    }
}