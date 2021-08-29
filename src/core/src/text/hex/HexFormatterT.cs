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

    public readonly struct HexFormatter<T>
        where T : unmanaged
    {
        readonly ISystemFormatter<T> BaseFormatter;

        [MethodImpl(Inline)]
        public HexFormatter(ISystemFormatter<T> formatter)
            => BaseFormatter = formatter;

        [MethodImpl(Inline)]
        public string FormatItem(T src)
            => FormatItem(src, HexFormatSpecs.options());

        [MethodImpl(Inline)]
        public string FormatItem(T src, in HexFormatOptions config)
            => string.Concat(
                config.Specifier && config.Specifier ? HexFormatSpecs.PreSpec : string.Empty,
                config.ZeroPad ? BaseFormatter.Format(src, config.CaseIndicator.ToString()).PadLeft(Unsafe.SizeOf<T>()*2, '0') : BaseFormatter.Format(src, config.CaseIndicator.ToString()),
                config.Specifier && !config.PreSpec ? HexFormatSpecs.PostSpec : string.Empty
                );

        public string Format(ReadOnlySpan<T> src, HexFormatOptions options)
            => HexFormatter.format(src, options);

        public string Format(ReadOnlySpan<T> src)
            => HexFormatter.format(src, HexFormatSpecs.options(valsep: Chars.Space));
    }
}