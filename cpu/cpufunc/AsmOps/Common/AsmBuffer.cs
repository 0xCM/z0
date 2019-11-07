
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    using static zfunc;

    
    public readonly ref struct AsmBuffer
    {
        public static AsmBuffer Create(params byte[] code)
            => new AsmBuffer(code);
            
        public static AsmBuffer Create(ReadOnlySpan<byte> code)
            => new AsmBuffer(code);

        readonly MemoryBuffer code;

        readonly string name;

        readonly long pCode;

        public AsmBuffer(ReadOnlySpan<byte> code, string name  = null)
        {
            this.code = MemoryBuffer.Alloc(code);
            this.name = name ?? "anon";
            this.pCode = (long)OS.Liberate(this.code);
        }

        public void Dispose()
        {
            code.Dispose();
        }

        public AsmBinOp<T> BinOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateBinOp<T>(pCode, name);
    }

}