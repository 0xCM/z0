//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

    public static class AsmEmissionsX
    {
        public static void WriteMember(this StreamWriter dst, CapturedOp src) 
            => dst.Write(src.FormatCode());

	    public static string FormatCode(this CapturedOp src)
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