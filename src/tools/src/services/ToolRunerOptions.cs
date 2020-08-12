//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public struct ToolRunnerOptions
    {        
        public bool NoThrow;
        
        public bool UseShellExecute;
        
        public bool NoWindow;
        
        public bool NoWait;
        
        public bool Elevate;
        
        public int TimeoutMSec;
        
        public string Input;
        
        public string OutputFile;
                
        public string CurrentDirectory;
        
        public Dictionary<string, string> Settings;
    }
}