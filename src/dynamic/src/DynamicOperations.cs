//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public unsafe readonly struct DynamicOperations
    {
        const NumericKind Closure = UnsignedInts;

        public struct BinOpSpec<T>
        {
            public Identifier Name;

            public SegRef Definition;

            public T Arg0;

            public T Arg1;

            public BinaryOp<T> Operation;

            public Outcome<T> Result;
        }

        public struct EmitterSpec<T>
        {
            public Identifier Name;

            public SegRef Definition;

            public Emitter<T> Operation;
        }

        [MethodImpl(Inline), Op]
        public static SegRef load(ReadOnlySpan<byte> src, uint offset, in NativeBuffer dst)
        {
            var i0 = offset;
            ref var target = ref seek(dst.Edit, offset);
            var location = address(target);
            for(var i=0; i<src.Length; i++)
                seek(target, offset++) = skip(src,i);
            return (location, offset - i0);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinOpSpec<T> binop<T>(Identifier name, SegRef block)
        {
            var spec = new BinOpSpec<T>();
            spec.Name = name;
            spec.Definition = block;
            spec.Operation = BinaryOpDynamics.create<T>(spec.Name, spec.Definition.Pointer());
            return spec;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmitterSpec<T> emitter<T>(Identifier name, SegRef block)
        {
            var spec = new EmitterSpec<T>();
            spec.Name = name;
            spec.Definition = block;
            spec.Operation = DynamicEmitter.emitter<T>(spec.Name, block.Address.Pointer<byte>());
            return spec;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BinOpSpec<T> specify<T>(in T arg0, in T arg1, ref BinOpSpec<T> dst)
        {
            dst.Arg0 = arg0;
            dst.Arg1 = arg1;
            return ref dst;
        }

        [Op, Closures(Closure)]
        public static T invoke<T>(in BinOpSpec<T> f)
            => f.Operation(f.Arg0, f.Arg1);

        [Op, Closures(Closure)]
        public static T invoke<T>(in EmitterSpec<T> f)
            => f.Operation();

        public static string format<T>(in BinOpSpec<T> f, T result)
        {
            const string Pattern = "{0}({1},{2}) = {3}";
            return string.Format(Pattern, f.Name, f.Arg0, f.Arg1, result);
        }
    }
}