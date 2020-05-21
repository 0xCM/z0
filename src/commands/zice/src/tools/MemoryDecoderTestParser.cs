//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{

    using System;
    using System.Collections.Generic;
    using System.IO;
	using System.Linq;
    using SG = System.Globalization;

	using static Memories;

	static class MemoryDecoderTestParser 
    {
		public static DecoderMemoryTestCase[] Parse<N>(N n, FilePath src)
			where N : unmanaged, ITypeNat
		{
			if(typeof(N) == typeof(N16))
				return Parse(n16, src);
			else if(typeof(N) == typeof(N32))
				return Parse(n32, src);
			else if(typeof(N) == typeof(N64))
				return Parse(n64, src);
			else
				throw Unsupported.define<N>();
		}

		static DecoderMemoryTestCase[] Parse(N16 n, FilePath src) 
			=> ReadFile(n,src.Name).ToArray();
		
		static DecoderMemoryTestCase[] Parse(N32 n, FilePath src) 
			=> ReadFile(n,src.Name).ToArray();
			
		static DecoderMemoryTestCase[] Parse(N64 n, FilePath src) 
			=> ReadFile(n,src.Name).ToArray();

		public static IEnumerable<DecoderMemoryTestCase> ReadFile(int bitness, string filename) 
		{
			int lineNumber = 0;
			foreach (var line in File.ReadLines(filename)) {
				lineNumber++;
				if (line.Length == 0 || line[0] == '#')
					continue;
				DecoderMemoryTestCase testCase;
				try {
					testCase = ReadTestCase(bitness, line, lineNumber);
				}
				catch (Exception ex) {
					throw new InvalidOperationException($"Error parsing decoder test case file '{filename}', line {lineNumber}: {ex.Message}");
				}
				yield return testCase;
			}
		}

		static readonly char[] colSep = new char[] { ',' };
		
		static DecoderMemoryTestCase ReadTestCase(int bitness, string line, int lineNumber) 
		{
			var parts = line.Split(colSep, StringSplitOptions.None);
			if (parts.Length != 11 && parts.Length != 12)
				throw new InvalidOperationException();
			var tc = new DecoderMemoryTestCase();
			tc.LineNumber = lineNumber;
			tc.Bitness = bitness;
			tc.HexBytes = parts[0].Trim();
			tc.Code = ToEnumConverter.GetCode(parts[1].Trim());
			tc.Register = ToEnumConverter.GetRegister(parts[2].Trim());
			tc.SegmentPrefix = ToEnumConverter.GetRegister(parts[3].Trim());
			tc.SegmentRegister = ToEnumConverter.GetRegister(parts[4].Trim());
			tc.BaseRegister = ToEnumConverter.GetRegister(parts[5].Trim());
			tc.IndexRegister = ToEnumConverter.GetRegister(parts[6].Trim());
			tc.Scale = (int)ParseUInt32(parts[7].Trim());
			tc.Displacement = ParseUInt32(parts[8].Trim());
			tc.DisplacementSize = (int)ParseUInt32(parts[9].Trim());
			var coStr = parts[10].Trim();
			if (!DecoderTestParser.TryParseConstantOffsets(coStr, out tc.ConstantOffsets))
				throw new InvalidOperationException($"Invalid ConstantOffsets: '{coStr}'");
			tc.EncodedHexBytes = parts.Length > 11 ? parts[11].Trim() : tc.HexBytes;
			tc.DecoderOptions = DecoderOptions.None;
			tc.CanEncode = true;
			return tc;
		}

		static uint ParseUInt32(string s) {
			if (uint.TryParse(s, out uint value))
				return value;
			if (s.StartsWith("0x")) {
				s = s.Substring(2);
				if (uint.TryParse(s, SG.NumberStyles.HexNumber, null, out value))
					return value;
			}

			throw new InvalidOperationException();
		}
	}
}
