//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    [ApiHost]
    public ref struct FunctionWorkflows
    {
        const byte i0 = 0;

        const byte i1 = 1;

        const byte i2 = 2;

        const byte i3 = 3;

        const byte FunctionCount = 4;

        readonly IWfShell Wf;

        ReadOnlySpan<byte> Left;

        ReadOnlySpan<byte> Right;

        Span<byte> Target;

        public FunctionWorkflows(IWfShell wf)
        {
            Wf = wf;
            Left = array<byte>(1,2,4,8);
            Right = array<byte>(16,32,64,128);
            Target = alloc<byte>(FunctionCount);
        }

        [Op]
        public ReadOnlySpan<byte> RunF()
        {
            ref readonly var a = ref first(Left);
            ref readonly var b = ref first(Right);
            ref var c = ref first(Target);
            seek(c,i0) = f0(skip(a,i0), skip(b,i0));
            seek(c,i1) = f1(skip(a,i1), skip(b,i1));
            seek(c,i2) = f2(skip(a,i2), skip(b,i2));
            seek(c,i3) = f3(skip(a,i3), skip(b,i3));
            return Target;
        }

        [Op]
        public ReadOnlySpan<byte> RunG()
        {
            ref readonly var a = ref first(Left);
            ref readonly var b = ref first(Right);
            ref var c = ref first(Target);
            seek(c,i0) = g0(skip(a,i0), skip(b,i0));
            seek(c,i1) = g1(skip(a,i1), skip(b,i1));
            seek(c,i2) = g2(skip(a,i2), skip(b,i2));
            seek(c,i3) = g3(skip(a,i3), skip(b,i3));
            return Target;
        }

        [Op, MethodImpl(NotInline)]
        static byte f0(byte x, byte y)
            => (byte)(x^y);

        [Op, MethodImpl(NotInline)]
        static byte f1(byte x, byte y)
            => (byte)(x|y);

        [Op, MethodImpl(NotInline)]
        static byte f2(byte x, byte y)
            => (byte)(x*y);

        [Op, MethodImpl(NotInline)]
        static byte f3(byte x, byte y)
            => (byte)(x&y);

        [Op, MethodImpl(Inline)]
        static byte g0(byte x, byte y)
            => (byte)(x^y);

        [Op, MethodImpl(Inline)]
        static byte g1(byte x, byte y)
            => (byte)(x|y);

        [Op, MethodImpl(Inline)]
        static byte g2(byte x, byte y)
            => (byte)(x*y);

        [Op, MethodImpl(Inline)]
        static byte g3(byte x, byte y)
            => (byte)(x&y);
    }
}