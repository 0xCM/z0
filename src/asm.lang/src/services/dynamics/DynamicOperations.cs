//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    public struct BinaryOperator<T>
    {
        public Identifier Name;

        public SegRef Definition;

        public T Arg0;

        public T Arg1;

        public Outcome<T> Result;
    }

    [ApiHost]
    public unsafe readonly struct DynamicOperations
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static SegRef load(ReadOnlySpan<byte> src, uint offset, in NativeBuffer dst)
        {
            var i0 = offset;
            ref var target = ref seek(dst.Allocated, offset);
            var location = address(target);
            for(var i=0; i<src.Length; i++)
                seek(target, offset++) = skip(src,i);
            return (location, offset - i0);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOperator<T> binop<T>(Identifier name)
        {
            var dst = new BinaryOperator<T>();
            dst.Name = name;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOperator<T> binop<T>(Identifier name, SegRef block)
        {
            var dst = binop<T>(name);
            dst.Definition = block;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BinaryOperator<T> specify<T>(in T arg0, in T arg1, ref BinaryOperator<T> dst)
        {
            dst.Arg0 = arg0;
            dst.Arg1 = arg1;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BinaryOperator<T> sucesss<T>(in T result, ref BinaryOperator<T> dst)
        {
            dst.Result = result;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BinaryOperator<T> error<T>(Outcome result, ref BinaryOperator<T> dst)
        {
            dst.Result = result;
            return ref dst;
        }

        [Op, Closures(Closure)]
        public static void run<T>(ref BinaryOperator<T> f)
        {
            try
            {
                var compiled = BinaryOpDynamics.binop<T>(f.Name, f.Definition.Pointer());
                f.Result = compiled(f.Arg0, f.Arg1);
            }
            catch(Exception e)
            {
                f.Result = e;
            }
        }

        public static void format<T>(in BinaryOperator<T> f, Action<string> dst)
        {
            const string SuccessPattern = "{0}({1},{2}) = {3}";
            const string FailurePattern = "{0}({1},{2}) = <{3}>";
            var pattern = f.Result ? SuccessPattern : FailurePattern;
            dst(string.Format(pattern, f.Name, f.Arg0, f.Arg1, f.Result));
        }
    }
}