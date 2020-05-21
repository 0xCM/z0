//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
	using System.Linq;

	public readonly struct OpCodeInfoParsed
	{
		public static Code ParseId(string src)
		{
			var success = Enum.TryParse(typeof(Code), src, true, out var x);
			var codeId = success ? (Code)x : default(Code);
			return codeId;
		}

		public static OpCodeInfoParsed Define(Code id, string instruction, string expression, byte[] modes, string cpuid)
		{
			return new OpCodeInfoParsed(id, instruction, expression, modes, cpuid);
		}

		public OpCodeInfoParsed(Code id, string instruction, string expression,  byte[] modes, string cpuid)
		{
			var idx = instruction.IndexOf(' ');
			if(idx != -1)
				Mnemonic = instruction.Substring(0,idx);
			else
				Mnemonic = instruction;
			Id = id;
			Instruction = instruction;
			Expression = expression;
			Mode16 = modes.Any(m => m == 16);
			Mode32 = modes.Any(m => m == 32);
			Mode64 = modes.Any(m => m == 64);
			CpuId = cpuid;

		}
		
		public readonly Code Id;
		
		public readonly string Mnemonic;
		
		public readonly string Instruction;

		public readonly string Expression;

        public static YeaOrNea yn(bool src) 
            => src ? YeaOrNea.Y : YeaOrNea.N;

        public YeaOrNea RexW => yn(Expression.Contains("REX.W"));

        string NoRex => Expression.Replace("REX.W ",string.Empty);

        public string OrderBy => $"{Mnemonic}{NoRex}{RexW}";

		public string Modes 
		{
			get
			{
				var modes = new List<string>();
				if(Mode16)
					modes.Add("16");
				if(Mode32)
					modes.Add("32");
				if(Mode64)
					modes.Add("64");
				var s = string.Join('/',modes);
				s += "-bit";
				return s;							
			}
		}

		public readonly bool Mode16;

		public readonly bool Mode32;

		public readonly bool Mode64;

		public readonly string CpuId;

		const string Sep = " | ";
		
		public string Format()
		{
			return String.Concat(			
				Instruction.PadRight(50),  Sep,
				Expression.PadRight(30),  Sep,
				Modes.PadRight(16), Sep,
				CpuId
				);
		}

		public override string ToString()
			=> Format();
	}
	public class OpCodeInfoParser
    {
        static string CleanOpCode(string src)
        {
            if(src.StartsWith("o16 ") || src.StartsWith("o32 "))
                return src.Substring(4);
            else
                return src;
        }

		public static OpCodeInfoParsed[] ParseOpCodeInfo(FilePath src)
		{
			var specs = new List<OpCodeInfoParsed>();
			bool checkedIt = false;
			const char sepChar = '|';
			var toInstrInfo = InstrInfoTable.Data.ToDictionary(a => a.Code.RawName, a => a, StringComparer.Ordinal);
			var toOpCodeInfo = OpCodeInfoTable.Data.ToDictionary(a => a.Code.RawName, a => a, StringComparer.Ordinal);
			var sb = new StringBuilder();
			foreach (var line in src.ReadLines()) 
			{
				if (line.Length == 0 || line[0] == '#')
					continue;
				var parts = line.Split(',');
				if (parts.Length != 8)
					throw new InvalidOperationException("Invalid file");
				var name = parts[0].Trim();
				var opCodeStr = parts[5].Trim();
				var instructionStr = parts[6].Trim();
				if (name == "EVEX_Vbroadcastf64x2_zmm_k1z_m128") {
					// Verify that we read the correct columns, in case someone reorders them...
					if (opCodeStr != "EVEX.512.66.0F38.W1 1A /r" || instructionStr != $"VBROADCASTF64X2 zmm1 {{k1}}{{z}}{sepChar} m128")
						throw new InvalidOperationException("Wrong columns!");
					checkedIt = true;
				}
				instructionStr = instructionStr.Replace(sepChar, ',');
				
				var id = OpCodeInfoParsed.ParseId(name);
				if(id != 0)
				{
					var ocs = CleanOpCode(opCodeStr);
					var modes = OpCodeInfo.GetModes(toOpCodeInfo[name]);
					var cpuid = GetCpuid(toInstrInfo[name]);
					var spec = OpCodeInfoParsed.Define(id, instructionStr, ocs, modes, cpuid);				
					specs.Add(spec);
				}
			}
			return specs.ToArray();
		}

		static string GetCpuid(InstrInfo info) 
		{
			if ((info.Flags & InstrInfoFlags.AVX2_Check) != 0)
				return "AVX (reg,mem) or AVX2 (reg,reg)";
			return string.Join(" and ", info.Cpuid.Select(a => GetCpuid(a)));
		}

		static string GetCpuid(IceEnumValue c) =>
			(CpuidFeature)c.Value switch {
				CpuidFeature.INTEL8086 => "8086+",
				CpuidFeature.INTEL8086_ONLY => "8086",
				CpuidFeature.INTEL186 => "186+",
				CpuidFeature.INTEL286 => "286+",
				CpuidFeature.INTEL286_ONLY => "286",
				CpuidFeature.INTEL386 => "386+",
				CpuidFeature.INTEL386_ONLY => "386",
				CpuidFeature.INTEL386_A0_ONLY => "386 A0",
				CpuidFeature.INTEL486 => "486+",
				CpuidFeature.INTEL486_A_ONLY => "486 A",
				CpuidFeature.INTEL386_486_ONLY => "386/486",
				CpuidFeature.IA64 => "IA-64",
				CpuidFeature.FPU => "8087+",
				CpuidFeature.FPU287 => "287+",
				CpuidFeature.FPU287XL_ONLY => "287 XL",
				CpuidFeature.FPU387 => "387+",
				CpuidFeature.FPU387SL_ONLY => "387 SL",
				CpuidFeature.GEODE => "AMD Geode LX/GX",
				CpuidFeature.HLE_or_RTM => "HLE or RTM",
				CpuidFeature.SKINIT_or_SVML => "SKINIT or SVML",
				CpuidFeature.INVEPT => "VMX and IA32_VMX_EPT_VPID_CAP[bit 20]",
				CpuidFeature.INVVPID => "VMX and IA32_VMX_EPT_VPID_CAP[bit 32]",
				CpuidFeature.MULTIBYTENOP => "CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B",
				CpuidFeature.PAUSE => "Pentium 4 or later",
				CpuidFeature.RDPMC => "Pentium MMX or later, or Pentium Pro or later",
				CpuidFeature.D3NOW => "3DNOW",
				CpuidFeature.D3NOWEXT => "3DNOWEXT",
				CpuidFeature.SSE4_1 => "SSE4.1",
				CpuidFeature.SSE4_2 => "SSE4.2",
				_ => c.RawName,
			};


		static string GetMode(OpCodeInfo opCode) 
		{
			var sb = new StringBuilder();
			if ((opCode.Flags & OpCodeFlags.Mode16) != 0)
				sb.Append("16");
			if ((opCode.Flags & OpCodeFlags.Mode32) != 0) {
				if (sb.Length > 0)
					sb.Append('/');
				sb.Append("32");
			}
			if ((opCode.Flags & OpCodeFlags.Mode64) != 0) {
				if (sb.Length > 0)
					sb.Append('/');
				sb.Append("64");
			}
			if (sb.Length == 0)
				throw new InvalidOperationException();
			sb.Append("-bit");
			return sb.ToString();
		}
    }
}