//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;
    using System.Collections.Generic;
    using System.IO;
	
	public sealed class DecoderMemoryTestCase 
    {
		public int LineNumber;
		
		public DecoderOptions DecoderOptions;
		
		public int Bitness;
		
		public string HexBytes;
		
		public string EncodedHexBytes;
		public Code Code;
		
		public Register Register;
		
		public Register SegmentPrefix;
		
		public Register SegmentRegister;
		
		public Register BaseRegister;
		
		public Register IndexRegister;
		
		public int Scale;
		
		public uint Displacement;
		
		public int DisplacementSize;
		
		public bool CanEncode;		
		public ConstantOffsets ConstantOffsets;
	}
}