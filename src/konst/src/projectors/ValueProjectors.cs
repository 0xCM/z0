//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    [ApiHost]
    public readonly struct Projectors
    {
        [MethodImpl(Inline)]
        public static ref T project<S,T>(ValueProjector<S,T> f, in S x)
            where S : struct
            where T : struct
                => ref f.Project(x);

        [MethodImpl(Inline)]
        public static ref T project<T>(ValueProjector<T> f, in T x)
            where T : struct
                => ref f.Project(x);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T project<T>(in ValueProjector<T,T> f, in T x)
            where T : unmanaged
                => ref f.Project(x);

        [MethodImpl(Inline), Op]
        public static ValueProjector define(Func<object,object> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(Inline), Op]
        public static ValueProjector define(Func<ValueType,ValueType> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueProjector<T> define<T>(Func<object,T> f)
            where T : struct
                => ValueProjector.from(f);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueProjector<T> define<T>(Func<ValueType,T> f)
            where T : struct
                => new ValueProjector<T>(convert(f));

        [MethodImpl(Inline)]
        public static ValueProjector<S,T> define<S,T>(Func<S,T> f)
            where S : struct
            where T : struct
                => new ValueProjector<S,T>(convert(f));

        [MethodImpl(Inline), Op]
        public static ValueProjector define(ValueFunc f)
            => new ValueProjector(f);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueProjector<T> define<T>(ValueFunc<T> f)
            where T : struct
                => new ValueProjector<T>(f);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueFunc<T> convert<T>(Func<object,T> f)
            where T : struct
                => ProjectorProxy.valuefunc(f);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ValueFunc<T> convert<T>(Func<ValueType,T> f)
            where T : struct
                => new ProjectorProxy<T>(x => f((ValueType)x)).F;

        [MethodImpl(Inline)]
        public static ValueProjector<S,T> define<S,T>(ValueFunc<S,T> f)
            where S : struct
            where T : struct
                => new ValueProjector<S,T>(f);        

        [MethodImpl(Inline)]
        public static ValueFunc<S,T> convert<S,T>(Func<S,T> f)
            where S : struct
            where T : struct
                => new ProjectorProxy<S,T>(f).F;        
    }
}