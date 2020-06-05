//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public class AsciTestCases
    {
        public static TestCaseResult<T> execute<T>(T tc)
            where T : IAsciTestCase
        {
            var chars = tc.Chars;
            var src = tc.Strings;
            var count = tc.CharCount;

            Span<byte> dst = new byte[count];            
            AsciCodes.encode(src, dst);    
            var success = AsciTestCases.check(tc, dst);
            var description = AsciTestCases.report(tc,dst);
            return new TestCaseResult<T>(tc, success, description);
        }

        public static bit check<T>(T tc, ReadOnlySpan<byte> encoded)
            where T : IAsciTestCase
        {
            for(var i = 0; i<tc.CharCount; i++)        
            {
                ref readonly var code = ref skip(encoded,i);
                ref readonly var @char = ref skip(tc.Chars, i);
                var expect = (byte)@char;
                var success = code == (byte)@char;
                if(!success)
                    return false;
            }
            return true;
        }

        public static string report<T>(T tc, ReadOnlySpan<byte> encoded)
            where T : IAsciTestCase
        {
            const string Delimiter = " | ";

            var sb = text.build();
            sb.AppendLine();
            sb.AppendLine($"Char (Input){Delimiter}Code (Expect){Delimiter}Code (Actual){Delimiter}Succeeded");
            for(var i = 0; i<tc.CharCount; i++)        
            {
                ref readonly var code = ref skip(encoded,i);
                ref readonly var @char = ref skip(tc.Chars, i);
                var expect = (byte)@char;
                var success = code == (byte)@char;
                
                sb.Append(Chars.SQuote);
                sb.Append(@char);
                sb.Append(Chars.SQuote);                                
                sb.Append(Delimiter);   

                sb.Append(expect.FormatHex(specifier:false));            
                sb.Append(Delimiter);                

                sb.Append(code.FormatHex(specifier:false));
                sb.Append(Delimiter);

                sb.AppendLine(yn(success).ToString());
            }
            return sb.ToString();
        }
    }
}