//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
	public static class DecoderTestParser 
	{
		public static IEnumerable<DecoderTestCase> ReadFile(int bitness, FilePath src) 
		{
			int lineNumber = 0;
			foreach (var line in src.ReadLines()) 
			{
				lineNumber++;
				if (line.Length == 0 || line[0] == '#')
					continue;

				DecoderTestCase testCase;
				try 
				{
					testCase = ReadTestCase(bitness, line, lineNumber);
				}
				catch (Exception ex) 
				{
					throw new InvalidOperationException($"Error parsing decoder test case file '{src}', line {lineNumber}: {ex.Message}");
				}
				yield return testCase;
			}
		}

		static readonly char[] seps = new char[] { ',' };
		
		static readonly char[] extraSeps = new char[] { ' ' };
		
		static DecoderTestCase ReadTestCase(int bitness, string line, int lineNumber) 
		{
			var parts = line.Split(seps);
			if (parts.Length != 5)
				throw new InvalidOperationException($"Invalid number of commas ({parts.Length - 1} commas)");

			var tc = new DecoderTestCase();
			tc.LineNumber = lineNumber;
			tc.CanEncode = true;
			tc.Bitness = bitness;
			tc.HexBytes = ToHexBytes(parts[0].Trim());
			tc.EncodedHexBytes = tc.HexBytes;
			tc.Code = ToCode(parts[1].Trim());
			tc.Mnemonic = ToMnemonic(parts[2].Trim());
			tc.OpCount = NumberConverter.ToInt32(parts[3].Trim());

			foreach (var tmp in parts[4].Split(extraSeps)) {
				if (tmp == string.Empty)
					continue;
				var key = tmp;
				string value;
				int index = key.IndexOf('=');
				if (index >= 0) {
					value = key.Substring(index + 1);
					key = key.Substring(0, index);
				}
				else
					value = null;
				switch (key) {
				case DecoderTestParserConstants.NoEncode:
					tc.CanEncode = false;
					break;

				case DecoderTestParserConstants.InvalidNoMoreBytes:
					tc.InvalidNoMoreBytes = true;
					break;

				case DecoderTestParserConstants.Broadcast:
					tc.IsBroadcast = true;
					break;

				case DecoderTestParserConstants.Xacquire:
					tc.HasXacquirePrefix = true;
					break;

				case DecoderTestParserConstants.Xrelease:
					tc.HasXreleasePrefix = true;
					break;

				case DecoderTestParserConstants.Rep:
				case DecoderTestParserConstants.Repe:
					tc.HasRepePrefix = true;
					break;

				case DecoderTestParserConstants.Repne:
					tc.HasRepnePrefix = true;
					break;

				case DecoderTestParserConstants.Lock:
					tc.HasLockPrefix = true;
					break;

				case DecoderTestParserConstants.ZeroingMasking:
					tc.ZeroingMasking = true;
					break;

				case DecoderTestParserConstants.SuppressAllExceptions:
					tc.SuppressAllExceptions = true;
					break;

				case DecoderTestParserConstants.Vsib32:
					tc.VsibBitness = 32;
					break;

				case DecoderTestParserConstants.Vsib64:
					tc.VsibBitness = 64;
					break;

				case DecoderTestParserConstants.RoundToNearest:
					tc.RoundingControl = RoundingControl.RoundToNearest;
					break;

				case DecoderTestParserConstants.RoundDown:
					tc.RoundingControl = RoundingControl.RoundDown;
					break;

				case DecoderTestParserConstants.RoundUp:
					tc.RoundingControl = RoundingControl.RoundUp;
					break;

				case DecoderTestParserConstants.RoundTowardZero:
					tc.RoundingControl = RoundingControl.RoundTowardZero;
					break;

				case DecoderTestParserConstants.Op0Kind:
					if (tc.OpCount < 1)
						throw new InvalidOperationException($"Invalid OpCount: {tc.OpCount} < 1");
					ReadOpKind(tc, 0, value);
					break;

				case DecoderTestParserConstants.Op1Kind:
					if (tc.OpCount < 2)
						throw new InvalidOperationException($"Invalid OpCount: {tc.OpCount} < 2");
					ReadOpKind(tc, 1, value);
					break;

				case DecoderTestParserConstants.Op2Kind:
					if (tc.OpCount < 3)
						throw new InvalidOperationException($"Invalid OpCount: {tc.OpCount} < 3");
					ReadOpKind(tc, 2, value);
					break;

				case DecoderTestParserConstants.Op3Kind:
					if (tc.OpCount < 4)
						throw new InvalidOperationException($"Invalid OpCount: {tc.OpCount} < 4");
					ReadOpKind(tc, 3, value);
					break;

				case DecoderTestParserConstants.Op4Kind:
					if (tc.OpCount < 5)
						throw new InvalidOperationException($"Invalid OpCount: {tc.OpCount} < 5");
					ReadOpKind(tc, 4, value);
					break;

				case DecoderTestParserConstants.EncodedHexBytes:
					if (string.IsNullOrWhiteSpace(value))
						throw new InvalidOperationException($"Invalid encoded hex bytes: '{value}'");
					tc.EncodedHexBytes = ToHexBytes(value);
					break;

				case DecoderTestParserConstants.DecoderOptions_AmdBranches:
					tc.DecoderOptions |= DecoderOptions.AmdBranches;
					break;

				case DecoderTestParserConstants.DecoderOptions_ForceReservedNop:
					tc.DecoderOptions |= DecoderOptions.ForceReservedNop;
					break;

				case DecoderTestParserConstants.DecoderOptions_Umov:
					tc.DecoderOptions |= DecoderOptions.Umov;
					break;

				case DecoderTestParserConstants.DecoderOptions_Xbts:
					tc.DecoderOptions |= DecoderOptions.Xbts;
					break;

				case DecoderTestParserConstants.DecoderOptions_Cmpxchg486A:
					tc.DecoderOptions |= DecoderOptions.Cmpxchg486A;
					break;

				case DecoderTestParserConstants.DecoderOptions_OldFpu:
					tc.DecoderOptions |= DecoderOptions.OldFpu;
					break;

				case DecoderTestParserConstants.DecoderOptions_Pcommit:
					tc.DecoderOptions |= DecoderOptions.Pcommit;
					break;

				case DecoderTestParserConstants.DecoderOptions_Loadall286:
					tc.DecoderOptions |= DecoderOptions.Loadall286;
					break;

				case DecoderTestParserConstants.DecoderOptions_Loadall386:
					tc.DecoderOptions |= DecoderOptions.Loadall386;
					break;

				case DecoderTestParserConstants.DecoderOptions_Cl1invmb:
					tc.DecoderOptions |= DecoderOptions.Cl1invmb;
					break;

				case DecoderTestParserConstants.DecoderOptions_MovTr:
					tc.DecoderOptions |= DecoderOptions.MovTr;
					break;

				case DecoderTestParserConstants.DecoderOptions_Jmpe:
					tc.DecoderOptions |= DecoderOptions.Jmpe;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoPause:
					tc.DecoderOptions |= DecoderOptions.NoPause;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoWbnoinvd:
					tc.DecoderOptions |= DecoderOptions.NoWbnoinvd;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoLockMovCR0:
					tc.DecoderOptions |= DecoderOptions.NoLockMovCR0;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoMPFX_0FBC:
					tc.DecoderOptions |= DecoderOptions.NoMPFX_0FBC;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoMPFX_0FBD:
					tc.DecoderOptions |= DecoderOptions.NoMPFX_0FBD;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoLahfSahf64:
					tc.DecoderOptions |= DecoderOptions.NoLahfSahf64;
					break;

				case DecoderTestParserConstants.DecoderOptions_NoInvalidCheck:
					tc.DecoderOptions |= DecoderOptions.NoInvalidCheck;
					break;

				case DecoderTestParserConstants.SegmentPrefix_ES:
					tc.SegmentPrefix = Register.ES;
					break;

				case DecoderTestParserConstants.SegmentPrefix_CS:
					tc.SegmentPrefix = Register.CS;
					break;

				case DecoderTestParserConstants.SegmentPrefix_SS:
					tc.SegmentPrefix = Register.SS;
					break;

				case DecoderTestParserConstants.SegmentPrefix_DS:
					tc.SegmentPrefix = Register.DS;
					break;

				case DecoderTestParserConstants.SegmentPrefix_FS:
					tc.SegmentPrefix = Register.FS;
					break;

				case DecoderTestParserConstants.SegmentPrefix_GS:
					tc.SegmentPrefix = Register.GS;
					break;

				case DecoderTestParserConstants.OpMask_k1:
					tc.OpMask = Register.K1;
					break;

				case DecoderTestParserConstants.OpMask_k2:
					tc.OpMask = Register.K2;
					break;

				case DecoderTestParserConstants.OpMask_k3:
					tc.OpMask = Register.K3;
					break;

				case DecoderTestParserConstants.OpMask_k4:
					tc.OpMask = Register.K4;
					break;

				case DecoderTestParserConstants.OpMask_k5:
					tc.OpMask = Register.K5;
					break;

				case DecoderTestParserConstants.OpMask_k6:
					tc.OpMask = Register.K6;
					break;

				case DecoderTestParserConstants.OpMask_k7:
					tc.OpMask = Register.K7;
					break;

				case DecoderTestParserConstants.ConstantOffsets:
					if (!TryParseConstantOffsets(value, out tc.ConstantOffsets))
						throw new InvalidOperationException($"Invalid ConstantOffsets: '{value}'");
					break;

				default:
					throw new InvalidOperationException($"Invalid key '{key}'");
				}
			}

			return tc;
		}

		static readonly char[] coSeps = new char[] { ';' };

		internal static bool TryParseConstantOffsets(string value, out ConstantOffsets constantOffsets) 
		{
			constantOffsets = default;
			if (value is null)
				return false;

			var parts = value.Split(coSeps);
			if (parts.Length != 6)
				return false;
			constantOffsets.ImmediateOffset = NumberConverter.ToUInt8(parts[0]);
			constantOffsets.ImmediateSize = NumberConverter.ToUInt8(parts[1]);
			constantOffsets.ImmediateOffset2 = NumberConverter.ToUInt8(parts[2]);
			constantOffsets.ImmediateSize2 = NumberConverter.ToUInt8(parts[3]);
			constantOffsets.DisplacementOffset = NumberConverter.ToUInt8(parts[4]);
			constantOffsets.DisplacementSize = NumberConverter.ToUInt8(parts[5]);
			return true;
		}

		static readonly char[] opKindSeps = new char[] { ';' };

		static void ReadOpKind(DecoderTestCase tc, int operand, string value) {
			var parts = value.Split(opKindSeps);
			switch (parts[0]) {
			case DecoderTestParserConstants.OpKind_Register:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpRegister(operand, ToRegister(parts[1]));
				tc.SetOpKind(operand, OpKind.Register);
				break;

			case DecoderTestParserConstants.OpKind_NearBranch16:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.NearBranch16);
				tc.NearBranch = NumberConverter.ToUInt16(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_NearBranch32:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.NearBranch32);
				tc.NearBranch = NumberConverter.ToUInt32(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_NearBranch64:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.NearBranch64);
				tc.NearBranch = NumberConverter.ToUInt64(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_FarBranch16:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.FarBranch16);
				tc.FarBranchSelector = NumberConverter.ToUInt16(parts[1]);
				tc.FarBranch = NumberConverter.ToUInt16(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_FarBranch32:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.FarBranch32);
				tc.FarBranchSelector = NumberConverter.ToUInt16(parts[1]);
				tc.FarBranch = NumberConverter.ToUInt32(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate8:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate8);
				tc.Immediate = NumberConverter.ToUInt8(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate16:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate16);
				tc.Immediate = NumberConverter.ToUInt16(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate32:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate32);
				tc.Immediate = NumberConverter.ToUInt32(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate64:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate64);
				tc.Immediate = NumberConverter.ToUInt64(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate8to16:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate8to16);
				tc.Immediate = NumberConverter.ToUInt16(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate8to32:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate8to32);
				tc.Immediate = NumberConverter.ToUInt32(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate8to64:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate8to64);
				tc.Immediate = NumberConverter.ToUInt64(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate32to64:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate32to64);
				tc.Immediate = NumberConverter.ToUInt64(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Immediate8_2nd:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Immediate8_2nd);
				tc.Immediate_2nd = NumberConverter.ToUInt8(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegSI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegSI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegESI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegESI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegRSI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegRSI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegDI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegDI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegEDI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegEDI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemorySegRDI:
				if (parts.Length != 3)
					throw new InvalidOperationException($"Operand {operand}: expected 3 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemorySegRDI);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemorySize = ToMemorySize(parts[2]);
				break;

			case DecoderTestParserConstants.OpKind_MemoryESDI:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemoryESDI);
				tc.MemorySize = ToMemorySize(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_MemoryESEDI:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemoryESEDI);
				tc.MemorySize = ToMemorySize(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_MemoryESRDI:
				if (parts.Length != 2)
					throw new InvalidOperationException($"Operand {operand}: expected 2 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.MemoryESRDI);
				tc.MemorySize = ToMemorySize(parts[1]);
				break;

			case DecoderTestParserConstants.OpKind_Memory64:
				if (parts.Length != 4)
					throw new InvalidOperationException($"Operand {operand}: expected 4 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Memory64);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemoryAddress64 = NumberConverter.ToUInt64(parts[2]);
				tc.MemorySize = ToMemorySize(parts[3]);
				break;

			case DecoderTestParserConstants.OpKind_Memory:
				if (parts.Length != 8)
					throw new InvalidOperationException($"Operand {operand}: expected 8 values, actual = {parts.Length}");
				tc.SetOpKind(operand, OpKind.Memory);
				tc.MemorySegment = ToRegister(parts[1]);
				tc.MemoryBase = ToRegister(parts[2]);
				tc.MemoryIndex = ToRegister(parts[3]);
				tc.MemoryIndexScale = NumberConverter.ToInt32(parts[4]);
				tc.MemoryDisplacement = NumberConverter.ToUInt32(parts[5]);
				tc.MemoryDisplSize = NumberConverter.ToInt32(parts[6]);
				tc.MemorySize = ToMemorySize(parts[7]);
				break;

			default:
				throw new InvalidOperationException($"Invalid opkind: '{parts[0]}'");
			}
		}

		static string ToHexBytes(string value) {
			try {
				HexUtils.ToByteArray(value);
			}
			catch {
				throw new InvalidOperationException($"Invalid hex bytes: '{value}'");
			}
			return value;
		}

		static Code ToCode(string value) {
			if (!ToEnumConverter.TryCode(value, out var code))
				throw new InvalidOperationException($"Invalid Code value: '{value}'");
			return code;
		}

		static Mnemonic ToMnemonic(string value) {
			if (!ToEnumConverter.TryMnemonic(value, out var mnemonic))
				throw new InvalidOperationException($"Invalid Mnemonic value: '{value}'");
			return mnemonic;
		}

		static Register ToRegister(string value) {
			if (value == string.Empty)
				return Register.None;
			if (!ToEnumConverter.TryRegister(value, out var reg))
				throw new InvalidOperationException($"Invalid Register value: '{value}'");
			return reg;
		}

		static MemorySize ToMemorySize(string value) {
			if (!ToEnumConverter.TryMemorySize(value, out var memSize))
				throw new InvalidOperationException($"Invalid MemorySize value: '{value}'");
			return memSize;
		}
	}
}