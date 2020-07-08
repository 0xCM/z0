//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial struct Projectors
    {
        [MethodImpl(Inline), Op]
        public static ValueProjector create(BoxedValueMap f)
            => new ValueProjector(f);

        [MethodImpl(Inline), Op]
        public static ValueProjector create(Func<object,object> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(Inline), Op]
        public static ValueProjector create(Func<ValueType,ValueType> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(Inline)]
        public static ValueProjector<T> create<T>(Func<object,T> f)
            where T : struct
                => create(f, sys.alloc<T>(1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueProjector<T> create<T>(Func<ValueType,T> f)
            where T : struct
                => new ValueProjector<T>(convert(f));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueProjector<T> create<T>(BoxedValueMap<T> f)
            where T : struct
                => new ValueProjector<T>(f);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueProjector<T,T> create<T>(ValueMap<T,T> f)
            where T : struct
                => create<T,T>(f);

        [MethodImpl(Inline)]
        public static ValueProjector<S,T> create<S,T>(ValueMap<S,T> f)
            where S : struct
            where T : struct
                => new ValueProjector<S,T>(f);        

        [MethodImpl(Inline)]
        public static ValueProjector<S,T> create<S,T>(Func<S,T> f)
            where S : struct
            where T : struct
                => create(f, sys.alloc<T>(1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        static ValueProjector<T> create<T>(Func<object,T> f, T[] dst)
            where T : struct
                => new ValueProjector<T>(boxed(f, dst));        

        [MethodImpl(Inline)]
        static ValueProjector<S,T> create<S,T>(Func<S,T> f, T[] dst)
            where S : struct
            where T : struct
                => new ValueProjector<S,T>(convert(f,dst));
    }
}