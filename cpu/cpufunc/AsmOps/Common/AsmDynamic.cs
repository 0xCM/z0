
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    using static zfunc;

    #if Experiment
    public static class AsmDynamic
    {
        public static AsmDynamic32 Create(ReadOnlySpan<byte> code, N32 n)
            => AsmDynamic32.Create(code);

        public static AsmDynamic64 Create(ReadOnlySpan<byte> code, N64 n)
            => AsmDynamic64.Create(code);

    }

   /// <summary>
    /// Encapsulates excecutable assembly blocks that are no more than 64 bytes in length
    /// </summary>
    public unsafe ref struct AsmDynamic32
    {        
        public const int BufferLength = 32;

        public static AsmDynamic32 Create(ReadOnlySpan<byte> code)
        {
            if(code.Length > BufferLength)
                throw Errors.TooManyBytes(code.Length, BufferLength);
            return new AsmDynamic32(code);
        }

        fixed byte code[BufferLength];

        byte* pCode;

        AsmDynamic32(ReadOnlySpan<byte> src)
        {            
            for(var i=0; i<src.Length; i++)
                this.code[i] =  src[i];
            
            fixed(byte* p = code)
            {                
                pCode = OS.Liberate(p, BufferLength);
            }
        }
            
        public AsmBinOp<T> BinOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateBinOp<T>(pCode);
    }

    public unsafe ref struct AsmDynamic64
    {        
        public const int BufferLength = 64;        

        public static AsmDynamic64 Create(ReadOnlySpan<byte> code)
        {
            if(code.Length > BufferLength)
                throw Errors.TooManyBytes(code.Length, BufferLength);
            return new AsmDynamic64(code);
        }

        fixed byte code[BufferLength];

        byte* pCode;

        AsmDynamic64(ReadOnlySpan<byte> src)
        {            
            for(var i=0; i<src.Length; i++)
                this.code[i] =  src[i];
            
            fixed(byte* p = code)
            {                
                pCode = OS.Liberate(p, BufferLength);
            }
        }
            
        public AsmBinOp<T> BinOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateBinOp<T>(pCode);
    }

    #endif
}