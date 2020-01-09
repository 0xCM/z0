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

    using static zfunc;

    public class CilFunction
    {
        public static CilFunction Define(MethodInfo method)
        {
            var body = method.GetMethodBody();
            var flags = method.GetMethodImplementationFlags();
            var token = method.GetMetadataToken();
            var sig = method.Signature();



            return new CilFunction
            {
                MethodId = method.GetMetadataToken(),
                Sig = method.Signature(),
                LocalVariables = body.LocalVariables,
                InitLocals = body.InitLocals,
                MaxStackSize = body.MaxStackSize,
                LocalSigId = body.LocalSignatureMetadataToken,
                Data = body.GetILAsByteArray(),
                ImplSpec = method.GetMethodImplementationFlags()                
            };
        }

        public int MethodId {get; private set;}

        public int LocalSigId {get; private set;}
        
        public MethodSig Sig {get; private set;}

        public IList<LocalVariableInfo> LocalVariables {get; private set;}

        public byte[] Data {get; private set;}

        public int MaxStackSize {get; private set;}

        public bool InitLocals {get; private set;}

        public MethodImplAttributes ImplSpec {get; private set;}
    
    }

}