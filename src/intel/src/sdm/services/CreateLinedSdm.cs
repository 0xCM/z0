//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class IntelSdmProcessor
    {
        public bool CreateLinedSdm()
        {
            var src = SdmRefPath();
            var dst = LinedSdmPath();
            var result = DocServices.CreateLinedDoc(src, dst);
            if(!result)
                return false;

            var verified = DocServices.VerifyLinedDoc(dst);
            if(verified.Fail)
                Wf.Error(verified.Message);

            return verified;
        }
    }
}