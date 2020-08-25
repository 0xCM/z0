//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class CaptureConfig : SettingValues<CaptureConfig>
    {
        public ISettingSource Ops => this;

        public bool EmitPrimaryArtifacts {get; set;} = true;

        public bool EmitImmArtifacts {get; set;} = true;

        public bool CheckExecution {get; set;} = true;

        public bool DuplicateCheck {get; set;} = true;

        public bool HandleExtractsParsed {get; set;} = true;

        public bool CollectAsmStats {get; set;} = true;

        public bool MatchEmissions {get; set;} = true;

        public bool HandleExtractReportSaved {get; set;} = true;

        public bool HandleExtractReportCreated {get; set;} = false;

        public bool HandleParseReportCreated {get; set;} = false;

        public override string ToString()
            => Ops.Format();
    }
}