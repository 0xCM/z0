//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static SdmModels;

    partial class IntelSdmProcessor
    {
        public Outcome EmitLinedSdm(byte vol)
        {
            var src = SdmUnicodePath(vol);
            var dst = LinedSdmPath(vol);
            var encoding = pair(TextEncodingKind.Unicode,TextEncodingKind.Unicode);
            var result = DocServices.CreateLinedDoc(src, dst, encoding);
            if(!result)
                return false;

            var verified = DocServices.VerifyLinedDoc(dst, encoding.Right);
            if(verified.Fail)
                Wf.Error(verified.Message);

            return verified;
        }

        public Outcome EmitLinedSdm()
        {
            var encoding = pair(TextEncodingKind.Unicode,TextEncodingKind.Unicode);
            var src = SdmUnicodePath();
            var dst = LinedSdmPath();
            var result = DocServices.CreateLinedDoc(src, dst, encoding);
            if(!result)
                return false;

            var verified = DocServices.VerifyLinedDoc(dst, encoding.Right);
            if(verified.Fail)
                Wf.Error(verified.Message);

            return verified;
        }
    }
}