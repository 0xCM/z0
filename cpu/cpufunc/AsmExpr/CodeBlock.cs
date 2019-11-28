//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
	using System.Linq;

	/// <summary>
	/// Represents a native code block
	/// </summary>
	public readonly struct CodeBlock 
    {
    	public CodeBlock(ulong address, byte[] data) 
        {
			Address = address;
			Data = data;
		}

		/// <summary>
		/// The location of the block head
		/// </summary>
		public readonly ulong Address;
	
		/// <summary>
		/// The block data
		/// </summary>
    	public readonly byte[] Data;
	
        string FormatData()
            => Data.FormatHex(true, false, false, true);//.Select(x => x.ToString()).Concat(" ");

		public override string ToString() 
			=> $"{Address.FormatHex()}: {FormatData()}";
	}
}