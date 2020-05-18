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

	public sealed class MemorySizeInfo 
	{
		public MemorySize MemorySize {get;}
		
        public int Size {get;}
		
        public int ElementSize {get;}
		
        public MemorySize ElementType {get;}
		
        public bool IsSigned {get;}
		
        public bool IsBroadcast {get;}

		public MemorySizeInfo(MemorySize memorySize, int size, int elementSize, MemorySize elementType, bool isSigned, bool isBroadcast) 
        {
			MemorySize = memorySize;
			Size = size;
			ElementSize = elementSize;
			ElementType = elementType;
			IsSigned = isSigned;
			IsBroadcast = isBroadcast;
		}
	}
}