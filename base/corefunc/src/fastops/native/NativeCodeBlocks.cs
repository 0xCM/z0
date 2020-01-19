//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
	
	public sealed class NativeCodeBlocks 
    {
		public NativeCodeBlocks(int MethodId, NativeCodeBlock[] Blocks)
		{
			this.MethodId = MethodId;
			this.NativeCode = Blocks;
		}
				
    	public int MethodId;
				

    	public NativeCodeBlock[] NativeCode {get;}
	
	}
}