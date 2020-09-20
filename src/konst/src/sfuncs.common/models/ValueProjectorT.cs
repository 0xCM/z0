//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ValueProjector<T> : IValueProjector<T>
        where T : struct
    {
        internal readonly BoxedValueMap<T> Delegate;

        [MethodImpl(Inline)]
        public static implicit operator BoxedValueMap<T>(ValueProjector<T> src)
            => src.Delegate;

        [MethodImpl(Inline)]
        public ValueProjector(BoxedValueMap<T> src)
            => Delegate = src;

        [MethodImpl(Inline)]
        public ref T Project(object src)
            => ref z.unbox<T>(Delegate((ValueType)src));

        [MethodImpl(Inline)]
        public ref T Project(ValueType src)
            => ref z.unbox<T>(Delegate(src));

        ValueType IValueProjector.Project(ValueType src)
            => Delegate(src);
    }
}