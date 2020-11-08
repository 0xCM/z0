//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Rules, true)]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rule<T> rule<T>(RuleId id, RuleOperand<T>[] operands, RuleEffect<T> effect)
            => new Rule<T>(id, operands, effect);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RuleEffect<T> effect<T>(T[] spec)
            => new RuleEffect<T>(spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> nonterminal<T>(T src)
            => new Node<T>(src,false,false);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> terminal<T>(T src)
            => new Node<T>(src,true,false);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> empty<T>()
            => new Node<T>(default(T), false, true);

        [MethodImpl(Inline)]
        public static string format<T>(Dependency<T> src)
            where T : INode<T>
            => text.format("{0} -> {1}", src.Source, src.Target);

        [MethodImpl(Inline)]
        public static string format<S,T>(Dependency<S,T> src)
            where S : INode<S>
            where T : INode<T>
                => text.format("{0} -> {1}", src.Source, src.Target);
    }
}