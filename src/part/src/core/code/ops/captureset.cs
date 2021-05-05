//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static ApiCaptureSet captureset(OpUri id, MsilSourceBlock msil,  CodeBlock hex, AsmSourceBlock asm, MethodDisplaySig sig)
            => new ApiCaptureSet(id, msil, hex, asm,sig);

        [MethodImpl(Inline), Op]
        public static ApiCaptureSet captureSet(in ApiCaptureBlock src, in AsmSourceBlock asm)
            => new ApiCaptureSet(src.OpUri, msil(src.Msil), src.CodeBlock, asm, src.Method.DisplaySig());

        [Op]
        public static ApiCaptureSet captureset(OpIdentity id, MethodInfo method,  CodeBlock hex, AsmSourceBlock asm)
        {
            var uri = ApiUri.hex(method.DeclaringType.HostUri(), method.Name, id);
            return new ApiCaptureSet(uri,
                msil(ClrDynamic.msil(hex.BaseAddress, uri, method)),
                hex,
                asm, method.DisplaySig());
        }
    }
}