//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial class AsmCmdService
    {
        [CmdOp(".test-stack")]
        Outcome TestStack(CmdArgs args)
        {
            var result = Outcome.Success;
            var stack = CpuModels.stack<ulong>(24);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while(stack.Pop(out var cell))
            {
                Write(cell);
            }
            return result;
        }

        public class ArrayInfo
        {
            public ulong Count;

            public uint M;

            public uint N;
        }

        [CmdOp(".test-arrays")]
        unsafe Outcome TestArrays(CmdArgs args)
        {
            var m = 0xF;
            var n = 0xA;
            var src = new ulong[m,n];
            for(var i=0; i<m; i++)
            for(var j=0; j<n; j++)
                src[i,j] = (ulong)(i*j);

            var rowsize = sizeof(ulong)*n;


            fixed(ulong* pSrc = src)
            {
                MemoryAddress @base = pSrc;
                var pCurrent = pSrc;
                for(var i=0; i<m; i++)
                {
                    for(var j=0; j<n; j++)
                    {
                        MemoryAddress loc = pCurrent;
                        var value = *pCurrent++;
                        Require.equal(value, (ulong)(i*j));
                        Write(string.Format("{0} {1} {2}x{3}={4}",loc, loc - @base, i, j, value));
                    }
                }
            }

            var dst = Unsafe.As<ArrayInfo>(src);
            Write(string.Format("{0}={1}x{2}", dst.Count, dst.M, dst.N));

            return true;
        }
    }
}