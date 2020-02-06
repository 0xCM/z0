//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class NativeX
    {
        public static bool AcceptsParameter(this AsmCode src, NumericKind kind)
            => NumericType.parseKinds(src.Id.TextComponents.Skip(1)).Contains(kind);

        public static int ParameterCount(this AsmCode src)
            => src.Id.TextComponents.Count() - 1;

        public static IEnumerable<AsmCode> AcceptsParameter(this IEnumerable<AsmCode> src, NumericKind kind)
            => from code in src
                where code.AcceptsParameter(kind)
                select code;
                    
        public static IEnumerable<AsmCode> AcceptsParameters(this IEnumerable<AsmCode> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = NumericType.parseKinds(code.Id.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<AsmCode> HasParameterCount(this IEnumerable<AsmCode> src, int count)
            => from code in src
                where code.ParameterCount() == count
                select code;


        [MethodImpl(Inline)]
        public static ICaptureStateSink ToCaptureSink(this IPointSink<CaptureState> sink)
            => CaptureStateSink.From(sink);

        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control)
            => NativeServices.CaptureExchange(control);

        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control, Span<byte> target, Span<byte> state)
            => NativeServices.CaptureExchange(control, target, state);

    }
}