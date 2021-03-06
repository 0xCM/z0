//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct CodeBlocks
    {
        [Op]
        public static ApiCaptureBlock capture(OpIdentity id, MethodInfo method, CodeBlock raw, CodeBlock parsed, ExtractTermCode term)
        {
            var dst = new ApiCaptureBlock();
            dst.Raw = raw;
            dst.Parsed = parsed;
            dst.Method = method;
            Require.invariant(raw.BaseAddress == parsed.BaseAddress, () => CaptureAddressMismatch);
            dst.OpUri = ApiUri.hex(method.DeclaringType.ApiHostUri(), method.Name, id);
            dst.TermCode = term;
            dst.Msil = ClrDynamic.msil(parsed.BaseAddress, dst.OpUri, method);
            dst.CliSig = Clr.sig(method);
            return dst;
        }
    }
}