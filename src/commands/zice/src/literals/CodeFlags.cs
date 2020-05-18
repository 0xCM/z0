//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	/// <summary>
	/// Memory operand size.
	/// </summary>
	public enum MemoryOperandSize 
	{
		/// <summary>
		/// An unspecified memory operand.
		/// </summary>
		None,
		/// <summary>
		/// A 8-bit / byte pointer.
		/// </summary>
		BytePtr,
		/// <summary>
		/// A 16-bit / word pointer.
		/// </summary>
		WordPtr,
		/// <summary>
		/// A 32-bit / double-word pointer.
		/// </summary>
		DwordPtr,
		/// <summary>
		/// A 64-bit / quad word pointer.
		/// </summary>
		QwordPtr,
		/// <summary>
		/// A 80-bit / tword pointer.
		/// </summary>
		TwordPtr,
		/// <summary>
		/// A 16-bit segment + 32-bit address.
		/// </summary>
		FwordPtr,
		/// <summary>
		/// A 128-bit / xmm pointer.
		/// </summary>
		OwordPtr,
		/// <summary>
		/// A 256-bit / ymm pointer.
		/// </summary>
		YwordPtr,
		/// <summary>
		/// A 512-bit / zmm pointer.
		/// </summary>
		ZwordPtr,
	}
}