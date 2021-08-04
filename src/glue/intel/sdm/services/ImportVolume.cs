//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class IntelSdm
    {
        public Outcome ImportVolume(byte vol)
        {
            var src = SdmSrcPath(vol);
            var dst = SdmImportPath(vol);
            var encoding = pair(TextEncodingKind.Unicode, TextEncodingKind.Unicode);
            var result = DocServices.CreateLinedDoc(src, dst, encoding);
            if(!result)
                return false;

            var verified = DocServices.VerifyLinedDoc(dst, encoding.Right);
            if(verified.Fail)
                Wf.Error(verified.Message);

            return verified;
        }

        // public Outcome EmitLinedSdm()
        // {
        //     var encoding = pair(TextEncodingKind.Unicode,TextEncodingKind.Unicode);
        //     var src = SdmSrcPath();
        //     var dst = SdmImportPath();
        //     var result = DocServices.CreateLinedDoc(src, dst, encoding);
        //     if(!result)
        //         return false;

        //     var verified = DocServices.VerifyLinedDoc(dst, encoding.Right);
        //     if(verified.Fail)
        //         Wf.Error(verified.Message);

        //     return verified;
        // }
    }
}