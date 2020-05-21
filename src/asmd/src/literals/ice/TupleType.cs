//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
	public enum TupleType 
    {
		[Comment("#(c:N = 1)#")]
		None,
		
		[Comment("#(c:N = b ? (W ? 8 : 4) : 16)#")]
		Full_128,
		
		[Comment("#(c:N = b ? (W ? 8 : 4) : 32)#")]
		Full_256,
		
		[Comment("#(c:N = b ? (W ? 8 : 4) : 64)#")]
		Full_512,
		
		[Comment("#(c:N = b ? 4 : 8)#")]
		Half_128,
		
		[Comment("#(c:N = b ? 4 : 16)#")]
		Half_256,
		
		[Comment("#(c:N = b ? 4 : 32)#")]
		Half_512,
		
		[Comment("#(c:N = 16)#")]
		Full_Mem_128,
		
		[Comment("#(c:N = 32)#")]
		Full_Mem_256,
		
		[Comment("#(c:N = 64)#")]
		Full_Mem_512,
		[Comment("#(c:N = W ? 8 : 4)#")]
		Tuple1_Scalar,
		[Comment("#(c:N = 1)#")]
		Tuple1_Scalar_1,
		[Comment("#(c:N = 2)#")]
		Tuple1_Scalar_2,
		[Comment("#(c:N = 4)#")]
		Tuple1_Scalar_4,
		[Comment("#(c:N = 8)#")]
		Tuple1_Scalar_8,
		[Comment("#(c:N = 4)#")]
		Tuple1_Fixed_4,
		[Comment("#(c:N = 8)#")]
		Tuple1_Fixed_8,
		[Comment("#(c:N = W ? 16 : 8)#")]
		Tuple2,
		[Comment("#(c:N = W ? 32 : 16)#")]
		Tuple4,
		[Comment("#(c:N = W ? error : 32)#")]
		Tuple8,
		[Comment("#(c:N = 16)#")]
		Tuple1_4X,
		[Comment("#(c:N = 8)#")]
		Half_Mem_128,
		[Comment("#(c:N = 16)#")]
		Half_Mem_256,
		[Comment("#(c:N = 32)#")]
		Half_Mem_512,
		[Comment("#(c:N = 4)#")]
		Quarter_Mem_128,
		[Comment("#(c:N = 8)#")]
		Quarter_Mem_256,
		[Comment("#(c:N = 16)#")]
		Quarter_Mem_512,
		[Comment("#(c:N = 2)#")]
		Eighth_Mem_128,
		[Comment("#(c:N = 4)#")]
		Eighth_Mem_256,
		[Comment("#(c:N = 8)#")]
		Eighth_Mem_512,
		[Comment("#(c:N = 16)#")]
		Mem128,
		[Comment("#(c:N = 8)#")]
		MOVDDUP_128,
		[Comment("#(c:N = 32)#")]
		MOVDDUP_256,
		[Comment("#(c:N = 64)#")]
		MOVDDUP_512,
	}
}