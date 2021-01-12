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
    }

    /// <summary>
    /// Represents a primary key
    /// </summary>
    public readonly struct PK<T>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public PK(uint value)
            => Value = value;
    }

    /// <summary>
    /// Represents heap key
    /// </summary>
    public readonly struct HK<T>
    {
        public uint Value {get;}


        [MethodImpl(Inline)]
        public HK(uint value)
            => Value = value;
    }
}