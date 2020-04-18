//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]    
    struct DefVmlErrorContext
    {
        public int iCode;
        
        public int iIndex;
        
        public double dbA1;
        
        public double dbA2;
        
        public double dbR1;
        
        public double dbR2;
        
        //public Char64 cFuncName;
        
        public int iFuncNameLen;
        
        public double dbA1Im;
        
        public double dbA2Im;
        
        public double dbR1Im;
        
        public double dbR2Im;
    } 
}