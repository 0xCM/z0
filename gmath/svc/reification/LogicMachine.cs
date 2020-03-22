//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;


    public static class LogicMachine
    {
        [MethodImpl(Inline)]
        public static LogicMachine<L,T> Create<L,T>(L provider, T t = default)
            where T : unmanaged
            where L : IBitLogic<T>
                => new LogicMachine<L,T>(provider);
    }

    public readonly struct LogicMachine<L,T> : IBitLogic<T>
        where T : unmanaged
        where L : IBitLogic<T>
    {
        readonly L LogicProvider; 

        [MethodImpl(Inline)]
        internal LogicMachine(L provider)
            => LogicProvider = provider;

        [MethodImpl(Inline)]
        public T and(T a, T b)
            => LogicProvider.and(a,b);

        [MethodImpl(Inline)]
        public T or(T a, T b)
            => LogicProvider.or(a,b);

        [MethodImpl(Inline)]
        public T xor(T a, T b)
            => LogicProvider.xor(a,b);

        [MethodImpl(Inline)]
        public T nand(T a, T b)
            => LogicProvider.nand(a,b);

        [MethodImpl(Inline)]
        public T nor(T a, T b)
            => LogicProvider.nor(a,b);

        [MethodImpl(Inline)]
        public T xnor(T a, T b)
            => LogicProvider.xnor(a,b);

        [MethodImpl(Inline)]
        public T impl(T a, T b)
            => LogicProvider.impl(a,b);

        [MethodImpl(Inline)]
        public T nonimpl(T a, T b)
            => LogicProvider.nonimpl(a,b);

        [MethodImpl(Inline)]
        public T cimpl(T a, T b)
            => LogicProvider.impl(a,b);

        [MethodImpl(Inline)]
        public T cnonimpl(T a, T b)
            => LogicProvider.nonimpl(a,b);

        [MethodImpl(Inline)]
        public T not(T a)
            => LogicProvider.not(a);

        [MethodImpl(Inline)]
        public T select(T a, T b, T c)
            => LogicProvider.select(a,b,c);

        [MethodImpl(Inline)]
        public T @true()
            => LogicProvider.@true();

        [MethodImpl(Inline)]
        public T @false()
            => LogicProvider.@false();

        [MethodImpl(Inline)]
        public T identity(T a)
            => LogicProvider.identity(a);
    }
}