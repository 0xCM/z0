//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Models, true)]
    public readonly struct Models
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Label<T> label<T>(T src)
            => new Label<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Identifier<T> identifier<T>(T src)
            => new Identifier<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Identifier<StringRef> identifier(string src)
            => new Identifier<StringRef>(src);

        [MethodImpl(Inline)]
        public static Literal<I,T> literal<I,T>(I id, T value)
            => new Literal<I,T>(id,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<StringRef,T> literal<T>(string id, T value)
            => new Literal<StringRef,T>(identifier(id), value);

        [MethodImpl(Inline)]
        public static Test<C,T> test<C,T>(C c, T t)
            => new Test<C,T>(c,t);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Test<byte,T> test<T>(byte c, T t)
            => new Test<byte,T>(c,t);

        [MethodImpl(Inline)]
        public static Tests<C,T> tests<C,T>(ReadOnlySpan<C> conditions, ReadOnlySpan<T> targets)
        {
            var count = (uint)conditions.Length;
            if(count == 0 || count != targets.Length)
                return default;

            var buffer = Tests.alloc<C,T>(count);
            ref var dst = ref buffer.First;
            ref readonly var c = ref first(conditions);
            ref readonly var t = ref first(targets);
            for(var i=0; i<count; i++)
                seek(dst,i) = test(skip(c,i), skip(t,i));
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Tests<byte,T> tests<T>(ReadOnlySpan<byte> conditions, ReadOnlySpan<T> targets)
            => tests<byte,T>(conditions, targets);
    }
}