//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public class CilFunction
    {
        public static CilFunction From(MethodInfo method)
        {
            return new CilFunction
            {
                Name = method.Name,
                Data = method.CilBody(),
                ImplSpec = method.GetMethodImplementationFlags()
            };
        }

        public static CilFunction From(DynamicMethod method)
        {
            return new CilFunction
            {
                Name = method.Name,
                Data = method.CilBody(),
                ImplSpec = method.GetMethodImplementationFlags()
            };
        }

        public string Name {get; private set;}        

        public byte[] Data {get; private set;}

        public MethodImplAttributes ImplSpec {get; private set;}
    
    }

}