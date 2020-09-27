namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct WfTools
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolId<T> identify<T>()
            => default;

        /// <summary>
        /// Creates a predicated tool identifier
        /// </summary>
        [MethodImpl(Inline)]
        public static ToolId identify(Type t)
            => new ToolId(t);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(ToolId<T> src)
            =>  src.Name;

        public static async Task<int> start(ToolCommand spec, WfStatusRelay dst)
        {
            var info = new ProcessStartInfo
            {
                FileName = spec.Tool.Name,
                Arguments = spec.Command,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = new Process {StartInfo = info};

            if (!spec.Root.IsNonEmpty)
                process.StartInfo.WorkingDirectory = spec.Root.Name;

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