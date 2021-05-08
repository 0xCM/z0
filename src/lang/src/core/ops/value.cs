//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Value<T> value<T>(DataType type, T content)
            => new Value<T>(type,content);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OperandValue value<T>(Operand operand, T value)
            => new OperandValue<T>(operand,value);
    }
}