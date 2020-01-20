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
		/// <summary>
		/// Descriptive text
		/// </summary>
		public readonly string Label;

		/// <summary>
		/// The source location
		/// </summary>
		public readonly AddressSegment Location;
	
		/// <summary>
		/// The block data
		/// </summary>
    	public readonly byte[] Data;

		public static NativeCodeBlock Empty => new NativeCodeBlock(string.Empty, 0, new byte[]{0});

		public static NativeCodeBlock Define(string label, ulong address, byte[] data)
			=> new NativeCodeBlock(label, address, data);

		public static NativeCodeBlock Define(INativeMemberData src)
			=> new NativeCodeBlock(src);

    	NativeCodeBlock(INativeMemberData src) 
        {
			Label = src.Label;
			Location = src.Location;
			Data = src.Code.Encoded;
		}	

    	NativeCodeBlock(string label, ulong address, byte[] data) 
        {
			Label = label;
			Location = AddressSegment.Define(address, address + (ulong)data.Length);
			Data = data;
		}	

		public bool IsEmpty
		{
			[MethodImpl(Inline)]
			get => Location.IsEmpty && Data.Length == 1 && Data[0] == 0;
		}				
	}
}