//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct MachineWorkflowConfig
    {
        public static MachineWorkflowConfig load(FilePath src)
        {
            var config = AppSettings.load<MachineWorkflowConfig>(src);
            return config;
        }
        
        public bool EnableCapture;
    }
}