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

    public readonly struct ClrStruct : IClrType<ClrStruct>
    {
        public Type Subject {get;}

        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => ClrType.From(Subject);
        }

        public string Identifier

        {
            [MethodImpl(Inline)]
            get => Subject.Name;
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

        public ClrTypeKind Kind => ClrTypeKind.Struct;
    }
}