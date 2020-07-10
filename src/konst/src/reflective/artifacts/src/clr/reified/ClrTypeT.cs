//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Represents a parametrically-identified clr type
    /// </summary>
    public readonly struct ClrType<T> : IClrType<ClrType<T>,ClrType,T>
    {
        public Type Subject => typeof(T);

        public ClrType Untyped 
        {
            [MethodImpl(Inline)]
            get => ClrType.From(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrType<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType<T> src)
            => src.Subject;

        public IEnumerable<ClrType> NestedTypes 
            => Untyped.NestedTypes;

        public ClrTypeKind Kind => ClrTypeKind.None;
    }
}