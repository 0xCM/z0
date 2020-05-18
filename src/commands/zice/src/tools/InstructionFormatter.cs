//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Text;

    using static Seed;
    using static Memories;


    static class XYZ
    {
		/// <summary>
		/// Gets the mnemonic
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[System.Obsolete("Use " + nameof(Mnemonic) + " instead of this method", true)]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static Mnemonic ToMnemonic(this Code code) => code.Mnemonic();

		/// <summary>
		/// Gets the mnemonic
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		public static Mnemonic Mnemonic(this Code code) 
		{
			insist((uint)code < (uint)MnemonicUtilsData.toMnemonic.Length);
			return (Mnemonic)MnemonicUtilsData.toMnemonic[(int)code];
		}

		/// <summary>
		/// Gets the memory size info
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static MemorySizeInfo GetInfo(this MemorySize memorySize) 
		{
			var infos = MemorySizeInfos;
			if ((uint)memorySize >= (uint)infos.Length)
				throw new ArgumentOutOfRangeException();
			return infos[(int)memorySize];
		}

		/// <summary>
		/// Gets the size in bytes of the packed element. If it's not a packed data type, it's equal to <see cref="GetSize(MemorySize)"/>.
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static int GetElementSize(this MemorySize memorySize) => memorySize.GetInfo().ElementSize;

		/// <summary>
		/// Gets the element type if it's packed data or <paramref name="memorySize"/> if it's not packed data
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static MemorySize GetElementType(this MemorySize memorySize) => memorySize.GetInfo().ElementType;

		/// <summary>
		/// <see langword="true"/> if it's signed data (signed integer or a floating point value)
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static bool IsSigned(this MemorySize memorySize) => memorySize.GetInfo().IsSigned;

		/// <summary>
		/// Checks if <paramref name="memorySize"/> is a broadcast memory type
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static bool IsBroadcast(this MemorySize memorySize) => memorySize >= IcedConstants.FirstBroadcastMemorySize;
		/// <summary>
		/// Gets the size in bytes of the memory location or 0 if it's not accessed by the instruction or unknown or variable sized
		/// </summary>
		/// <param name="memorySize">Memory size</param>
		/// <returns></returns>
		public static int GetSize(this MemorySize memorySize) => memorySize.GetInfo().Size;


		internal static readonly MemorySizeInfo[] MemorySizeInfos = GetMemorySizeInfos();

		static MemorySizeInfo[] GetMemorySizeInfos() {
			System.ReadOnlySpan<byte> data = new byte[IcedConstants.NumberOfMemorySizes * 3] {
				(byte)MemorySize.Unknown, (byte)((uint)SizeKind.S0 | ((uint)SizeKind.S0 << 4)), 0,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S1 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt128, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S16 << 4)), 0,
				(byte)MemorySize.UInt256, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S32 << 4)), 0,
				(byte)MemorySize.UInt512, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S64 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S1 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Int128, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S16 << 4)), 1,
				(byte)MemorySize.Int256, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S32 << 4)), 1,
				(byte)MemorySize.Int512, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S64 << 4)), 1,
				(byte)MemorySize.SegPtr16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.SegPtr32, (byte)((uint)SizeKind.S6 | ((uint)SizeKind.S6 << 4)), 0,
				(byte)MemorySize.SegPtr64, (byte)((uint)SizeKind.S10 | ((uint)SizeKind.S10 << 4)), 0,
				(byte)MemorySize.WordOffset, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.DwordOffset, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.QwordOffset, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Bound16_WordWord, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Bound32_DwordDword, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Bnd32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Bnd64, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S16 << 4)), 0,
				(byte)MemorySize.Fword6, (byte)((uint)SizeKind.S6 | ((uint)SizeKind.S6 << 4)), 0,
				(byte)MemorySize.Fword10, (byte)((uint)SizeKind.S10 | ((uint)SizeKind.S10 << 4)), 0,
				(byte)MemorySize.Float16, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float80, (byte)((uint)SizeKind.S10 | ((uint)SizeKind.S10 << 4)), 1,
				(byte)MemorySize.Float128, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S16 << 4)), 1,
				(byte)MemorySize.BFloat16, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.FpuEnv14, (byte)((uint)SizeKind.S14 | ((uint)SizeKind.S14 << 4)), 0,
				(byte)MemorySize.FpuEnv28, (byte)((uint)SizeKind.S28 | ((uint)SizeKind.S28 << 4)), 0,
				(byte)MemorySize.FpuState94, (byte)((uint)SizeKind.S94 | ((uint)SizeKind.S94 << 4)), 0,
				(byte)MemorySize.FpuState108, (byte)((uint)SizeKind.S108 | ((uint)SizeKind.S108 << 4)), 0,
				(byte)MemorySize.Fxsave_512Byte, (byte)((uint)SizeKind.S512 | ((uint)SizeKind.S512 << 4)), 0,
				(byte)MemorySize.Fxsave64_512Byte, (byte)((uint)SizeKind.S512 | ((uint)SizeKind.S512 << 4)), 0,
				(byte)MemorySize.Xsave, (byte)((uint)SizeKind.S0 | ((uint)SizeKind.S0 << 4)), 0,
				(byte)MemorySize.Xsave64, (byte)((uint)SizeKind.S0 | ((uint)SizeKind.S0 << 4)), 0,
				(byte)MemorySize.Bcd, (byte)((uint)SizeKind.S10 | ((uint)SizeKind.S10 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S2 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.BFloat16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float16, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float16, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Packed32_BFloat16, (byte)((uint)SizeKind.S16 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.UInt128, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S16 << 4)), 0,
				(byte)MemorySize.Int128, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S16 << 4)), 1,
				(byte)MemorySize.Float16, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float128, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S16 << 4)), 1,
				(byte)MemorySize.Packed32_BFloat16, (byte)((uint)SizeKind.S32 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt8, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S1 << 4)), 0,
				(byte)MemorySize.Int8, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S1 << 4)), 1,
				(byte)MemorySize.UInt16, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S2 << 4)), 0,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.UInt128, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S16 << 4)), 0,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Packed32_BFloat16, (byte)((uint)SizeKind.S64 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.UInt52, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.UInt64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 0,
				(byte)MemorySize.Int64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Float32, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Float64, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S8 << 4)), 1,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.Int16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.UInt32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 0,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.Int32, (byte)((uint)SizeKind.S8 | ((uint)SizeKind.S4 << 4)), 1,
				(byte)MemorySize.BFloat16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.BFloat16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				(byte)MemorySize.BFloat16, (byte)((uint)SizeKind.S4 | ((uint)SizeKind.S2 << 4)), 1,
				// GENERATOR-END: MemorySizeInfoTable
			};

			var sizes = new ushort[] {
				0,
				1,
				2,
				4,
				6,
				8,
				10,
				14,
				16,
				28,
				32,
				64,
				94,
				108,
				512,
			};

			var infos = new MemorySizeInfo[IcedConstants.NumberOfMemorySizes];
			for (int i = 0, j = 0; i < infos.Length; i++, j += 3) {
				var elementType = (MemorySize)data[j];
				var b = data[j + 1];
				var size = sizes[b & 0xF];
				var elementSize = sizes[b >> 4];
				infos[i] = new MemorySizeInfo((MemorySize)i, size, elementSize, elementType, data[j + 2] != 0, i >= (int)IcedConstants.FirstBroadcastMemorySize);
			}
			return infos;


        }

		enum SizeKind {
			S0,
			S1,
			S2,
			S4,
			S6,
			S8,
			S10,
			S14,
			S16,
			S28,
			S32,
			S64,
			S94,
			S108,
			S512,
		}

    }



	struct InstructionFormatter 
	{
		readonly OpCodeSummary opCode;
		
		readonly StringBuilder sb;
		
		readonly int r32_count;
		
		readonly int r64_count;
		
		readonly int bnd_count;
		
		readonly int startOpIndex;
		
		int r32_index, r64_index, bnd_index;
		
		int k_index;
		
		int vec_index;
		
		int opCount;
		
		// true: k2 {k1}, false: k1 {k2}		
		readonly bool opMaskIsK1;
		
		readonly bool noVecIndex;
		
		readonly bool swapVecIndex12;

		int GetKIndex() {
			k_index++;
			if (opMaskIsK1) {
				if (k_index == 1)
					return 2;
				if (k_index == 2)
					return 1;
			}
			return k_index;
		}

		int GetBndIndex() {
			if (bnd_count <= 1)
				return 0;
			bnd_index++;
			return bnd_index;
		}

		int GetVecIndex() {
			if (noVecIndex)
				return 0;
			vec_index++;
			if (swapVecIndex12) {
				if (vec_index == 1)
					return 2;
				if (vec_index == 2)
					return 1;
			}
			return vec_index;
		}

		public InstructionFormatter(OpCodeSummary opCode, StringBuilder sb) {
			this.opCode = opCode;
			this.sb = sb;
			noVecIndex = false;
			swapVecIndex12 = false;
			startOpIndex = 0;
			bnd_count = 0;
			r32_count = 0;
			r64_count = 0;
			r32_index = 0;
			r64_index = 0;
			k_index = 0;
			vec_index = 0;
			bnd_index = 0;
			opCount = opCode.OpCount;
			opMaskIsK1 = false;
			if ((opCode.Op0Kind == OpCodeOperandKind.k_reg || opCode.Op0Kind == OpCodeOperandKind.kp1_reg) && opCode.OpCount > 2)
				vec_index++;
			switch (opCode.Code) {
			// GENERATOR-BEGIN: OpMaskIsK1
			case Code.EVEX_Vfpclassps_k_k1_xmmm128b32_imm8:
			case Code.EVEX_Vfpclassps_k_k1_ymmm256b32_imm8:
			case Code.EVEX_Vfpclassps_k_k1_zmmm512b32_imm8:
			case Code.EVEX_Vfpclasspd_k_k1_xmmm128b64_imm8:
			case Code.EVEX_Vfpclasspd_k_k1_ymmm256b64_imm8:
			case Code.EVEX_Vfpclasspd_k_k1_zmmm512b64_imm8:
			case Code.EVEX_Vfpclassss_k_k1_xmmm32_imm8:
			case Code.EVEX_Vfpclasssd_k_k1_xmmm64_imm8:
			case Code.EVEX_Vptestmb_k_k1_xmm_xmmm128:
			case Code.EVEX_Vptestmb_k_k1_ymm_ymmm256:
			case Code.EVEX_Vptestmb_k_k1_zmm_zmmm512:
			case Code.EVEX_Vptestmw_k_k1_xmm_xmmm128:
			case Code.EVEX_Vptestmw_k_k1_ymm_ymmm256:
			case Code.EVEX_Vptestmw_k_k1_zmm_zmmm512:
			case Code.EVEX_Vptestnmb_k_k1_xmm_xmmm128:
			case Code.EVEX_Vptestnmb_k_k1_ymm_ymmm256:
			case Code.EVEX_Vptestnmb_k_k1_zmm_zmmm512:
			case Code.EVEX_Vptestnmw_k_k1_xmm_xmmm128:
			case Code.EVEX_Vptestnmw_k_k1_ymm_ymmm256:
			case Code.EVEX_Vptestnmw_k_k1_zmm_zmmm512:
			case Code.EVEX_Vptestmd_k_k1_xmm_xmmm128b32:
			case Code.EVEX_Vptestmd_k_k1_ymm_ymmm256b32:
			case Code.EVEX_Vptestmd_k_k1_zmm_zmmm512b32:
			case Code.EVEX_Vptestmq_k_k1_xmm_xmmm128b64:
			case Code.EVEX_Vptestmq_k_k1_ymm_ymmm256b64:
			case Code.EVEX_Vptestmq_k_k1_zmm_zmmm512b64:
			case Code.EVEX_Vptestnmd_k_k1_xmm_xmmm128b32:
			case Code.EVEX_Vptestnmd_k_k1_ymm_ymmm256b32:
			case Code.EVEX_Vptestnmd_k_k1_zmm_zmmm512b32:
			case Code.EVEX_Vptestnmq_k_k1_xmm_xmmm128b64:
			case Code.EVEX_Vptestnmq_k_k1_ymm_ymmm256b64:
			case Code.EVEX_Vptestnmq_k_k1_zmm_zmmm512b64:
			// GENERATOR-END: OpMaskIsK1
				opMaskIsK1 = true;
				break;
			// GENERATOR-BEGIN: IncVecIndex
			case Code.VEX_Vpextrw_r32m16_xmm_imm8:
			case Code.VEX_Vpextrw_r64m16_xmm_imm8:
			case Code.EVEX_Vpextrw_r32m16_xmm_imm8:
			case Code.EVEX_Vpextrw_r64m16_xmm_imm8:
			case Code.VEX_Vmovmskpd_r32_xmm:
			case Code.VEX_Vmovmskpd_r64_xmm:
			case Code.VEX_Vmovmskpd_r32_ymm:
			case Code.VEX_Vmovmskpd_r64_ymm:
			case Code.VEX_Vmovmskps_r32_xmm:
			case Code.VEX_Vmovmskps_r64_xmm:
			case Code.VEX_Vmovmskps_r32_ymm:
			case Code.VEX_Vmovmskps_r64_ymm:
			case Code.Pextrb_r32m8_xmm_imm8:
			case Code.Pextrb_r64m8_xmm_imm8:
			case Code.Pextrd_rm32_xmm_imm8:
			case Code.Pextrq_rm64_xmm_imm8:
			case Code.VEX_Vpextrb_r32m8_xmm_imm8:
			case Code.VEX_Vpextrb_r64m8_xmm_imm8:
			case Code.VEX_Vpextrd_rm32_xmm_imm8:
			case Code.VEX_Vpextrq_rm64_xmm_imm8:
			case Code.EVEX_Vpextrb_r32m8_xmm_imm8:
			case Code.EVEX_Vpextrb_r64m8_xmm_imm8:
			case Code.EVEX_Vpextrd_rm32_xmm_imm8:
			case Code.EVEX_Vpextrq_rm64_xmm_imm8:
			// GENERATOR-END: IncVecIndex
				vec_index++;
				break;
			// GENERATOR-BEGIN: NoVecIndex
			case Code.Pxor_mm_mmm64:
			case Code.Punpckldq_mm_mmm32:
			case Code.Punpcklwd_mm_mmm32:
			case Code.Punpcklbw_mm_mmm32:
			case Code.Punpckhdq_mm_mmm64:
			case Code.Punpckhwd_mm_mmm64:
			case Code.Punpckhbw_mm_mmm64:
			case Code.Psubusb_mm_mmm64:
			case Code.Psubusw_mm_mmm64:
			case Code.Psubsw_mm_mmm64:
			case Code.Psubsb_mm_mmm64:
			case Code.Psubd_mm_mmm64:
			case Code.Psubw_mm_mmm64:
			case Code.Psubb_mm_mmm64:
			case Code.Psrlq_mm_imm8:
			case Code.Psrlq_mm_mmm64:
			case Code.Psrld_mm_imm8:
			case Code.Psrld_mm_mmm64:
			case Code.Psrlw_mm_imm8:
			case Code.Psrlw_mm_mmm64:
			case Code.Psrad_mm_imm8:
			case Code.Psrad_mm_mmm64:
			case Code.Psraw_mm_imm8:
			case Code.Psraw_mm_mmm64:
			case Code.Psllq_mm_imm8:
			case Code.Psllq_mm_mmm64:
			case Code.Pslld_mm_imm8:
			case Code.Pslld_mm_mmm64:
			case Code.Psllw_mm_mmm64:
			case Code.Por_mm_mmm64:
			case Code.Pmullw_mm_mmm64:
			case Code.Pmulhw_mm_mmm64:
			case Code.Pmovmskb_r32_mm:
			case Code.Pmovmskb_r64_mm:
			case Code.Pmovmskb_r32_xmm:
			case Code.Pmovmskb_r64_xmm:
			case Code.Pmaddwd_mm_mmm64:
			case Code.Pinsrw_mm_r32m16_imm8:
			case Code.Pinsrw_mm_r64m16_imm8:
			case Code.Pinsrw_xmm_r32m16_imm8:
			case Code.Pinsrw_xmm_r64m16_imm8:
			case Code.Pextrw_r32_xmm_imm8:
			case Code.Pextrw_r64_xmm_imm8:
			case Code.Pextrw_r32m16_xmm_imm8:
			case Code.Pextrw_r64m16_xmm_imm8:
			case Code.Pextrw_r32_mm_imm8:
			case Code.Pextrw_r64_mm_imm8:
			case Code.Cvtpd2pi_mm_xmmm128:
			case Code.Cvtpi2pd_xmm_mmm64:
			case Code.Cvtpi2ps_xmm_mmm64:
			case Code.Cvtps2pi_mm_xmmm64:
			case Code.Cvttpd2pi_mm_xmmm128:
			case Code.Cvttps2pi_mm_xmmm64:
			case Code.Movd_mm_rm32:
			case Code.Movq_mm_rm64:
			case Code.Movd_rm32_mm:
			case Code.Movq_rm64_mm:
			case Code.Movd_xmm_rm32:
			case Code.Movq_xmm_rm64:
			case Code.Movd_rm32_xmm:
			case Code.Movq_rm64_xmm:
			case Code.Movdq2q_mm_xmm:
			case Code.Movmskpd_r32_xmm:
			case Code.Movmskpd_r64_xmm:
			case Code.Movmskps_r32_xmm:
			case Code.Movmskps_r64_xmm:
			case Code.Movntq_m64_mm:
			case Code.Movq_mm_mmm64:
			case Code.Movq_mmm64_mm:
			case Code.Movq2dq_xmm_mm:
			case Code.Packuswb_mm_mmm64:
			case Code.Paddb_mm_mmm64:
			case Code.Paddw_mm_mmm64:
			case Code.Paddd_mm_mmm64:
			case Code.Paddq_mm_mmm64:
			case Code.Paddsb_mm_mmm64:
			case Code.Paddsw_mm_mmm64:
			case Code.Paddusb_mm_mmm64:
			case Code.Paddusw_mm_mmm64:
			case Code.Pand_mm_mmm64:
			case Code.Pandn_mm_mmm64:
			case Code.Pcmpeqb_mm_mmm64:
			case Code.Pcmpeqw_mm_mmm64:
			case Code.Pcmpeqd_mm_mmm64:
			case Code.Pcmpgtb_mm_mmm64:
			case Code.Pcmpgtw_mm_mmm64:
			case Code.Pcmpgtd_mm_mmm64:
			// GENERATOR-END: NoVecIndex
				noVecIndex = true;
				break;
			// GENERATOR-BEGIN: SwapVecIndex12
			case Code.Movapd_xmmm128_xmm:
			case Code.VEX_Vmovapd_xmmm128_xmm:
			case Code.VEX_Vmovapd_ymmm256_ymm:
			case Code.EVEX_Vmovapd_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovapd_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovapd_zmmm512_k1z_zmm:
			case Code.Movaps_xmmm128_xmm:
			case Code.VEX_Vmovaps_xmmm128_xmm:
			case Code.VEX_Vmovaps_ymmm256_ymm:
			case Code.EVEX_Vmovaps_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovaps_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovaps_zmmm512_k1z_zmm:
			case Code.Movdqa_xmmm128_xmm:
			case Code.VEX_Vmovdqa_xmmm128_xmm:
			case Code.VEX_Vmovdqa_ymmm256_ymm:
			case Code.EVEX_Vmovdqa32_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqa32_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqa32_zmmm512_k1z_zmm:
			case Code.EVEX_Vmovdqa64_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqa64_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqa64_zmmm512_k1z_zmm:
			case Code.Movdqu_xmmm128_xmm:
			case Code.VEX_Vmovdqu_xmmm128_xmm:
			case Code.VEX_Vmovdqu_ymmm256_ymm:
			case Code.EVEX_Vmovdqu8_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqu8_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqu8_zmmm512_k1z_zmm:
			case Code.EVEX_Vmovdqu16_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqu16_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqu16_zmmm512_k1z_zmm:
			case Code.EVEX_Vmovdqu32_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqu32_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqu32_zmmm512_k1z_zmm:
			case Code.EVEX_Vmovdqu64_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovdqu64_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovdqu64_zmmm512_k1z_zmm:
			case Code.VEX_Vmovhpd_xmm_xmm_m64:
			case Code.EVEX_Vmovhpd_xmm_xmm_m64:
			case Code.VEX_Vmovhps_xmm_xmm_m64:
			case Code.EVEX_Vmovhps_xmm_xmm_m64:
			case Code.VEX_Vmovlpd_xmm_xmm_m64:
			case Code.EVEX_Vmovlpd_xmm_xmm_m64:
			case Code.VEX_Vmovlps_xmm_xmm_m64:
			case Code.EVEX_Vmovlps_xmm_xmm_m64:
			case Code.Movq_xmmm64_xmm:
			case Code.Movss_xmmm32_xmm:
			case Code.Movupd_xmmm128_xmm:
			case Code.VEX_Vmovupd_xmmm128_xmm:
			case Code.VEX_Vmovupd_ymmm256_ymm:
			case Code.EVEX_Vmovupd_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovupd_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovupd_zmmm512_k1z_zmm:
			case Code.Movups_xmmm128_xmm:
			case Code.VEX_Vmovups_xmmm128_xmm:
			case Code.VEX_Vmovups_ymmm256_ymm:
			case Code.EVEX_Vmovups_xmmm128_k1z_xmm:
			case Code.EVEX_Vmovups_ymmm256_k1z_ymm:
			case Code.EVEX_Vmovups_zmmm512_k1z_zmm:
			// GENERATOR-END: SwapVecIndex12
				swapVecIndex12 = true;
				break;
			}
			for (int i = 0; i < opCode.OpCount; i++) {
				switch (opCode.GetOpKind(i)) {
				case OpCodeOperandKind.r32_reg:
				case OpCodeOperandKind.r32_reg_mem:
				case OpCodeOperandKind.r32_rm:
				case OpCodeOperandKind.r32_opcode:
				case OpCodeOperandKind.r32_vvvv:
					r32_count++;
					break;

				case OpCodeOperandKind.r64_reg:
				case OpCodeOperandKind.r64_reg_mem:
				case OpCodeOperandKind.r64_rm:
				case OpCodeOperandKind.r64_opcode:
				case OpCodeOperandKind.r64_vvvv:
					r64_count++;
					break;

				case OpCodeOperandKind.bnd_or_mem_mpx:
				case OpCodeOperandKind.bnd_reg:
					bnd_count++;
					break;

				case OpCodeOperandKind.st0:
					if (i == 0) {
						switch (opCode.Code) {
						// GENERATOR-BEGIN: FpuStartOpIndex1
						// ⚠️This was generated by GENERATOR!🦹‍♂️
						case Code.Fcom_st0_sti:
						case Code.Fcom_st0_sti_DCD0:
						case Code.Fcomp_st0_sti:
						case Code.Fcomp_st0_sti_DCD8:
						case Code.Fcomp_st0_sti_DED0:
						case Code.Fld_st0_sti:
						case Code.Fucom_st0_sti:
						case Code.Fucomp_st0_sti:
						case Code.Fxch_st0_sti:
						case Code.Fxch_st0_sti_DDC8:
						case Code.Fxch_st0_sti_DFC8:
						// GENERATOR-END: FpuStartOpIndex1
							startOpIndex = 1;
							break;
						}
					}
					break;

				case OpCodeOperandKind.None:
				case OpCodeOperandKind.farbr2_2:
				case OpCodeOperandKind.farbr4_2:
				case OpCodeOperandKind.mem_offs:
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
				case OpCodeOperandKind.k_or_mem:
				case OpCodeOperandKind.r8_reg:
				case OpCodeOperandKind.r8_opcode:
				case OpCodeOperandKind.r16_reg:
				case OpCodeOperandKind.r16_reg_mem:
				case OpCodeOperandKind.r16_rm:
				case OpCodeOperandKind.r16_opcode:
				case OpCodeOperandKind.seg_reg:
				case OpCodeOperandKind.k_reg:
				case OpCodeOperandKind.kp1_reg:
				case OpCodeOperandKind.k_rm:
				case OpCodeOperandKind.k_vvvv:
				case OpCodeOperandKind.mm_reg:
				case OpCodeOperandKind.mm_rm:
				case OpCodeOperandKind.xmm_reg:
				case OpCodeOperandKind.xmm_rm:
				case OpCodeOperandKind.xmm_vvvv:
				case OpCodeOperandKind.xmmp3_vvvv:
				case OpCodeOperandKind.xmm_is4:
				case OpCodeOperandKind.xmm_is5:
				case OpCodeOperandKind.ymm_reg:
				case OpCodeOperandKind.ymm_rm:
				case OpCodeOperandKind.ymm_vvvv:
				case OpCodeOperandKind.ymm_is4:
				case OpCodeOperandKind.ymm_is5:
				case OpCodeOperandKind.zmm_reg:
				case OpCodeOperandKind.zmm_rm:
				case OpCodeOperandKind.zmm_vvvv:
				case OpCodeOperandKind.zmmp3_vvvv:
				case OpCodeOperandKind.cr_reg:
				case OpCodeOperandKind.dr_reg:
				case OpCodeOperandKind.tr_reg:
				case OpCodeOperandKind.es:
				case OpCodeOperandKind.cs:
				case OpCodeOperandKind.ss:
				case OpCodeOperandKind.ds:
				case OpCodeOperandKind.fs:
				case OpCodeOperandKind.gs:
				case OpCodeOperandKind.al:
				case OpCodeOperandKind.cl:
				case OpCodeOperandKind.ax:
				case OpCodeOperandKind.dx:
				case OpCodeOperandKind.eax:
				case OpCodeOperandKind.rax:
				case OpCodeOperandKind.sti_opcode:
				case OpCodeOperandKind.imm2_m2z:
				case OpCodeOperandKind.imm8:
				case OpCodeOperandKind.imm8_const_1:
				case OpCodeOperandKind.imm8sex16:
				case OpCodeOperandKind.imm8sex32:
				case OpCodeOperandKind.imm8sex64:
				case OpCodeOperandKind.imm16:
				case OpCodeOperandKind.imm32:
				case OpCodeOperandKind.imm32sex64:
				case OpCodeOperandKind.imm64:
				case OpCodeOperandKind.seg_rDI:
				case OpCodeOperandKind.br16_1:
				case OpCodeOperandKind.br32_1:
				case OpCodeOperandKind.br64_1:
				case OpCodeOperandKind.br16_2:
				case OpCodeOperandKind.br32_4:
				case OpCodeOperandKind.br64_4:
				case OpCodeOperandKind.xbegin_2:
				case OpCodeOperandKind.xbegin_4:
				case OpCodeOperandKind.brdisp_2:
				case OpCodeOperandKind.brdisp_4:
					break;

				case OpCodeOperandKind.seg_rSI:
				case OpCodeOperandKind.es_rDI:
				case OpCodeOperandKind.seg_rBX_al:
					// string instructions, xlat
					opCount = 0;
					break;

				default:
					throw new InvalidOperationException();
				}
			}
		}

		MemorySize GetMemorySize(bool isBroadcast) {
			int index = (int)opCode.Code;
			if (isBroadcast)
				index += IcedConstants.NumberOfCodeValues;
			return (MemorySize)InstructionMemorySizes.Sizes[index];
		}

		public string Format() {
			if (!opCode.IsInstruction) {
				return opCode.Code switch {
					Code.INVALID => "<invalid>",
					Code.DeclareByte => "<db>",
					Code.DeclareWord => "<dw>",
					Code.DeclareDword => "<dd>",
					Code.DeclareQword => "<dq>",
					_ => throw new InvalidOperationException(),
				};
			}

			sb.Length = 0;

			Write(GetMnemonic(), upper: true);
			if (startOpIndex < opCount) {
				sb.Append(' ');
				int saeErIndex = opCount - 1;
				if (opCode.Encoding != EncodingKind.Legacy && opCode.GetOpKind(saeErIndex) == OpCodeOperandKind.imm8)
					saeErIndex--;
				bool addComma = false;
				for (int i = startOpIndex; i < opCount; i++) {
					if (addComma)
						WriteOpSeparator();
					addComma = true;

					var opKind = opCode.GetOpKind(i);
					switch (opKind) {
					case OpCodeOperandKind.farbr2_2:
						sb.Append("ptr16:16");
						break;

					case OpCodeOperandKind.farbr4_2:
						sb.Append("ptr16:32");
						break;

					case OpCodeOperandKind.mem_offs:
						sb.Append("moffs");
						WriteMemorySize(GetMemorySize(isBroadcast: false));
						break;

					case OpCodeOperandKind.mem:
						WriteMemory();
						break;

					case OpCodeOperandKind.mem_mpx:
						WriteMemory();
						break;

					case OpCodeOperandKind.mem_mib:
						sb.Append("mib");
						break;

					case OpCodeOperandKind.mem_vsib32x:
						sb.Append("vm32x");
						break;

					case OpCodeOperandKind.mem_vsib64x:
						sb.Append("vm64x");
						break;

					case OpCodeOperandKind.mem_vsib32y:
						sb.Append("vm32y");
						break;

					case OpCodeOperandKind.mem_vsib64y:
						sb.Append("vm64y");
						break;

					case OpCodeOperandKind.mem_vsib32z:
						sb.Append("vm32z");
						break;

					case OpCodeOperandKind.mem_vsib64z:
						sb.Append("vm64z");
						break;

					case OpCodeOperandKind.r8_or_mem:
						WriteGprMem(8);
						break;

					case OpCodeOperandKind.r16_or_mem:
						WriteGprMem(16);
						break;

					case OpCodeOperandKind.r32_or_mem:
					case OpCodeOperandKind.r32_or_mem_mpx:
						WriteGprMem(32);
						break;

					case OpCodeOperandKind.r64_or_mem:
					case OpCodeOperandKind.r64_or_mem_mpx:
						WriteGprMem(64);
						break;

					case OpCodeOperandKind.mm_or_mem:
						WriteRegMem("mm", GetVecIndex());
						break;

					case OpCodeOperandKind.xmm_or_mem:
						WriteRegMem("xmm", GetVecIndex());
						break;

					case OpCodeOperandKind.ymm_or_mem:
						WriteRegMem("ymm", GetVecIndex());
						break;

					case OpCodeOperandKind.zmm_or_mem:
						WriteRegMem("zmm", GetVecIndex());
						break;

					case OpCodeOperandKind.bnd_or_mem_mpx:
						WriteRegOp("bnd", GetBndIndex());
						sb.Append('/');
						WriteMemory();
						break;

					case OpCodeOperandKind.k_or_mem:
						WriteRegMem("k", GetKIndex());
						break;

					case OpCodeOperandKind.r8_reg:
					case OpCodeOperandKind.r8_opcode:
						WriteRegOp("r8");
						break;

					case OpCodeOperandKind.r16_reg:
					case OpCodeOperandKind.r16_reg_mem:
					case OpCodeOperandKind.r16_rm:
					case OpCodeOperandKind.r16_opcode:
						WriteRegOp("r16");
						break;

					case OpCodeOperandKind.r32_reg:
					case OpCodeOperandKind.r32_reg_mem:
					case OpCodeOperandKind.r32_rm:
					case OpCodeOperandKind.r32_opcode:
					case OpCodeOperandKind.r32_vvvv:
						WriteRegOp("r32");
						AppendGprSuffix(r32_count, ref r32_index);
						break;

					case OpCodeOperandKind.r64_reg:
					case OpCodeOperandKind.r64_reg_mem:
					case OpCodeOperandKind.r64_rm:
					case OpCodeOperandKind.r64_opcode:
					case OpCodeOperandKind.r64_vvvv:
						WriteRegOp("r64");
						AppendGprSuffix(r64_count, ref r64_index);
						break;

					case OpCodeOperandKind.seg_reg:
						sb.Append("Sreg");
						break;

					case OpCodeOperandKind.k_reg:
					case OpCodeOperandKind.k_rm:
					case OpCodeOperandKind.k_vvvv:
						WriteRegOp("k", GetKIndex());
						break;

					case OpCodeOperandKind.kp1_reg:
						WriteRegOp("k", GetKIndex());
						sb.Append("+1");
						break;

					case OpCodeOperandKind.mm_reg:
					case OpCodeOperandKind.mm_rm:
						WriteRegOp("mm", GetVecIndex());
						break;

					case OpCodeOperandKind.xmm_reg:
					case OpCodeOperandKind.xmm_rm:
					case OpCodeOperandKind.xmm_vvvv:
					case OpCodeOperandKind.xmm_is4:
					case OpCodeOperandKind.xmm_is5:
						WriteRegOp("xmm", GetVecIndex());
						break;

					case OpCodeOperandKind.xmmp3_vvvv:
						WriteRegOp("xmm", GetVecIndex());
						sb.Append("+3");
						break;

					case OpCodeOperandKind.ymm_reg:
					case OpCodeOperandKind.ymm_rm:
					case OpCodeOperandKind.ymm_vvvv:
					case OpCodeOperandKind.ymm_is4:
					case OpCodeOperandKind.ymm_is5:
						WriteRegOp("ymm", GetVecIndex());
						break;

					case OpCodeOperandKind.zmm_reg:
					case OpCodeOperandKind.zmm_rm:
					case OpCodeOperandKind.zmm_vvvv:
						WriteRegOp("zmm", GetVecIndex());
						break;

					case OpCodeOperandKind.zmmp3_vvvv:
						WriteRegOp("zmm", GetVecIndex());
						sb.Append("+3");
						break;

					case OpCodeOperandKind.bnd_reg:
						WriteRegOp("bnd", GetBndIndex());
						break;

					case OpCodeOperandKind.cr_reg:
						WriteRegOp("cr");
						break;

					case OpCodeOperandKind.dr_reg:
						WriteRegOp("dr");
						break;

					case OpCodeOperandKind.tr_reg:
						WriteRegOp("tr");
						break;

					case OpCodeOperandKind.es:
						WriteRegister("es");
						break;

					case OpCodeOperandKind.cs:
						WriteRegister("cs");
						break;

					case OpCodeOperandKind.ss:
						WriteRegister("ss");
						break;

					case OpCodeOperandKind.ds:
						WriteRegister("ds");
						break;

					case OpCodeOperandKind.fs:
						WriteRegister("fs");
						break;

					case OpCodeOperandKind.gs:
						WriteRegister("gs");
						break;

					case OpCodeOperandKind.al:
						WriteRegister("al");
						break;

					case OpCodeOperandKind.cl:
						WriteRegister("cl");
						break;

					case OpCodeOperandKind.ax:
						WriteRegister("ax");
						break;

					case OpCodeOperandKind.dx:
						WriteRegister("dx");
						break;

					case OpCodeOperandKind.eax:
						WriteRegister("eax");
						break;

					case OpCodeOperandKind.rax:
						WriteRegister("rax");
						break;

					case OpCodeOperandKind.st0:
					case OpCodeOperandKind.sti_opcode:
						WriteRegister("ST");
						if (opKind == OpCodeOperandKind.st0) {
							switch (opCode.Code) {
							case Code.Fcomi_st0_sti:
							case Code.Fcomip_st0_sti:
							case Code.Fucomi_st0_sti:
							case Code.Fucomip_st0_sti:
								break;
							default:
								sb.Append("(0)");
								break;
							}
						}
						else {
							insist(opKind == OpCodeOperandKind.sti_opcode);
							sb.Append("(i)");
						}
						break;

					case OpCodeOperandKind.imm2_m2z:
						sb.Append("imm2");
						break;

					case OpCodeOperandKind.imm8:
					case OpCodeOperandKind.imm8sex16:
					case OpCodeOperandKind.imm8sex32:
					case OpCodeOperandKind.imm8sex64:
						sb.Append("imm8");
						break;

					case OpCodeOperandKind.imm8_const_1:
						sb.Append("1");
						break;

					case OpCodeOperandKind.imm16:
						sb.Append("imm16");
						break;

					case OpCodeOperandKind.imm32:
					case OpCodeOperandKind.imm32sex64:
						sb.Append("imm32");
						break;

					case OpCodeOperandKind.imm64:
						sb.Append("imm64");
						break;

					case OpCodeOperandKind.seg_rSI:
					case OpCodeOperandKind.es_rDI:
					case OpCodeOperandKind.seg_rDI:
					case OpCodeOperandKind.seg_rBX_al:
						addComma = false;
						break;

					case OpCodeOperandKind.br16_1:
					case OpCodeOperandKind.br32_1:
					case OpCodeOperandKind.br64_1:
						sb.Append("rel8");
						break;

					case OpCodeOperandKind.br16_2:
					case OpCodeOperandKind.xbegin_2:
						sb.Append("rel16");
						break;

					case OpCodeOperandKind.br32_4:
					case OpCodeOperandKind.br64_4:
					case OpCodeOperandKind.xbegin_4:
						sb.Append("rel32");
						break;

					case OpCodeOperandKind.brdisp_2:
						sb.Append("disp16");
						break;

					case OpCodeOperandKind.brdisp_4:
						sb.Append("disp32");
						break;

					case OpCodeOperandKind.None:
					default:
						throw new InvalidOperationException();
					}

					if (i == 0) {
						if (opCode.CanUseOpMaskRegister) {
							sb.Append(' ');
							WriteRegDecorator("k", GetKIndex());
							if (opCode.CanUseZeroingMasking)
								WriteDecorator("z");
						}
					}
					if (i == saeErIndex) {
						if (opCode.CanSuppressAllExceptions)
							WriteDecorator("sae");
						if (opCode.CanUseRoundingControl) {
							if (opCode.Code != Code.EVEX_Vcvtusi2sd_xmm_xmm_rm32_er && opCode.Code != Code.EVEX_Vcvtsi2sd_xmm_xmm_rm32_er)
								WriteDecorator("er");
						}
					}
				}
			}

			switch (opCode.Code) {
			case Code.Blendvpd_xmm_xmmm128:
			case Code.Blendvps_xmm_xmmm128:
			case Code.Pblendvb_xmm_xmmm128:
			case Code.Sha256rnds2_xmm_xmmm128:
				WriteOpSeparator();
				Write("<XMM0>", upper: true);
				break;

			case Code.Tpause_r32:
			case Code.Tpause_r64:
			case Code.Umwait_r32:
			case Code.Umwait_r64:
				WriteOpSeparator();
				Write("<edx>", upper: false);
				WriteOpSeparator();
				Write("<eax>", upper: false);
				break;
			}

			return sb.ToString();
		}

		void WriteMemorySize(MemorySize memorySize) {
			switch (opCode.Code) {
			case Code.Fldcw_m2byte:
			case Code.Fnstcw_m2byte:
			case Code.Fstcw_m2byte:
			case Code.Fnstsw_m2byte:
			case Code.Fstsw_m2byte:
				sb.Append("2byte");
				return;
			}

			switch (memorySize) {
			case MemorySize.Bound16_WordWord:
				sb.Append("16&16");
				break;

			case MemorySize.Bound32_DwordDword:
				sb.Append("32&32");
				break;

			case MemorySize.FpuEnv14:
				sb.Append("14byte");
				break;

			case MemorySize.FpuEnv28:
				sb.Append("28byte");
				break;

			case MemorySize.FpuState94:
				sb.Append("94byte");
				break;

			case MemorySize.FpuState108:
				sb.Append("108byte");
				break;

			case MemorySize.Fxsave_512Byte:
			case MemorySize.Fxsave64_512Byte:
				sb.Append("512byte");
				break;

			case MemorySize.Xsave:
			case MemorySize.Xsave64:
				// 'm' has already been appended
				sb.Append("em");
				break;

			case MemorySize.SegPtr16:
				sb.Append("16:16");
				break;

			case MemorySize.SegPtr32:
				sb.Append("16:32");
				break;

			case MemorySize.SegPtr64:
				sb.Append("16:64");
				break;

			case MemorySize.Fword6:
				if (!IsSgdtOrSidt())
					sb.Append("16&32");
				break;

			case MemorySize.Fword10:
				if (!IsSgdtOrSidt())
					sb.Append("16&64");
				break;

			default:
				int memSize = memorySize.GetSize();
				if (memSize != 0)
					sb.Append(memSize * 8);
				break;
			}

			if (IsFpuInstruction(opCode.Code)) {
				switch (memorySize) {
				case MemorySize.Int16:
				case MemorySize.Int32:
				case MemorySize.Int64:
					sb.Append("int");
					break;

				case MemorySize.Float32:
				case MemorySize.Float64:
				case MemorySize.Float80:
					sb.Append("fp");
					break;

				case MemorySize.Bcd:
					sb.Append("bcd");
					break;
				}
			}
		}

		bool IsSgdtOrSidt() {
			switch (opCode.Code) {
			case Code.Sgdt_m1632_16:
			case Code.Sgdt_m1632:
			case Code.Sgdt_m1664:
			case Code.Sidt_m1632_16:
			case Code.Sidt_m1632:
			case Code.Sidt_m1664:
				return true;
			}
			return false;
		}

		void WriteRegister(string register) => Write(register, upper: true);
		void WriteRegOp(string register) => Write(register, upper: false);
		void WriteRegOp(string register, int index) {
			WriteRegOp(register);
			if (index > 0)
				sb.Append(index);
		}
		void WriteDecorator(string decorator) {
			sb.Append('{');
			Write(decorator, upper: false);
			sb.Append('}');
		}
		void WriteRegDecorator(string register, int index) {
			sb.Append('{');
			Write(register, upper: false);
			sb.Append(index);
			sb.Append('}');
		}

		void AppendGprSuffix(int count, ref int index) {
			if (count <= 1)
				return;
			sb.Append((char)('a' + index));
			index++;
		}

		void WriteOpSeparator() => sb.Append(", ");

		void Write(string s, bool upper) {
			for (int i = 0; i < s.Length; i++) {
				var c = s[i];
				c = upper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c);
				sb.Append(c);
			}
		}

		void WriteGprMem(int regSize) {
			insist(!opCode.CanBroadcast);
			sb.Append('r');
			int memSize = GetMemorySize(isBroadcast: false).GetSize() * 8;
			if (memSize != regSize)
				sb.Append(regSize);
			sb.Append('/');
			WriteMemory();
		}

		void WriteRegMem(string register, int index) {
			WriteRegOp(register, index);
			sb.Append('/');
			WriteMemory();
		}

		void WriteMemory() {
			WriteMemory(isBroadcast: false);
			if (opCode.CanBroadcast) {
				sb.Append('/');
				WriteMemory(isBroadcast: true);
			}
		}

		void WriteMemory(bool isBroadcast) {
			var memorySize = GetMemorySize(isBroadcast);
			sb.Append('m');
			WriteMemorySize(memorySize);
			if (isBroadcast)
				sb.Append("bcst");
		}

		string GetMnemonic() {
			var code = opCode.Code;
			var mnemonic = code.Mnemonic();
			switch (code) {
			case Code.Retfw:
			case Code.Retfw_imm16:
			case Code.Retfd:
			case Code.Retfd_imm16:
			case Code.Retfq:
			case Code.Retfq_imm16:
				mnemonic = Mnemonic.Ret;
				goto default;

			case Code.Iretd:
			case Code.Iretq:
			case Code.Pushad:
			case Code.Popad:
			case Code.Pushfd:
			case Code.Pushfq:
			case Code.Popfd:
			case Code.Popfq:
			case Code.Int3:
				return code.ToString();

			default:
				return mnemonic.ToString();
			}
		}

		static bool IsFpuInstruction(Code code) =>
			(uint)(code - Code.Fadd_m32fp) <= (uint)(Code.Fcomip_st0_sti - Code.Fadd_m32fp);
	}
}