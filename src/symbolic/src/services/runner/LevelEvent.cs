//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ProjectRunner
    {
        public class LevelEvent
        {
            public const string Id = "LevelEvent";

            public string MessageLevel {get;set;}

            public string Message {get;set;}
        }
    }
}