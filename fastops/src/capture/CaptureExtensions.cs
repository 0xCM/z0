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

    public static class CaptureExtensions
    {
        public static CaptureTokenGroup ToGroup(this IEnumerable<CaptureToken> tokens, OpUri groupUri)
            => CaptureTokenGroup.Define(groupUri, tokens.ToArray());

        public static void WriteMember(this StreamWriter dst, CapturedMember src) 
            => dst.Write(src.FormatCode());

	    public static string FormatCode(this CapturedMember src)
        {            
            var data = src.Code;
            var dst = text.factory.Builder();
			dst.AppendLine($"; label   : {src.Operation.Signature}");
			dst.AppendLine($"; location: {src.AddressRange.Format()}, length: {src.AddressRange.Length} bytes");
            var lines = data.Bytes.FormatHexLines(null);
            dst.Append(lines.Concat(AsciEscape.Eol));
            dst.AppendLine(new string('_',80));
            return dst.ToString();
        }                 
    }
}