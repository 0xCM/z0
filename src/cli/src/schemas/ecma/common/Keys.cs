//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a foreign key
    /// </summary>
    public readonly struct FK<T>
    {
        public Type ForeignType => typeof(T);

        public uint Value {get;}

        [MethodImpl(Inline)]
        public FK(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator FK<T>(uint value)
            => new FK<T>(value);

        [MethodImpl(Inline)]
        public static implicit operator FK<T>(int value)
            => new FK<T>((uint)value);
    }
}