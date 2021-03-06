//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft
// License     :  MIT
// Source      : Adapted from miengine/src/WindowsDebugLauncher/DebugLauncher.cs
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Root;

    public struct ExePipeOptions
    {
        public static ExePipeOptions init()
        {
            var dst = new ExePipeOptions();
            dst.PipeServer = ".";
            dst.StdInPipeName = EmptyString;
            dst.StdOutPipeName = EmptyString;
            dst.StdErrPipeName = EmptyString;
            dst.PidPipeName = EmptyString;
            dst.ExePath = EmptyString;
            dst.ControllerName = "control";
            dst.ExeArgs = new();
            return dst;
        }

        public string PipeServer;

        public string StdInPipeName;

        public string StdOutPipeName;

        public string StdErrPipeName;

        public string PidPipeName;

        public string ExePath;

        public string ControllerName;

        public List<string> ExeArgs;

        /// <summary>
        /// Ensures all parameters have been set
        /// </summary>
        public bool ValidateParameters()
        {
            return !(string.IsNullOrEmpty(PipeServer)
                || string.IsNullOrEmpty(StdInPipeName)
                || string.IsNullOrEmpty(StdOutPipeName)
                || string.IsNullOrEmpty(StdErrPipeName)
                || string.IsNullOrEmpty(PidPipeName)
                || string.IsNullOrEmpty(ExePath)
                || string.IsNullOrEmpty(ControllerName)
                );
        }

        public string Format()
        {
            var dst = TextTools.buffer();
            foreach (var arg in ExeArgs.ToList())
            {
                if(arg.Contains(' '))
                    dst.Append("\"" + arg + "\"");
                else
                    dst.Append(arg);

                dst.Append(' ');
            }

            return dst.Emit();
        }
    }
}