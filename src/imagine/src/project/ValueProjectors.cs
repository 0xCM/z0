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
        [MethodImpl(NotInline), Op]
        public static ValueProjector define(Func<object,object> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(NotInline), Op]
        public static ValueProjector define(Func<ValueType,ValueType> f)
            => new ValueProjector(x => (ValueType)f((ValueType)x));

        [MethodImpl(NotInline), Op, Closures(AllNumeric)]
        public static ValueProjector<T> define<T>(Func<object,T> f)
            where T : struct
                => new ValueProjector<T>(convert(f));

        [MethodImpl(NotInline), Op, Closures(AllNumeric)]
        public static ValueProjector<T> define<T>(Func<ValueType,T> f)
            where T : struct
                => new ValueProjector<T>(convert(f));

        [MethodImpl(NotInline)]
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

        [MethodImpl(Inline)]
        public static ValueProjector<S,T> define<S,T>(ValueFunc<S,T> f)
            where S : struct
            where T : struct
                => new ValueProjector<S,T>(f);        

        [MethodImpl(NotInline)]
        public static ValueFunc<S,T> convert<S,T>(Func<S,T> f)
            where S : struct
            where T : struct
                => new ProjectorProxy<S,T>(f).F;
        
        [MethodImpl(NotInline), Op, Closures(AllNumeric)]
        public static ValueFunc<T> convert<T>(Func<object,T> f)
            where T : struct
                => new ProjectorProxy<T>(f).F;

        [MethodImpl(NotInline), Op, Closures(AllNumeric)]
        public static ValueFunc<T> convert<T>(Func<ValueType,T> f)
            where T : struct
                => new ProjectorProxy<T>(x => f((ValueType)x)).F;
    }
}