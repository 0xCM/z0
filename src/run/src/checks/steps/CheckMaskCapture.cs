//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;

    public ref struct CheckMaskCapture
    {

    }

    public struct MaskCheckResult
    {
        public ulong Mask;

        public PrimalKind MaskType;

        public string Text;

        public TableSpan<uint1> Parsed;

        public ulong Converted;

        public bool Identical;
    }

    public readonly struct MaskCaptureCheck<T>
        where T : unmanaged
    {
        public struct CheckResult
        {
            public T Mask;

            public string Text;

            public TableSpan<uint1> Parsed;

            public T Converted;

            public bool Identical;
        }

        public void Run()
        {
            var declarer = typeof(BitMasks.Literals);
            var src = Literals.tagged<T>(Konst.base2, declarer).Table.View;
            var dst = alloc<CheckResult>(src.Length);
            check(src,dst);
        }

        public static void check(ReadOnlySpan<BinaryLiteral<T>> src, Span<CheckResult> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var source = skip(src,i);
                ref var target = ref seek(dst,i);
                var bits = BitSpans.parse(target.Text);
                var converted = bits.Convert<T>();
                var same = gmath.eq(converted, source.Data);
                target.Mask = source.Data;
                target.Text = source.Text;
                target.Parsed = bits.Edit.Map(x => x ? uint1.One : uint1.Zero).ToArray();
                target.Converted = converted;
                target.Identical = same;
            }
        }
    }
}