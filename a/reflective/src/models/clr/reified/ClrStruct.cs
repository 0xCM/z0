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

    using static Reflective;

    public readonly struct ClrStruct : IClrType<ClrStruct>
    {
        public Type Subject {get;}

        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => ClrType.From(Subject);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrStruct src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static ClrStruct From(Type src)
            => src.IsStruct() ? new ClrStruct(src) : throw Unsupported.define(src);

        [MethodImpl(Inline)]
        public static ClrStruct<T> From<T>()
            where T : struct
                => default;

        [MethodImpl(Inline)]
        internal static ClrStruct Unchecked(Type src)
            => new ClrStruct(src);

        [MethodImpl(Inline)]
        public ClrStruct(Type src)
        {
            this.Subject = src;
        }

        public IEnumerable<ClrStruct> NestedTypes 
            => Subject.GetNestedTypes().Select(t => new ClrStruct(t));
    }

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrStruct<T> : IClrType<ClrStruct<T>, ClrStruct, T>  
        where T : struct
    {
        public Type Subject => typeof(T);

        public ClrStruct Untyped 
        {
            [MethodImpl(Inline)]
            get => ClrStruct.Unchecked(this.Subject);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrStruct(ClrStruct<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct<T> src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrStruct<T> src)
            => ClrType.From<T>();

        public IEnumerable<ClrStruct> NestedTypes 
        {
            [MethodImpl(Inline)]
            get => Untyped.NestedTypes;
        }
    }
}