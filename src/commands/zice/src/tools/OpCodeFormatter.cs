//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Text;

	readonly struct OpCodeFormatter 
	{
		readonly OpCodeDataAdapter adapter;

		OpCodeDataAdapter data => adapter;

		readonly StringBuilder sb;
		
		readonly LKind lkind;

		public OpCodeFormatter(OpCodeDataAdapter adapter, StringBuilder sb, LKind lkind) 
		{
			this.adapter = adapter;
			this.sb = sb;
			this.lkind = lkind;
		}

		public OpCodeFormatter(OpCodeSummary opCode, StringBuilder sb, LKind lkind) 
		{
			this.adapter = default;
			this.sb = sb;
			this.lkind = lkind;
		}

		public string Format() {
			if (!data.IsInstruction) {
				return data.Code switch {
					Code.INVALID => "<invalid>",
					Code.DeclareByte => "<db>",
					Code.DeclareWord => "<dw>",
					Code.DeclareDword => "<dd>",
					Code.DeclareQword => "<dq>",
					_ => throw new InvalidOperationException(),
				};
			}

			return data.Encoding switch {
				EncodingKind.Legacy => Format_Legacy(),
				EncodingKind.VEX => Format_VEX_XOP_EVEX("VEX"),
				EncodingKind.EVEX => Format_VEX_XOP_EVEX("EVEX"),
				EncodingKind.XOP => Format_VEX_XOP_EVEX("XOP"),
				EncodingKind.D3NOW => Format_3DNow(),
				_ => throw new InvalidOperationException(),
			};
		}

		void AppendHexByte(byte value) => sb.Append(value.ToString("X2"));

		void AppendOpCode(uint value, bool sep) {
			if (value <= byte.MaxValue)
				AppendHexByte((byte)value);
			else if (value <= ushort.MaxValue) {
				AppendHexByte((byte)(value >> 8));
				if (sep)
					sb.Append(' ');
				AppendHexByte((byte)value);
			}
			else
				throw new InvalidOperationException();
		}

		void AppendTable(bool sep) {
			switch (data.Table) {
			case OpCodeTableKind.Normal:
				break;

			case OpCodeTableKind.T0F:
				AppendOpCode(0x0F, sep);
				break;

			case OpCodeTableKind.T0F38:
				AppendOpCode(0x0F38, sep);
				break;

			case OpCodeTableKind.T0F3A:
				AppendOpCode(0x0F3A, sep);
				break;

			case OpCodeTableKind.XOP8:
				sb.Append("X8");
				break;

			case OpCodeTableKind.XOP9:
				sb.Append("X9");
				break;

			case OpCodeTableKind.XOPA:
				sb.Append("XA");
				break;

			default:
				throw new InvalidOperationException();
			}
		}

		bool HasModRM() {
			int opCount = data.OpCount;
			if (opCount == 0)
				return false;

			switch (data.Encoding) {
			case EncodingKind.Legacy:
				break;
			case EncodingKind.VEX:
			case EncodingKind.EVEX:
			case EncodingKind.XOP:
			case EncodingKind.D3NOW:
				return true;
			default:
				throw new InvalidOperationException();
			}

			for (int i = 0; i < opCount; i++) {
				switch (data.GetOpKind(i)) {
				case OpCodeOperandKind.mem:
				case OpCodeOperandKind.mem_mpx:
				case OpCodeOperandKind.mem_mib:
				case OpCodeOperandKind.mem_vsib32x:
				case OpCodeOperandKind.mem_vsib64x:
				case OpCodeOperandKind.mem_vsib32y:
				case OpCodeOperandKind.mem_vsib64y:
				case OpCodeOperandKind.mem_vsib32z:
				case OpCodeOperandKind.mem_vsib64z:
				case OpCodeOperandKind.r8_or_mem:
				case OpCodeOperandKind.r16_or_mem:
				case OpCodeOperandKind.r32_or_mem:
				case OpCodeOperandKind.r32_or_mem_mpx:
				case OpCodeOperandKind.r64_or_mem:
				case OpCodeOperandKind.r64_or_mem_mpx:
				case OpCodeOperandKind.mm_or_mem:
				case OpCodeOperandKind.xmm_or_mem:
				case OpCodeOperandKind.ymm_or_mem:
				case OpCodeOperandKind.zmm_or_mem:
				case OpCodeOperandKind.bnd_or_mem_mpx:
				case OpCodeOperandKind.k_or_mem:
				case OpCodeOperandKind.r8_reg:
				case OpCodeOperandKind.r16_reg:
				case OpCodeOperandKind.r16_reg_mem:
				case OpCodeOperandKind.r16_rm:
				case OpCodeOperandKind.r32_reg:
				case OpCodeOperandKind.r32_reg_mem:
				case OpCodeOperandKind.r32_rm:
				case OpCodeOperandKind.r64_reg:
				case OpCodeOperandKind.r64_reg_mem:
				case OpCodeOperandKind.r64_rm:
				case OpCodeOperandKind.seg_reg:
				case OpCodeOperandKind.k_reg:
				case OpCodeOperandKind.kp1_reg:
				case OpCodeOperandKind.k_rm:
				case OpCodeOperandKind.mm_reg:
				case OpCodeOperandKind.mm_rm:
				case OpCodeOperandKind.xmm_reg:
				case OpCodeOperandKind.xmm_rm:
				case OpCodeOperandKind.ymm_reg:
				case OpCodeOperandKind.ymm_rm:
				case OpCodeOperandKind.zmm_reg:
				case OpCodeOperandKind.zmm_rm:
				case OpCodeOperandKind.cr_reg:
				case OpCodeOperandKind.dr_reg:
				case OpCodeOperandKind.tr_reg:
				case OpCodeOperandKind.bnd_reg:
				// GENERATOR-END: HasModRM
					return true;
				}
			}
			return false;
		}

		bool HasVsib() {
			int opCount = data.OpCount;
			for (int i = 0; i < opCount; i++) {
				switch (data.GetOpKind(i)) {
				case OpCodeOperandKind.mem_vsib32x:
				case OpCodeOperandKind.mem_vsib64x:
				case OpCodeOperandKind.mem_vsib32y:
				case OpCodeOperandKind.mem_vsib64y:
				case OpCodeOperandKind.mem_vsib32z:
				case OpCodeOperandKind.mem_vsib64z:
					return true;
				}
			}
			return false;
		}

		OpCodeOperandKind GetOpCodeBitsOperand() {
			int opCount = data.OpCount;
			for (int i = 0; i < opCount; i++) {
				var opKind = data.GetOpKind(i);
				switch (opKind) {
				case OpCodeOperandKind.r8_opcode:
				case OpCodeOperandKind.r16_opcode:
				case OpCodeOperandKind.r32_opcode:
				case OpCodeOperandKind.r64_opcode:
					return opKind;
				}
			}
			return OpCodeOperandKind.None;
		}

		void AppendRest() {
			bool isVsib = data.Encoding == EncodingKind.EVEX && HasVsib();
			if (data.IsGroup) {
				sb.Append(" /");
				sb.Append(data.GroupIndex);
			}
			else if (!isVsib && HasModRM())
				sb.Append(" /r");
			if (isVsib)
				sb.Append(" /vsib");

			int opCount = data.OpCount;
			for (int i = 0; i < opCount; i++) {
				switch (data.GetOpKind(i)) {
				case OpCodeOperandKind.br16_1:
				case OpCodeOperandKind.br32_1:
				case OpCodeOperandKind.br64_1:
					sb.Append(" cb");
					break;

				case OpCodeOperandKind.br16_2:
				case OpCodeOperandKind.xbegin_2:
				case OpCodeOperandKind.brdisp_2:
					sb.Append(" cw");
					break;

				case OpCodeOperandKind.farbr2_2:
				case OpCodeOperandKind.br32_4:
				case OpCodeOperandKind.br64_4:
				case OpCodeOperandKind.xbegin_4:
				case OpCodeOperandKind.brdisp_4:
					sb.Append(" cd");
					break;

				case OpCodeOperandKind.farbr4_2:
					sb.Append(" cp");
					break;

				case OpCodeOperandKind.imm8:
				case OpCodeOperandKind.imm8sex16:
				case OpCodeOperandKind.imm8sex32:
				case OpCodeOperandKind.imm8sex64:
					sb.Append(" ib");
					break;

				case OpCodeOperandKind.imm16:
					sb.Append(" iw");
					break;

				case OpCodeOperandKind.imm32:
				case OpCodeOperandKind.imm32sex64:
					sb.Append(" id");
					break;

				case OpCodeOperandKind.imm64:
					sb.Append(" io");
					break;

				case OpCodeOperandKind.xmm_is4:
				case OpCodeOperandKind.ymm_is4:
					sb.Append(" /is4");
					break;

				case OpCodeOperandKind.xmm_is5:
				case OpCodeOperandKind.ymm_is5:
					sb.Append(" /is5");
					// don't show the next imm8
					i = opCount;
					break;

				case OpCodeOperandKind.mem_offs:
					sb.Append(" mo");
					break;
				}
			}
		}

		string Format_Legacy() {
			sb.Length = 0;

			if (data.Fwait) {
				AppendHexByte(0x9B);
				sb.Append(' ');
			}

			switch (data.AddressSize) {
			case 0:
				break;

			case 16:
				sb.Append("a16 ");
				break;

			case 32:
				sb.Append("a32 ");
				break;

			default:
				throw new InvalidOperationException();
			}

			switch (data.OperandSize) {
			case 0:
				break;

			case 16:
				sb.Append("o16 ");
				break;

			case 32:
				sb.Append("o32 ");
				break;

			case 64:
				// REX.W must be immediately before the opcode and is handled below
				break;

			default:
				throw new InvalidOperationException();
			}

			switch (data.MandatoryPrefix) {
			case MandatoryPrefix.None:
				break;
			case MandatoryPrefix.PNP:
				sb.Append("NP ");
				break;
			case MandatoryPrefix.P66:
				AppendHexByte(0x66);
				sb.Append(' ');
				break;
			case MandatoryPrefix.PF3:
				AppendHexByte(0xF3);
				sb.Append(' ');
				break;
			case MandatoryPrefix.PF2:
				AppendHexByte(0xF2);
				sb.Append(' ');
				break;
			default:
				throw new InvalidOperationException();
			}

			if (data.OperandSize == 64) {
				// There's no '+' because Intel isn't consistent, some opcodes use it others don't
				sb.Append("REX.W ");
			}

			AppendTable(true);
			if (data.Table != OpCodeTableKind.Normal)
				sb.Append(' ');
			AppendOpCode(data.OpCode, true);
			switch (GetOpCodeBitsOperand()) {
			case OpCodeOperandKind.r8_opcode:
				sb.Append("+rb");
				break;
			case OpCodeOperandKind.r16_opcode:
				sb.Append("+rw");
				break;
			case OpCodeOperandKind.r32_opcode:
				sb.Append("+rd");
				break;
			case OpCodeOperandKind.r64_opcode:
				sb.Append("+ro");
				break;
			case OpCodeOperandKind.None:
				break;
			default:
				throw new InvalidOperationException();
			}
			int opCount = data.OpCount;
			for (int i = 0; i < opCount; i++) {
				if (data.GetOpKind(i) == OpCodeOperandKind.sti_opcode) {
					sb.Append("+i");
					break;
				}
			}

			AppendRest();

			return sb.ToString();
		}

		string Format_3DNow() {
			sb.Length = 0;

			AppendOpCode(0x0F0F, true);
			sb.Append(" /r");
			sb.Append(' ');
			AppendOpCode(data.OpCode, true);

			return sb.ToString();
		}

		string Format_VEX_XOP_EVEX(string encodingName) {
			sb.Length = 0;

			sb.Append(encodingName);
			sb.Append('.');
			if (data.IsLIG)
				sb.Append("LIG");
			else {
				switch (lkind) {
				case LKind.L128:
					sb.Append(128U << (int)data.L);
					break;
				case LKind.L0:
					sb.Append('L');
					sb.Append(data.L);
					break;
				case LKind.LZ:
					if (data.L != 0)
						throw new InvalidOperationException();
					sb.Append("LZ");
					break;
				case LKind.None:
				default:
					throw new InvalidOperationException();
				}
			}
			switch (data.MandatoryPrefix) {
			case MandatoryPrefix.None:
			case MandatoryPrefix.PNP:
				break;
			case MandatoryPrefix.P66:
				sb.Append('.');
				AppendHexByte(0x66);
				break;
			case MandatoryPrefix.PF3:
				sb.Append('.');
				AppendHexByte(0xF3);
				break;
			case MandatoryPrefix.PF2:
				sb.Append('.');
				AppendHexByte(0xF2);
				break;
			default:
				throw new InvalidOperationException();
			}
			sb.Append('.');
			AppendTable(false);
			if (data.IsWIG)
				sb.Append(".WIG");
			else {
				sb.Append(".W");
				sb.Append(data.W);
			}
			sb.Append(' ');
			AppendOpCode(data.OpCode, true);
			AppendRest();

			return sb.ToString();
		}
	}    
}