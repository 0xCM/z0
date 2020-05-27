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

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrStruct<T> : IClrType<ClrStruct<T>,ClrStruct,T>  
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

        public ClrTypeKind Kind => ClrTypeKind.Struct;        
    }
}