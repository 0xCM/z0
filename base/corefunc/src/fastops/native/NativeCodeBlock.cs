// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
// 	using System.Runtime.CompilerServices;

// 	using static zfunc;

// 	/// <summary>
// 	/// Represents a native code block
// 	/// </summary>
// 	public readonly struct NativeCodeBlock 
//     {
// 		public readonly Moniker Id;
// 		/// <summary>
// 		/// Descriptive text
// 		/// </summary>
// 		public readonly string Label;

// 		/// <summary>
// 		/// The source location
// 		/// </summary>
// 		public readonly MemoryRange Origin;
	
// 		/// <summary>
// 		/// The block data
// 		/// </summary>
//     	public readonly byte[] Encoded;

// 		public static NativeCodeBlock Empty => new NativeCodeBlock(Moniker.Empty, string.Empty, 0, new byte[]{0});

// 		public static NativeCodeBlock Define(Moniker id, string label, ulong address, byte[] data)
// 			=> new NativeCodeBlock(id, label, address, data);


//     	NativeCodeBlock(Moniker id, string label, ulong address, byte[] data) 
//         {
// 			Id = id;
// 			Label = label;
// 			Origin = MemoryRange.Define(address, address + (ulong)data.Length);
// 			Encoded = data;
// 		}	

// 		public bool IsEmpty
// 		{
// 			[MethodImpl(Inline)]
// 			get => Origin.IsEmpty && Encoded.Length == 1 && Encoded[0] == 0;
// 		}				
// 	}
// }