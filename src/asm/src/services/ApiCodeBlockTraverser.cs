//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    [ApiHost]
    public class ApiCodeBlockTraverser : AsmWfService<ApiCodeBlockTraverser>
    {
        [Op]
        public void Traverse(ApiBlockIndex src, IReceiver<ApiCodeBlock,AsmInstructionBlock> dst)
        {
            var addresses = src.Addresses.View;
            var count = addresses.Length;
            for(var i=0u; i<count; i++)
                Traverse(src[skip(addresses,i)], dst);
        }

        [Op]
        void Traverse(in ApiCodeBlock src, IReceiver<ApiCodeBlock,AsmInstructionBlock> dst)
        {
            var decoded = Asm.RoutineDecoder.Decode(src);
            if(decoded)
            {
                dst.Deposit(src,decoded.Value);
            }
        }
    }
}