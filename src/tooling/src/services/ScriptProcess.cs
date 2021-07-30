//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;

    using static Root;

    /// <summary>
    /// Command represents a running of a command lineNumber process.  It is basically
    /// a wrapper over System.Diagnostics.Process, which hides the complexity
    /// of System.Diagnostics.Process, and knows how to capture output and otherwise
    /// makes calling commands very easy.
    /// </summary>
    public sealed class ScriptProcess : IScriptProcess
    {
        /// <summary>
        /// Creates a command process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command, ScriptProcessOptions config)
            => new ScriptProcess(command, config);

        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command)
            => new ScriptProcess(command);

        [Op]
        public static ScriptProcess run(CmdLine command, CmdVars vars)
        {
            var options = new ScriptProcessOptions();
            include(vars, options);
            // foreach(var v in vars)
            // {
            //     if(v.IsNonEmpty)
            //         options.AddEnvironmentVariable(v.Name,v.Value);
            // }
            return new ScriptProcess(command, options);
        }

        [Op]
        public static ScriptProcess run(CmdLine command, CmdVars vars, Receiver<string> status, Receiver<string> error)
        {
            var options = new ScriptProcessOptions();
            include(vars, options);
            options.WithReceivers(status, error);
            return new ScriptProcess(command, options);
        }

        [Op]
        public static ScriptProcess run(CmdLine command, Receiver<string> status, Receiver<string> error)
        {
            var options = new ScriptProcessOptions();
            options.WithReceivers(status, error);
            return new ScriptProcess(command, options);
        }

        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command, TextWriter dst)
            => new ScriptProcess(command, new ScriptProcessOptions(dst));

        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command, TextWriter dst, Receiver<string> status, Receiver<string> error)
        {
            var options = new ScriptProcessOptions(dst);
            options.WithReceivers(status, error);
            return new ScriptProcess(command, options);
        }

        static void include(CmdVars src, ScriptProcessOptions dst)
        {
            foreach(var v in src)
            {
                if(v.IsNonEmpty)
                    dst.AddEnvironmentVariable(v.Name,v.Value);
            }
        }

        readonly CmdLine _commandLine;

        readonly StringBuilder _output;

        TextWriter _outputStream;

        bool DisposeOutputStream;

        /// <summary>
        /// Gets that CommandOptions structure that holds all the options that affect
        /// the running of the command (like Timeout, Input ...)
        /// </summary>
        public ScriptProcessOptions Options {get;}

        /// <summary>
        /// Gets the underlying process object.  Generally not used.
        /// </summary>
        public Process Process {get;}

        /// <summary>
        /// Launch a new command and returns the Command object that can be used to monitor
        /// the restult.  It does not wait for the command to complete, however you
        /// can call 'Wait' to do that, or use the 'Run' or 'RunToConsole' methods. */
        /// </summary>
        /// <param variable="commandLine">The command lineNumber to run as a subprocess</param>
        /// <param variable="options">Additional qualifiers that control how the process is run</param>
        /// <returns>A Command structure that can be queried to determine ExitCode, Output, etc.</returns>
        public ScriptProcess(CmdLine commandLine, ScriptProcessOptions options)
        {
            Options = options;
            _commandLine = commandLine;

            // See if the command is quoted and match it in that case
            Match m = Regex.Match(commandLine, "^\\s*\"(.*?)\"\\s*(.*)");
            if (!m.Success)
                m = Regex.Match(commandLine, @"\s*(\S*)\s*(.*)"); // thing before first space is command


            ProcessStartInfo startInfo = new ProcessStartInfo(m.Groups[1].Value, m.Groups[2].Value)
            {
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                ErrorDialog = false,
                CreateNoWindow = true,
                RedirectStandardInput = options.Input != null
            };

            Process = new Process { StartInfo = startInfo };
            Process.StartInfo = startInfo;
            _output = new StringBuilder();
            if (options._Elevate)
            {
                options._UseShellExecute = true;
                startInfo.Verb = "runas";
                options._CurrentDirectory ??= Environment.CurrentDirectory;
            }

            Process.OutputDataReceived += HandleStdEvent;
            Process.ErrorDataReceived += HandleErrEvent;

            if (options._EnvVars != null)
            {
                // copy over the environment variables to the process startInfo options.
                foreach (string key in options._EnvVars.Keys)
                {
                    // look for %VAR% strings in the value and subtitute the appropriate environment variable.
                    string value = options._EnvVars[key];
                    if (value != null)
                    {
                        int startAt = 0;
                        for (; ; )
                        {
                            m = new Regex(@"%(\w+)%").Match(value, startAt);
                            if (!m.Success)
                                break;

                            string varName = m.Groups[1].Value;
                            string varValue;
                            if (startInfo.EnvironmentVariables.ContainsKey(varName))
                            {
                                varValue = startInfo.EnvironmentVariables[varName];
                            }
                            else
                            {
                                varValue = Environment.GetEnvironmentVariable(varName) ?? string.Empty;
                            }

                            // replace this instance of the variable with its definition.
                            int varStart = m.Groups[1].Index - 1; // -1 becasue % chars are not in the group
                            int varEnd = varStart + m.Groups[1].Length + 2; // +2 because % chars are not in the group
                            value = value.Substring(0, varStart) + varValue + value.Substring(varEnd);
                            startAt = varStart + varValue.Length;
                        }
                    }

                    startInfo.EnvironmentVariables[key] = value;
                }
            }

            startInfo.WorkingDirectory = options._CurrentDirectory;

            if(options._OutputStream != null)
            {
                _outputStream = options._OutputStream;
                DisposeOutputStream = false;
            }
            else
            {
                if (options._OutputFile != null)
                {
                    _outputStream = File.CreateText(options._OutputFile);
                    DisposeOutputStream = true;
                }
            }

            try
            {
                Process.Start();
            }
            catch(Exception e)
            {
                string msg = "Failure starting Process\r\n" +
                    "    Exception: " + e.Message + "\r\n" +
                    "    Cmd: " + commandLine + "\r\n";

                if (Regex.IsMatch(startInfo.FileName, @"^(copy|dir|del|color|set|cd|cdir|md|mkdir|prompt|pushd|popd|start|assoc|ftype)", RegexOptions.IgnoreCase))
                    msg += "    Cmd " + startInfo.FileName + " implemented by Cmd.exe, fix by prefixing with 'cmd /c'.";
                throw new Exception(msg, e);
            }

            if (!startInfo.UseShellExecute)
            {
                // startInfo asynchronously collecting output
                Process.BeginOutputReadLine();
                Process.BeginErrorReadLine();
            }

            // Send any input to the command
            if (options._Input != null)
            {
                Process.StandardInput.Write(options._Input);
                Process.StandardInput.Dispose();
            }
        }

        /// <summary>
        /// Create a subprocess to run 'commandLine' with no special options.
        /// <param variable="commandLine">The command lineNumber to run as a subprocess</param>
        /// </summary>
        public ScriptProcess(CmdLine commandLine)
            : this(commandLine, new ScriptProcessOptions())
        {
        }

        [MethodImpl(Inline)]
        public CmdExecStatus Status()
        {
            var dst = new CmdExecStatus();
            Status(ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public ref CmdExecStatus Status(ref CmdExecStatus dst)
        {
            dst.Id = Process.Id;
            dst.StartTime = Process.StartTime;
            dst.HasExited = Process.HasExited;
            if(Finished)
            {
                dst.ExitTime = Process.ExitTime;
                dst.Duration = dst.ExitTime - dst.StartTime;
                dst.ExitCode = Process.ExitCode;
            }
            return ref dst;
        }

        /// <summary>
        /// Gets a value indicating whether the process has exited.
        /// </summary>
        public bool Finished
            => Process.HasExited;

        /// <summary>
        /// Gets the time the process started.
        /// </summary>
        public DateTime StartTime
            => Process.StartTime;

        /// <summary>
        /// Gets the time the processed Exited.  (HasExited should be <see langword="true"/> before calling)
        /// </summary>
        public DateTime ExitTime
            => Process.ExitTime;

        /// <summary>
        /// Gets the duration of the command (HasExited should be <see langword="true"/> before calling)
        /// </summary>
        public TimeSpan Duration
            => ExitTime - StartTime;

        /// <summary>
        /// Gets the operating system ID for the subprocess.
        /// </summary>
        public int ProcessId
            => Process.Id;

        /// <summary>
        /// Gets the process exit code for the subprocess.  (HasExited should be <see langword="true"/> before calling)
        /// Often this does not need to be checked because Command.Run will throw an exception
        /// if it is not zero.   However it is useful if the CommandOptions.NoThrow property
        /// was set.
        /// </summary>
        public int ExitCode
            => Process.ExitCode;

        /// <summary>
        /// Gets the standard output and standard error output from the command.  This
        /// is accumulated in real time so it can vary if the process is still running.
        /// This property is NOT available if the CommandOptions.OutputFile or CommandOptions.OutputStream
        /// is specified since the output is being redirected there.   If a large amount of output is
        /// expected (> 1Meg), the Run.AddOutputStream(Stream) is recommended for retrieving it since
        /// the large string is never materialized at one time.
        /// </summary>
        public string Output
        {
            get
            {
                if (_outputStream != null)
                    throw new Exception("Output not available if redirected to file or stream");
                return _output.ToString();
            }
        }

        void HandleStdEvent(object sender, DataReceivedEventArgs e)
        {
            if (_outputStream != null)
                _outputStream.WriteLine(e.Data);
            else
                _output.AppendLine(e.Data);

            Task.Run(() => Options.StatusReceiver.Invoke(e.Data));
        }

        void HandleErrEvent(object sender, DataReceivedEventArgs e)
        {
            if (_outputStream != null)
                _outputStream.WriteLine(e.Data);
            else
                _output.AppendLine(e.Data);

            Task.Run(() => Options.ErrorReceiver.Invoke(e.Data));
        }

        /// <summary>
        /// Wait for a started process to complete (HasExited will be <see langword="true"/> on return)
        /// </summary>
        /// <returns>Wait returns that 'this' pointer.</returns>
        public ScriptProcess Wait()
        {
            bool waitReturned = false;
            bool killed = false;
            try
            {
                Process.WaitForExit(Options._TimeoutMS);
                waitReturned = true;
                // TODO : HACK we see to have a race in the async process stuff
                // If you do Run("cmd /c set") you get truncated output at the
                // Looks like the problem in the framework.
                for (int i = 0; i<10; i++)
                    Thread.Sleep(1);
            }
            finally
            {
                if (!Process.HasExited)
                {
                    killed = true;
                    Kill();
                }
            }

            if (_outputStream != null && DisposeOutputStream)
                _outputStream.Dispose();

            _outputStream = null;

            if (waitReturned && killed)
                throw new Exception("Timeout of " + Options._TimeoutMS / 1000 + " sec exceeded\r\n    Cmd: " + _commandLine);

            if (Process.ExitCode != 0 && !Options._NoThrow)
                ThrowCommandFailure(null);
            return this;
        }

        /// <summary>
        /// Throw a error if the command exited with a non-zero exit code
        /// printing useful diagnostic information along with the thrown message.
        /// This is useful when NoThrow is specified, and after post-processing
        /// you determine that the command really did fail, and an normal
        /// Command.Run failure was the appropriate action.
        /// </summary>
        /// <param name="message">An additional message to print in the throw.</param>
        public void ThrowCommandFailure(string message)
        {
            if (Process.ExitCode != 0)
            {
                string outSpec = string.Empty;
                if (_outputStream is null)
                {
                    string outStr = _output.ToString();
                    // Only show the first lineNumber the last two lines if there are a lot of output.
                    Match m = Regex.Match(outStr, @"^(\s*\n)?(.+\n)(.|\n)*?(.+\n.*\S)\s*$");
                    if (m.Success)
                        outStr = m.Groups[2].Value + "    <<< Omitted output ... >>>\r\n" + m.Groups[4].Value;
                    else
                        outStr = outStr.Trim();
                    // Indent the output
                    outStr = outStr.Replace("\n", "\n    ");
                    outSpec = "\r\n  Output: {\r\n    " + outStr + "\r\n  }";
                }

                if (message is null)
                    message = string.Empty;
                else if (message.Length > 0)
                    message += "\r\n";
                throw new Exception($"{message} Process returned exit code 0x{Process.ExitCode:x} Cmd: {_commandLine}{outSpec}");
            }
        }

        /// <summary>
        /// Kill the process (and any child processses (recursively) associated with the
        /// running command).   Note that it may not be able to kill everything it should
        /// if the child-parent' chain is broken by a child that creates a subprocess and
        /// then dies itself.   This is reasonably uncommon, however.
        /// </summary>
        public void Kill()
        {
            // We use taskkill because it is built into windows, and knows
            // how to kill all subchildren of a process, which important.
            term.babble("Killing process tree " + ProcessId + " Cmd: " + _commandLine);
            try
            {
                ScriptProcess.run("taskkill /f /t /pid " + Process.Id).Wait();
            }
            catch (Exception e)
            {
                term.error(e);
            }

            int ticks = 0;
            do
            {
                Thread.Sleep(10);
                ticks++;
                if (ticks > 100)
                {
                    term.warn("ERROR: process is not dead 1 sec after killing " + Process.Id);
                    term.warn("Cmd: " + _commandLine);
                }
            } while (!Process.HasExited);

            // If we created the output stream, we should close it.
            if (_outputStream != null && Options._OutputFile != null)
                _outputStream.Dispose();
            _outputStream = null;
        }

        /// <summary>
        /// Put double quotes around 'str' if necessary (handles quotes quotes.
        /// </summary>
        public static string Quote(string str)
        {
            if (str.IndexOf('"') < 0)
            {
                // Replace any " with \"  (and any \" with \\" and and \\" with \\\"  ...)
                str = Regex.Replace(str, "\\*\"", @"\$1");
            }

            return "\"" + str + "\"";
        }

        /// <summary>
        /// Given a string 'commandExe' look for it on the path the way cmd.exe would.
        /// Returns <see langword="null"/> if it was not found.
        /// </summary>
        public static string FindOnPath(string commandExe)
        {
            string ret = ProbeForExe(commandExe);
            if (ret != null)
                return ret;

            if (!commandExe.Contains("\\"))
            {
                foreach (string path in Paths)
                {
                    string baseExe = Path.Combine(path, commandExe);
                    ret = ProbeForExe(baseExe);
                    if (ret != null)
                        return ret;
                }
            }

            return null;
        }

        static string ProbeForExe(string path)
        {
            if (File.Exists(path))
                return path;

            foreach (string ext in PathExts)
            {
                string name = path + ext;
                if (File.Exists(name))
                    return name;
            }

            return null;
        }

        static string[] PathExts
        {
            get
            {
                s_pathExts ??= Environment.GetEnvironmentVariable("PATHEXT")!.Split(';');
                return s_pathExts;
            }
        }

        static string[] s_pathExts;

        static string[] Paths
        {
            get
            {
                s_paths ??= Environment.GetEnvironmentVariable("PATH")!.Split(';');
                return s_paths;
            }
        }

        static string[] s_paths;
    }
}