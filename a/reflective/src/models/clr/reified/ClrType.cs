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

    using static Seed;

    public readonly struct ClrType : IClrType<ClrType>
    {
        public Type Subject {get;}
        
        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => this;
        }

        [MethodImpl(Inline)]
        public static ClrType From(Type src)
            => new ClrType(src);

        [MethodImpl(Inline)]
        public static ClrType<T> From<T>()
            => default;

        [MethodImpl(Inline)]
        public static implicit operator ClrType(Type src)
            => From(src);         

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType src)
            => src.Subject;
        
        [MethodImpl(Inline)]
        public ClrType(Type src)
        {
            this.Subject = src;
        }

        public IEnumerable<ClrType> NestedTypes 
            => Subject.GetNestedTypes().Select(t => new ClrType(t));
    }

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
    }
}