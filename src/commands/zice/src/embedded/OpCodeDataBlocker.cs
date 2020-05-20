//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using Flags = OpCodeDataFlags;

	public class OpCodeDataBlocker
	{
		public static ReadOnlySpan<byte> LegacyData 
			=> EmbeddedData.LegacyOpKinds;

		public static ReadOnlySpan<byte> VexData 
			=> EmbeddedData.VexOpKinds;

		public static ReadOnlySpan<byte> EvexData 
			=> EmbeddedData.EvexOpKinds;

		public static ReadOnlySpan<byte> XopData 
			=> EmbeddedData.XopOpKinds;

		public static void Fill(ref OpCodeDataBlock dst)
		{
            switch ((EncodingKind)dst.Encoding) 
            {
				case EncodingKind.Legacy:
					FillLegacyBlock(ref dst);
					break;

				case EncodingKind.VEX:
					FillVexBlock(ref dst);
					break;

				case EncodingKind.EVEX:
					FillEvecBlock(ref dst);
					break;

				case EncodingKind.XOP:
					FillXopBlock(ref dst);
					break;
			}
		}

		static OpCodeDataBlock FillLegacyBlock(ref OpCodeDataBlock dst)
		{
			var dword3 = dst.DWord3;
			var dword2 = dst.DWord2;
			var dword1 = dst.DWord1;
			dst.op0Kind = LegacyData[(int)((dword3 >> (int)LegacyFlags3.Op0Shift) & (uint)LegacyFlags3.OpMask)];
			dst.op1Kind = LegacyData[(int)((dword3 >> (int)LegacyFlags3.Op1Shift) & (uint)LegacyFlags3.OpMask)];
			dst.op2Kind = LegacyData[(int)((dword3 >> (int)LegacyFlags3.Op2Shift) & (uint)LegacyFlags3.OpMask)];
			dst.op3Kind = LegacyData[(int)((dword3 >> (int)LegacyFlags3.Op3Shift) & (uint)LegacyFlags3.OpMask)];

			dst.mandatoryPrefix = (MandatoryPrefixByte)((dword2 >> (int)LegacyFlags.MandatoryPrefixByteShift) & (uint)LegacyFlags.MandatoryPrefixByteMask) switch {
				MandatoryPrefixByte.None => (byte)((dword2 & (uint)LegacyFlags.HasMandatoryPrefix) != 0 ? MandatoryPrefix.PNP : MandatoryPrefix.None),
				MandatoryPrefixByte.P66 => (byte)MandatoryPrefix.P66,
				MandatoryPrefixByte.PF3 => (byte)MandatoryPrefix.PF3,
				MandatoryPrefixByte.PF2 => (byte)MandatoryPrefix.PF2,
				_ => throw new InvalidOperationException(),
			};

			dst.table = (LegacyOpCodeTable)((dword2 >> (int)LegacyFlags.LegacyOpCodeTableShift) & (uint)LegacyFlags.LegacyOpCodeTableMask) switch {
				LegacyOpCodeTable.Normal => (byte)OpCodeTableKind.Normal,
				LegacyOpCodeTable.Table0F => (byte)OpCodeTableKind.T0F,
				LegacyOpCodeTable.Table0F38 => (byte)OpCodeTableKind.T0F38,
				LegacyOpCodeTable.Table0F3A => (byte)OpCodeTableKind.T0F3A,
				_ => throw new InvalidOperationException(),
			};


			dst.groupIndex = (sbyte)((dword2 & (uint)LegacyFlags.HasGroupIndex) == 0 ? -1 : (int)((dword2 >> (int)LegacyFlags.GroupShift) & 7));
			dst.tupleType = (byte)TupleType.None;

			var isInstruction = (dst.Flags & Flags.NoInstruction) == 0;

			if (!isInstruction)
				dst.Flags |= Flags.Mode16 | Flags.Mode32 | Flags.Mode64;
			else {
				dst.Flags |= (Encodable)((dword2 >> (int)LegacyFlags.EncodableShift) & (uint)LegacyFlags.EncodableMask) switch {
					Encodable.Any => Flags.Mode16 | Flags.Mode32 | Flags.Mode64,
					Encodable.Only1632 => Flags.Mode16 | Flags.Mode32,
					Encodable.Only64 => Flags.Mode64,
					_ => throw new InvalidOperationException(),
				};
			}

			dst.Flags |= (AllowedPrefixes)((dword2 >> (int)LegacyFlags.AllowedPrefixesShift) & (uint)LegacyFlags.AllowedPrefixesMask) switch {
				AllowedPrefixes.None => Flags.None,
				AllowedPrefixes.Bnd => Flags.BndPrefix,
				AllowedPrefixes.BndNotrack => Flags.BndPrefix | Flags.NotrackPrefix,
				AllowedPrefixes.HintTakenBnd => Flags.BndPrefix | Flags.HintTakenPrefix,
				AllowedPrefixes.Lock => Flags.LockPrefix,
				AllowedPrefixes.Rep => Flags.RepPrefix,
				AllowedPrefixes.RepRepne => Flags.RepPrefix | Flags.RepnePrefix,
				AllowedPrefixes.XacquireXreleaseLock => Flags.LockPrefix | Flags.XacquirePrefix | Flags.XreleasePrefix,
				AllowedPrefixes.Xrelease => Flags.XreleasePrefix,
				_ => throw new InvalidOperationException(),
			};
			if ((dword2 & (uint)LegacyFlags.Fwait) != 0)
				dst.Flags |= Flags.Fwait;

			dst.operandSize = ((OperandSize)((dword2 >> (int)LegacyFlags.OperandSizeShift) & (uint)LegacyFlags.OperandSizeMask)) switch {
				Data.OperandSize.None => 0,
				Data.OperandSize.Size16 => 16,
				Data.OperandSize.Size32 => 32,
				Data.OperandSize.Size64 => 64,
				_ => throw new InvalidOperationException(),
			};

			dst.addressSize = ((AddressSize)((dword2 >> (int)LegacyFlags.AddressSizeShift) & (uint)LegacyFlags.AddressSizeMask)) switch {
				Data.AddressSize.None => 0,
				Data.AddressSize.Size16 => 16,
				Data.AddressSize.Size32 => 32,
				Data.AddressSize.Size64 => 64,
				_ => throw new InvalidOperationException(),
			};

			return dst;
		}		

		static OpCodeDataBlock FillVexBlock(ref OpCodeDataBlock dst)
		{
			var dword3 = dst.DWord3;
			var dword2 = dst.DWord2;
			var dword1 = dst.DWord1;
			dst.op0Kind = VexData[(int)((dword3 >> (int)VexFlags3.Op0Shift) & (uint)VexFlags3.OpMask)];
			dst.op1Kind = VexData[(int)((dword3 >> (int)VexFlags3.Op1Shift) & (uint)VexFlags3.OpMask)];
			dst.op2Kind = VexData[(int)((dword3 >> (int)VexFlags3.Op2Shift) & (uint)VexFlags3.OpMask)];
			dst.op3Kind = VexData[(int)((dword3 >> (int)VexFlags3.Op3Shift) & (uint)VexFlags3.OpMask)];
			dst.op4Kind = VexData[(int)((dword3 >> (int)VexFlags3.Op4Shift) & (uint)VexFlags3.OpMask)];
			
			dst.mandatoryPrefix = (MandatoryPrefixByte)((dword2 >> (int)VexFlags.MandatoryPrefixByteShift) & (uint)VexFlags.MandatoryPrefixByteMask) switch {
				MandatoryPrefixByte.None => (byte)MandatoryPrefix.PNP,
				MandatoryPrefixByte.P66 => (byte)MandatoryPrefix.P66,
				MandatoryPrefixByte.PF3 => (byte)MandatoryPrefix.PF3,
				MandatoryPrefixByte.PF2 => (byte)MandatoryPrefix.PF2,
				_ => throw new InvalidOperationException(),
			};

			dst.table = (VexOpCodeTable)((dword2 >> (int)VexFlags.VexOpCodeTableShift) & (uint)VexFlags.VexOpCodeTableMask) switch {
				VexOpCodeTable.Table0F => (byte)OpCodeTableKind.T0F,
				VexOpCodeTable.Table0F38 => (byte)OpCodeTableKind.T0F38,
				VexOpCodeTable.Table0F3A => (byte)OpCodeTableKind.T0F3A,
				_ => throw new InvalidOperationException(),
			};

			dst.groupIndex = (sbyte)((dword2 & (uint)VexFlags.HasGroupIndex) == 0 ? -1 : (int)((dword2 >> (int)VexFlags.GroupShift) & 7));
			dst.tupleType = (byte)TupleType.None;

			dst.Flags |= (Encodable)((dword2 >> (int)VexFlags.EncodableShift) & (uint)VexFlags.EncodableMask) switch {
				Encodable.Any => Flags.Mode16 | Flags.Mode32 | Flags.Mode64,
				Encodable.Only1632 => Flags.Mode16 | Flags.Mode32,
				Encodable.Only64 => Flags.Mode64,
				_ => throw new InvalidOperationException(),
			};

			switch ((VexVectorLength)((dword2 >> (int)VexFlags.VexVectorLengthShift) & (int)VexFlags.VexVectorLengthMask)) {
			case VexVectorLength.LZ:
				dst.lkind = LKind.LZ;
				dst.l = 0;
				break;
			case VexVectorLength.L0:
				dst.lkind = LKind.L0;
				dst.l = 0;
				break;
			case VexVectorLength.L1:
				dst.lkind = LKind.L0;
				dst.l = 1;
				break;
			case VexVectorLength.L128:
				dst.lkind = LKind.L128;
				dst.l = 0;
				break;
			case VexVectorLength.L256:
				dst.lkind = LKind.L128;
				dst.l = 1;
				break;
			case VexVectorLength.LIG:
				dst.lkind = LKind.None;
				dst.l = 0;
				dst.Flags |= Flags.LIG;
				break;
			default:
				throw new InvalidOperationException();
			}

			switch ((WBit)((dword2 >> (int)VexFlags.WBitShift) & (uint)VexFlags.WBitMask)) {
			case WBit.W1:
				dst.Flags |= Flags.W;
				break;
			case WBit.WIG:
				dst.Flags |= Flags.WIG;
				break;
			case WBit.WIG32:
				dst.Flags |= Flags.WIG32;
				break;
			}

			return dst;
		}

		static OpCodeDataBlock FillEvecBlock(ref OpCodeDataBlock dst)
		{
			var dword3 = dst.DWord3;
			var dword2 = dst.DWord2;
			var dword1 = dst.DWord1;

			dst.op0Kind = EvexData[(int)((dword3 >> (int)EvexFlags3.Op0Shift) & (uint)EvexFlags3.OpMask)];
			dst.op1Kind = EvexData[(int)((dword3 >> (int)EvexFlags3.Op1Shift) & (uint)EvexFlags3.OpMask)];
			dst.op2Kind = EvexData[(int)((dword3 >> (int)EvexFlags3.Op2Shift) & (uint)EvexFlags3.OpMask)];
			dst.op3Kind = EvexData[(int)((dword3 >> (int)EvexFlags3.Op3Shift) & (uint)EvexFlags3.OpMask)];

			dst.mandatoryPrefix = (MandatoryPrefixByte)((dword2 >> (int)EvexFlags.MandatoryPrefixByteShift) & (uint)EvexFlags.MandatoryPrefixByteMask) switch {
				MandatoryPrefixByte.None => (byte)MandatoryPrefix.PNP,
				MandatoryPrefixByte.P66 => (byte)MandatoryPrefix.P66,
				MandatoryPrefixByte.PF3 => (byte)MandatoryPrefix.PF3,
				MandatoryPrefixByte.PF2 => (byte)MandatoryPrefix.PF2,
				_ => throw new InvalidOperationException(),
			};

			dst.table = (EvexOpCodeTable)((dword2 >> (int)EvexFlags.EvexOpCodeTableShift) & (uint)EvexFlags.EvexOpCodeTableMask) switch {
				EvexOpCodeTable.Table0F => (byte)OpCodeTableKind.T0F,
				EvexOpCodeTable.Table0F38 => (byte)OpCodeTableKind.T0F38,
				EvexOpCodeTable.Table0F3A => (byte)OpCodeTableKind.T0F3A,
				_ => throw new InvalidOperationException(),
			};

			dst.groupIndex = (sbyte)((dword2 & (uint)EvexFlags.HasGroupIndex) == 0 ? -1 : (int)((dword2 >> (int)EvexFlags.GroupShift) & 7));
			dst.tupleType = (byte)((dword2 >> (int)EvexFlags.TupleTypeShift) & (uint)EvexFlags.TupleTypeMask);

			dst.Flags |= (Encodable)((dword2 >> (int)EvexFlags.EncodableShift) & (uint)EvexFlags.EncodableMask) switch {
				Encodable.Any => Flags.Mode16 | Flags.Mode32 | Flags.Mode64,
				Encodable.Only1632 => Flags.Mode16 | Flags.Mode32,
				Encodable.Only64 => Flags.Mode64,
				_ => throw new InvalidOperationException(),
			};

			dst.l = (byte)((dword2 >> (int)EvexFlags.EvexVectorLengthShift) & (uint)EvexFlags.EvexVectorLengthMask);

			switch ((WBit)((dword2 >> (int)EvexFlags.WBitShift) & (uint)EvexFlags.WBitMask)) {
			case WBit.W1:
				dst.Flags |= Flags.W;
				break;
			case WBit.WIG:
				dst.Flags |= Flags.WIG;
				break;
			case WBit.WIG32:
				dst.Flags |= Flags.WIG32;
				break;
			}
			if ((dword2 & (uint)EvexFlags.LIG) != 0)
				dst.Flags |= Flags.LIG;
			if ((dword2 & (uint)EvexFlags.b) != 0)
				dst.Flags |= Flags.Broadcast;
			if ((dword2 & (uint)EvexFlags.er) != 0)
				dst.Flags |= Flags.RoundingControl;
			if ((dword2 & (uint)EvexFlags.sae) != 0)
				dst.Flags |= Flags.SuppressAllExceptions;
			if ((dword2 & (uint)EvexFlags.k1) != 0)
				dst.Flags |= Flags.OpMaskRegister;
			if ((dword2 & (uint)EvexFlags.z) != 0)
				dst.Flags |= Flags.ZeroingMasking;
			dst.lkind = LKind.L128;

			switch (dst.CodeId) 
			{
				case Code.EVEX_Vpgatherdd_xmm_k1_vm32x:
				case Code.EVEX_Vpgatherdd_ymm_k1_vm32y:
				case Code.EVEX_Vpgatherdd_zmm_k1_vm32z:
				case Code.EVEX_Vpgatherdq_xmm_k1_vm32x:
				case Code.EVEX_Vpgatherdq_ymm_k1_vm32x:
				case Code.EVEX_Vpgatherdq_zmm_k1_vm32y:
				case Code.EVEX_Vpgatherqd_xmm_k1_vm64x:
				case Code.EVEX_Vpgatherqd_xmm_k1_vm64y:
				case Code.EVEX_Vpgatherqd_ymm_k1_vm64z:
				case Code.EVEX_Vpgatherqq_xmm_k1_vm64x:
				case Code.EVEX_Vpgatherqq_ymm_k1_vm64y:
				case Code.EVEX_Vpgatherqq_zmm_k1_vm64z:
				case Code.EVEX_Vgatherdps_xmm_k1_vm32x:
				case Code.EVEX_Vgatherdps_ymm_k1_vm32y:
				case Code.EVEX_Vgatherdps_zmm_k1_vm32z:
				case Code.EVEX_Vgatherdpd_xmm_k1_vm32x:
				case Code.EVEX_Vgatherdpd_ymm_k1_vm32x:
				case Code.EVEX_Vgatherdpd_zmm_k1_vm32y:
				case Code.EVEX_Vgatherqps_xmm_k1_vm64x:
				case Code.EVEX_Vgatherqps_xmm_k1_vm64y:
				case Code.EVEX_Vgatherqps_ymm_k1_vm64z:
				case Code.EVEX_Vgatherqpd_xmm_k1_vm64x:
				case Code.EVEX_Vgatherqpd_ymm_k1_vm64y:
				case Code.EVEX_Vgatherqpd_zmm_k1_vm64z:
				case Code.EVEX_Vpscatterdd_vm32x_k1_xmm:
				case Code.EVEX_Vpscatterdd_vm32y_k1_ymm:
				case Code.EVEX_Vpscatterdd_vm32z_k1_zmm:
				case Code.EVEX_Vpscatterdq_vm32x_k1_xmm:
				case Code.EVEX_Vpscatterdq_vm32x_k1_ymm:
				case Code.EVEX_Vpscatterdq_vm32y_k1_zmm:
				case Code.EVEX_Vpscatterqd_vm64x_k1_xmm:
				case Code.EVEX_Vpscatterqd_vm64y_k1_xmm:
				case Code.EVEX_Vpscatterqd_vm64z_k1_ymm:
				case Code.EVEX_Vpscatterqq_vm64x_k1_xmm:
				case Code.EVEX_Vpscatterqq_vm64y_k1_ymm:
				case Code.EVEX_Vpscatterqq_vm64z_k1_zmm:
				case Code.EVEX_Vscatterdps_vm32x_k1_xmm:
				case Code.EVEX_Vscatterdps_vm32y_k1_ymm:
				case Code.EVEX_Vscatterdps_vm32z_k1_zmm:
				case Code.EVEX_Vscatterdpd_vm32x_k1_xmm:
				case Code.EVEX_Vscatterdpd_vm32x_k1_ymm:
				case Code.EVEX_Vscatterdpd_vm32y_k1_zmm:
				case Code.EVEX_Vscatterqps_vm64x_k1_xmm:
				case Code.EVEX_Vscatterqps_vm64y_k1_xmm:
				case Code.EVEX_Vscatterqps_vm64z_k1_ymm:
				case Code.EVEX_Vscatterqpd_vm64x_k1_xmm:
				case Code.EVEX_Vscatterqpd_vm64y_k1_ymm:
				case Code.EVEX_Vscatterqpd_vm64z_k1_zmm:
				case Code.EVEX_Vgatherpf0dps_vm32z_k1:
				case Code.EVEX_Vgatherpf0dpd_vm32y_k1:
				case Code.EVEX_Vgatherpf1dps_vm32z_k1:
				case Code.EVEX_Vgatherpf1dpd_vm32y_k1:
				case Code.EVEX_Vscatterpf0dps_vm32z_k1:
				case Code.EVEX_Vscatterpf0dpd_vm32y_k1:
				case Code.EVEX_Vscatterpf1dps_vm32z_k1:
				case Code.EVEX_Vscatterpf1dpd_vm32y_k1:
				case Code.EVEX_Vgatherpf0qps_vm64z_k1:
				case Code.EVEX_Vgatherpf0qpd_vm64z_k1:
				case Code.EVEX_Vgatherpf1qps_vm64z_k1:
				case Code.EVEX_Vgatherpf1qpd_vm64z_k1:
				case Code.EVEX_Vscatterpf0qps_vm64z_k1:
				case Code.EVEX_Vscatterpf0qpd_vm64z_k1:
				case Code.EVEX_Vscatterpf1qps_vm64z_k1:
				case Code.EVEX_Vscatterpf1qpd_vm64z_k1:
					dst.Flags |= Flags.NonZeroOpMaskRegister;
				break;
			}

			return dst;
		}

		static OpCodeDataBlock FillXopBlock(ref OpCodeDataBlock dst)
		{
			var dword3 = dst.DWord3;
			var dword2 = dst.DWord2;
			var dword1 = dst.DWord1;
			dst.op0Kind = XopData[(int)((dword3 >> (int)XopFlags3.Op0Shift) & (uint)XopFlags3.OpMask)];
			dst.op1Kind = XopData[(int)((dword3 >> (int)XopFlags3.Op1Shift) & (uint)XopFlags3.OpMask)];
			dst.op2Kind = XopData[(int)((dword3 >> (int)XopFlags3.Op2Shift) & (uint)XopFlags3.OpMask)];
			dst.op3Kind = XopData[(int)((dword3 >> (int)XopFlags3.Op3Shift) & (uint)XopFlags3.OpMask)];

			dst.mandatoryPrefix = (MandatoryPrefixByte)((dword2 >> (int)XopFlags.MandatoryPrefixByteShift) & (uint)XopFlags.MandatoryPrefixByteMask) switch {
				MandatoryPrefixByte.None => (byte)MandatoryPrefix.PNP,
				MandatoryPrefixByte.P66 => (byte)MandatoryPrefix.P66,
				MandatoryPrefixByte.PF3 => (byte)MandatoryPrefix.PF3,
				MandatoryPrefixByte.PF2 => (byte)MandatoryPrefix.PF2,
				_ => throw new InvalidOperationException(),
			};

			dst.table = (XopOpCodeTable)((dword2 >> (int)XopFlags.XopOpCodeTableShift) & (uint)XopFlags.XopOpCodeTableMask) switch {
				XopOpCodeTable.XOP8 => (byte)OpCodeTableKind.XOP8,
				XopOpCodeTable.XOP9 => (byte)OpCodeTableKind.XOP9,
				XopOpCodeTable.XOPA => (byte)OpCodeTableKind.XOPA,
				_ => throw new InvalidOperationException(),
			};

			dst.groupIndex = (sbyte)((dword2 & (uint)XopFlags.HasGroupIndex) == 0 ? -1 : (int)((dword2 >> (int)XopFlags.GroupShift) & 7));
			dst.tupleType = (byte)TupleType.None;

			dst.Flags |= (Encodable)((dword2 >> (int)XopFlags.EncodableShift) & (uint)XopFlags.EncodableMask) switch {
				Encodable.Any => Flags.Mode16 | Flags.Mode32 | Flags.Mode64,
				Encodable.Only1632 => Flags.Mode16 | Flags.Mode32,
				Encodable.Only64 => Flags.Mode64,
				_ => throw new InvalidOperationException(),
			};

			switch ((WBit)((dword2 >> (int)XopFlags.WBitShift) & (uint)XopFlags.WBitMask)) {
			case WBit.W1:
				dst.Flags |= Flags.W;
				break;
			case WBit.WIG:
				dst.Flags |= Flags.WIG;
				break;
			case WBit.WIG32:
				dst.Flags |= Flags.WIG32;
				break;
			}
			switch ((XopVectorLength)((dword2 >> (int)XopFlags.XopVectorLengthShift) & (uint)XopFlags.XopVectorLengthMask)) {
			case XopVectorLength.L128:
				dst.l = 0;
				dst.lkind = LKind.L128;
				break;
			case XopVectorLength.L256:
				dst.l = 1;
				dst.lkind = LKind.L128;
				break;
			case XopVectorLength.L0:
				dst.l = 0;
				dst.lkind = LKind.L0;
				break;
			case XopVectorLength.L1:
				dst.l = 1;
				dst.lkind = LKind.L0;
				break;
			default:
				throw new InvalidOperationException();
			}

			return dst;
		}
	}
}