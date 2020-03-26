//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

    public class ValidationHostConfig : AppSettingSet<ValidationHostConfig>
    {
        // public static ValidationHostConfig From(IAppSettings src)
        //     => IAppSettingSet<ValidationHostConfig>.From(src);

        public IAppSettingSet Ops => this;        

        public bool EmitArtifacts {get; set;} = true;

        public bool CheckExecution {get; set;} = true;

        public bool HandleMembersLocated {get; set;} = true;

        public bool HandleExtractsParsed {get; set;} = true;

        public bool HandleFunctionsDecoded {get; set;} = false;

        public bool HandleParsedExtractSaved {get; set;} = true;

        public bool HandleHostReportSaved {get; set;} = false;

        public bool HandleExtractReportCreated {get; set;} = false;

        public bool HandleParseReportCreated {get; set;} = false;        

        public override string ToString()
            => Ops.Format();
    }
}