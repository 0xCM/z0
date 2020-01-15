//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
	using System.Runtime.CompilerServices;

	using static zfunc;

	/// <summary>
	/// Represents a native code block
	/// </summary>
	public readonly struct NativeCodeBlock 
    {
		public static NativeCodeBlock Empty => new NativeCodeBlock(0, new byte[]{0});

		/// <summary>
		/// The location of the leading segment
		/// </summary>
		public readonly ulong Address;
	
		/// <summary>
		/// The block data
		/// </summary>
    	public readonly byte[] Data;

    	public NativeCodeBlock(ulong address, byte[] data) 
        {
			Address = address;
			Data = data;
		}	

		public bool IsEmpty
		{
			[MethodImpl(Inline)]
			get => Address == 0 && Data.Length == 1 && Data[0] == 0;
		}
		
		public override string ToString() 
			=> $"{Address.FormatHex()}: {Data.FormatHex(true, false, false, true)}";
	}
}