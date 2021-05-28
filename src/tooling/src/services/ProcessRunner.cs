//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Threading;

    using static Root;

    public static class ProcessRunner
    {
        static Thread s_backgroundWatcher;

        static List<(Process process, Action action)> s_watchedProcesses;

        static bool IsMono => Type.GetType("Mono.Runtime") != null;

        [MethodImpl(Inline)]
        public static ProcessExitStatus status(int code, bool started = true, bool timedOut = false)
            => new ProcessExitStatus(code,started,timedOut);

        public static string RunAndCaptureOutput(FS.FilePath path, string args, FS.FolderPath? workingDirectory = null)
        {
            var startInfo = new ProcessStartInfo(path.Format(), args)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = (workingDirectory ?? FS.FolderPath.Empty).Format(),
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            try
            {
                process.Start();
            }
            catch
            {
                Console.WriteLine($"Failed to launch '{path.ToString()}' with args, '{args}'");
                return null;
            }

            var output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Trim();
        }

        public static void ExitAction(Process process, Action action)
        {
            var gate = new object();

            void CleanUpProcesses()
            {
                lock (gate)
                {
                    for (int i = s_watchedProcesses.Count - 1; i >= 0; --i)
                    {
                        var (p, a) = s_watchedProcesses[i];
                        if (p.HasExited)
                        {
                            s_watchedProcesses.RemoveAt(i);
                            a();
                        }
                    }
                }
            }

            void Watcher()
            {
                while (true)
                {
                    CleanUpProcesses();

                    // REVIEW: Configurable?
                    Thread.Sleep(2000);
                }
            }

            if (IsMono)
            {
                // In mono 3.10, the Exited event fires immediately, we're going to poll instead
                lock (gate)
                {
                    if (s_watchedProcesses == null)
                    {
                        s_watchedProcesses = new List<(Process process, Action action)>();
                    }

                    s_watchedProcesses.Add((process, action));

                    if (s_backgroundWatcher == null)
                    {
                        s_backgroundWatcher = new Thread(Watcher) { IsBackground = true };
                        s_backgroundWatcher.Start();
                    }
                }
            }
            else
            {
                process.Exited += (sender, e) =>
                {
                    action();
                };
            }
        }

        static void KillChildrenAndThis(this Process process)
        {
            if (IsMono)
            {
                foreach (var childProcess in GetChildProcesses(process.Id))
                    childProcess.Kill();
            }

            process.Kill();
        }

        static IEnumerable<Process> GetChildProcesses(int processId)
        {
            foreach (var entry in GetAllProcessIds())
            {
                if (entry.parentId == processId)
                    yield return Process.GetProcessById(entry.id);
            }
        }

        static IEnumerable<(int id, int parentId)> GetAllProcessIds()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "ps",
                Arguments = string.Format("-o \"ppid, pid\" -ax"),
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var entries = new List<(int processId, int parentProcessId)>();

            var ps = Process.Start(startInfo);
            ps.BeginOutputReadLine();
            ps.OutputDataReceived += (sender, e) =>
            {
                if (string.IsNullOrEmpty(e.Data))
                {
                    return;
                }

                var parts = e.Data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (Int32.TryParse(parts[0], out var ppid) &&
                    Int32.TryParse(parts[1], out var pid))
                {
                    entries.Add((pid, ppid));
                }
            };

            ps.WaitForExit();

            return entries;
        }

        public static ProcessExitStatus Run(string fileName, string arguments, string workingDirectory = null, Action<string> outputDataReceived = null,
            Action<string> errorDataReceived = null, Action<IDictionary<string, string>> updateEnvironment = null)
        {
            var startInfo = new ProcessStartInfo(fileName, arguments)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = workingDirectory ?? string.Empty,
            };

            updateEnvironment(startInfo.Environment);

            var process = new Process
            {
                StartInfo = startInfo
            };

            try
            {
                process.Start();
            }
            catch
            {
                Console.WriteLine($"Failed to launch '{fileName}' with args, '{arguments}'");
                return status(process.ExitCode, started: false);
            }

            if (process.HasExited)
            {
                return status(process.ExitCode);
            }

            var lastSignal = DateTime.UtcNow;
            var watchDog = Task.Factory.StartNew(async () =>
            {
                var delay = TimeSpan.FromSeconds(10);
                var timeout = TimeSpan.FromSeconds(60);
                while (!process.HasExited)
                {
                    if (DateTime.UtcNow - lastSignal > timeout)
                    {
                        process.KillChildrenAndThis();
                    }

                    await Task.Delay(delay);
                }
            });

            process.OutputDataReceived += (_, e) =>
            {
                lastSignal = DateTime.UtcNow;

                if (outputDataReceived != null && !string.IsNullOrEmpty(e.Data))
                {
                    outputDataReceived(e.Data);
                }
            };

            process.ErrorDataReceived += (_, e) =>
            {
                lastSignal = DateTime.UtcNow;

                if (errorDataReceived != null && !string.IsNullOrEmpty(e.Data))
                {
                    errorDataReceived(e.Data);
                }
            };

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            return status(process.ExitCode);
        }
    }
}