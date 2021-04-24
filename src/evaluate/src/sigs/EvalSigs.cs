//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct EvalSigs
    {
        [Op]
        public static KindedEvalSig sig(MethodInfo src)
        {
            var @class = ApiIdentityBuilder.klass(src);
            var @return = src.ReturnType;
            var @params = src.ParameterTypes();
            var count = @params.Length + 1;
            var components = sys.alloc<Type>(count);
            for(var i=0; i<count; i++)
            {
                if(i < count - 1)
                    components[i] = @params[i];
                else
                    components[i] = @return;
            }
            return sig(@class, components);
        }

        [MethodImpl(Inline), Op]
        public static EvalSig sig(Index<Type> components)
            => new EvalSig(components);

        [MethodImpl(Inline)]
        public static KindedEvalSig sig(ApiClassKind @class, EvalSig core)
            => new KindedEvalSig(@class, core);

        [MethodImpl(Inline)]
        public static KindedEvalSig sig(ApiClassKind @class, Type[] components)
            => new KindedEvalSig(@class, sig(components));

        [MethodImpl(Inline)]
        public static EvalSig<R> sig<R>(R r = default)
            => default;

        [MethodImpl(Inline)]
        public static EvalSig<A,R> sig<A,R>(A a = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static EvalSig<A,B,R> sig<A,B,R>(A a = default, B b = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static EvalSig<A,B,R> sig<A,B,C,R>(A a = default, B b = default, C c = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static KindedEvalSig<K> sig<K>(EvalSig core)
            where K : unmanaged, IApiKind
                => new KindedEvalSig<K>(core);

        [MethodImpl(Inline)]
        public static KindedEvalSig<K,R> sig<K,R>(EvalSig<R> core = default)
            where K : unmanaged, IApiKind
                => default;

        [MethodImpl(Inline)]
        public static KindedEvalSig<K,A,R> sig<K,A,R>(EvalSig<A,R> core = default)
            where K : unmanaged, IApiKind
                => default;

        [MethodImpl(Inline)]
        public static KindedEvalSig<K,A,B,R> sig<K,A,B,R>(EvalSig<A,B,R> core = default)
            where K : unmanaged, IApiKind
                => default;

        [MethodImpl(Inline)]
        public static KindedEvalSig<K,A,B,C,R> sig<K,A,B,C,R>(EvalSig<A,B,C,R> core = default)
            where K : unmanaged, IApiKind
                => default;
    }
}