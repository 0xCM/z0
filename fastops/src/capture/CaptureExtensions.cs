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
        public static CaptureTokenGroup ToGroup(this IEnumerable<CaptureToken> tokens, OpUri groupUri)
            => CaptureTokenGroup.Define(groupUri, tokens.ToArray());

        public static void WriteMember(this StreamWriter dst, CapturedMember src) 
            => dst.Write(src.FormatCode());

	    public static string FormatCode(this CapturedMember src)
        {            
            var data = src.Code;
            var dst = buildstring();
			dst.AppendLine($"; label   : {src.SourceOp.Signature}");
			dst.AppendLine($"; location: {src.SourceMemory.Format()}, length: {src.SourceMemory.Length} bytes");
            var lines = data.Encoded.FormatHexLines(null);
            dst.Append(lines.Concat(AsciEscape.Eol));
            dst.AppendLine(new string('_',80));
            return dst.ToString();
        }                 

    }
}