//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class Parametric
    {
        [MethodImpl(Inline)]
        public static Parametric<T0> Define<T0>(T0 t0 = default)
            => default(Parametric<T0>);

        [MethodImpl(Inline)]
        public static Parametric<T0,T1> Define<T0,T1>(T0 t0 = default, T1 t1 = default)
            => default(Parametric<T0,T1>);

        [MethodImpl(Inline)]
        public static Parametric<T0,T1,T2> Define<T0,T1,T2>(T0 t0 = default, T1 t1 = default, T2 t2 = default)
            => default(Parametric<T0,T1,T2>);

        [MethodImpl(Inline)]
        public static Parametric<T0,T1,T2,T3> Define<T0,T1,T2,T3>(T0 t0 = default, T1 t1 = default, T2 t2 = default, T3 t3= default)
            => default(Parametric<T0,T1,T2,T3>);
    }

    
    public interface IParametric
    {
        Type[] Parameters {get;}
    }

    public readonly struct Parametric<T0> : IParametric
    {
        Type[] IParametric.Parameters => array(typeof(T0));
    }

    public readonly struct Parametric<T0,T1> : IParametric
    {
        Type[] IParametric.Parameters => array(typeof(T0), typeof(T1));
    }

    public readonly struct Parametric<T0,T1,T2> : IParametric
    {
        Type[] IParametric.Parameters => array(typeof(T0), typeof(T1), typeof(T2));
    }

    public readonly struct Parametric<T0,T1,T2,T3> : IParametric
    {
        Type[] IParametric.Parameters => array(typeof(T0), typeof(T1), typeof(T2), typeof(T3));
    }
}