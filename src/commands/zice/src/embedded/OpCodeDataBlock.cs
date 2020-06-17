//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
	using System.Runtime.Intrinsics;
	using System.Text;

	using static Konst;
	using static Memories;

	using DataFlags = OpCodeDataFlags;

	public struct OpCodeDataBlock
	{
		/// <summary>
		/// Captures the block data source
		/// </summary>
		Vector128<uint> DataSource;

		public uint DWord3 => DataSource.GetElement(2);

		public uint DWord2 => DataSource.GetElement(1);

		public uint DWord1 => DataSource.GetElement(0);

		public DataFlags Flags;
		
		public Code CodeId;
		
		public ushort OpCode;
		
		public EncodingKind Encoding;
				
		public byte operandSize;
		
		public byte addressSize;
		
		public byte l;
		
		public byte tupleType;
		
		public byte table;
		
		public byte mandatoryPrefix;
		
		public sbyte groupIndex;
		
		public byte op0Kind;
		
		public byte op1Kind;
		
		public byte op2Kind;
		
		public byte op3Kind;
		
		public byte op4Kind;
		
		public LKind lkind;

		OpCodeDataBlock(Code code)
		{
			insist((uint)code < (uint)IcedConstants.NumberOfCodeValues);
			insist((uint)code <= ushort.MaxValue);
			Flags = 0;
			CodeId = code;
			DataSource = default;
			OpCode = default;
			Encoding = default;
			this.operandSize = 0;
			this.addressSize = 0;
			this.l = 0;
			this.tupleType = 0;
			this.table = 0;
			this.mandatoryPrefix = 0;
			this.groupIndex = 0;
			this.op0Kind = 0;
			this.op1Kind = 0;
			this.op2Kind = 0;
			this.op3Kind = 0;
			this.op4Kind = 0;
			this.lkind = 0;			
		}

		OpCodeDataBlock(Code code, uint dword3, uint dword2, uint dword1)
			: this(code)
		{
			DataSource = Vector128.Create(dword1, dword2,dword3, 0u);
			Flags = (code <= Code.DeclareQword) ? DataFlags.NoInstruction : DataFlags.None;
			OpCode = (ushort)(dword1 >> (int)EncFlags1.OpCodeShift);
			Encoding = (EncodingKind)((dword1 >> (int)EncFlags1.EncodingShift) & (uint)EncFlags1.EncodingMask);	
		}
        public OpCodeDataBlock(Code code, uint dword3, uint dword2, uint dword1, StringBuilder sb) 
			: this(code, dword3, dword2, dword1)
        {			
			
		}

		public OpCodeDataAdapter Adapter 
			=> this;
	}    
}