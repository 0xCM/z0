//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static zfunc;

    public static class CaptureExtensions
    {
        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control)
            => CaptureServices.Exchange(control);

        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control, Span<byte> target, Span<byte> state)
            => CaptureServices.Exchange(control, target, state);
    
        public static AsmEmissionGroup ToGroup(this IEnumerable<AsmEmissionToken> tokens, OpUri groupUri)
            => AsmEmissionGroup.Define(groupUri, tokens.ToArray());

        public static void WriteMember(this StreamWriter dst, CapturedMember src) 
            => dst.Write(src.FormatCode());

	    public static string FormatCode(this CapturedMember src)
        {            
            var data = src.Code;
            var dst = text();
			dst.AppendLine($"; label   : {src.Method.Signature().Format()}");
			dst.AppendLine($"; location: {src.Origin.Format()}, length: {src.Origin.Length} bytes");
            var lines = data.Encoded.FormatHexLines(null);
            dst.Append(lines.Concat(AsciEscape.Eol));
            dst.AppendLine(new string('_',80));
            return dst.ToString();
        }                 

    }
}