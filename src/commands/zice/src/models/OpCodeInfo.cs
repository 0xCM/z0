//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;
    using System.Collections.Generic;

	public abstract class OpCodeInfo 
    {
		public static byte[] GetModes(OpCodeInfo opCode) 
		{
			var dst = new List<byte>();
			if ((opCode.Flags & OpCodeFlags.Mode16) != 0)
				dst.Add(16);
			if ((opCode.Flags & OpCodeFlags.Mode32) != 0) 
				dst.Add(32);
			if ((opCode.Flags & OpCodeFlags.Mode64) != 0) 
				dst.Add(64);

			if (dst.Count == 0)
				throw new InvalidOperationException();
			return dst.ToArray();
		}

		public abstract EncodingKind Encoding { get; }
		public IceEnumValue Code { get; protected set; }
		
        public MandatoryPrefix MandatoryPrefix { get; protected set; }
		
        public OpCodeTableKind Table { get; protected set; }
		
        public uint OpCode { get; protected set; }
		
        public int GroupIndex { get; protected set; }
		
        public OpCodeFlags Flags { get; protected set; }

		public abstract int OpKindsLength { get; }

		public abstract OpCodeOperandKind OpKind(int arg); 

		public override string ToString() => $"{this.GetType().Name}: {Code.RawName}";
	}
}