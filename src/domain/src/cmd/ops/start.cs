//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        public static async Task<int> start(ToolCmdSpec spec, WfStatusRelay dst)
        {
            var info = new ProcessStartInfo
            {
                FileName = spec.ToolPath.Name,
                Arguments = spec.Args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = new Process {StartInfo = info};

            if (!spec.WorkingDir.IsNonEmpty)
                process.StartInfo.WorkingDirectory = spec.WorkingDir.Name;

            iter(spec.Vars.Storage, v => process.StartInfo.Environment.Add(v.Name, v.Value));

            process.OutputDataReceived += (s,d) => dst.OnInfo(d.Data ?? EmptyString);
            process.ErrorDataReceived += (s,d) => dst.OnError(d.Data ?? EmptyString);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            return await wait(process);
        }

        static async Task<int> wait(Process process)
        {
            return await Task.Run(() => {
                process.WaitForExit();
                return Task.FromResult(process.ExitCode);
            });
        }
    }
}