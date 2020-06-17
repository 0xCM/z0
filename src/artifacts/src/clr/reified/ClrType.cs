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
            this.Kind = ClrTypeKind.None;
        }

        public IEnumerable<ClrType> NestedTypes 
            => Subject.GetNestedTypes().Select(t => new ClrType(t));

        public ClrTypeKind Kind {get;}
    }
}