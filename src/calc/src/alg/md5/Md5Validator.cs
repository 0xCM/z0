//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Alg
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    public sealed class Md5Validator : Validator<Md5Validator>
    {
        public override void Run()
        {
            var input = Md5Ref.InputData;
            var buffer = input.ToArray();
            var output = Md5Ref.calc(buffer);
            var expect = Md5Ref.OutputHash;
            var length = output.Length;
            if(length != 16)
            {
                Error(string.Format("{0} != {1}", length, 16));
                return;
            }

            for(var i=0; i<16; i++)
            {
                ref readonly var a = ref skip(expect,i);
                ref readonly var b = ref skip(output,i);
                if(a != b)
                {
                    Error(string.Format("output[{0}] != expect[{0}]", i));
                    break;
                }
            }
        }
    }
}