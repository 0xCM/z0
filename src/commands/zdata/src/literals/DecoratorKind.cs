//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum DecoratorKind 
	{
		[Comment("Broadcast decorator, eg. #(c:{1to4})#")]
		Broadcast,
	
		[Comment("Rounding control, eg. #(c:{rd-sae})#")]
		RoundingControl,
	
		[Comment("Suppress all exceptions: #(c:{sae})#")]
		SuppressAllExceptions,
	
		[Comment("Zeroing masking: #(c:{z})#")]
		ZeroingMasking,
	}

}