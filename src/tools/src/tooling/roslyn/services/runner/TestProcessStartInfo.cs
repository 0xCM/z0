//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    partial struct ProjectRunner
    {
        [DataContract]
        public class TestProcessStartInfo
        {
            [DataMember]
            public string FileName { get; set; }

            [DataMember]
            public string Arguments { get; set; }

            [DataMember]
            public string WorkingDirectory { get; set; }

            [DataMember]
            public IDictionary<string, string> EnvironmentVariables { get; set; }

            [DataMember]
            public IDictionary<string, string> CustomProperties { get; set; }
        }
    }
}