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
    using System.IO;

    /// <summary>
    /// CommandOptions is a helper class for the Command class.  It stores options
    /// that affect the behavior of the execution of ETWCommands and is passes as a
    /// parapeter to the constructor of a Command.
    /// It is useful for these options be be on a separate class (rather than
    /// on Command itself), because it is reasonably common to want to have a set
    /// of options passed to several commands, which is not easily possible otherwise.
    /// </summary>
    public sealed class CmdProcessOptions
    {
        public bool noThrow;

        public bool useShellExecute;

        public bool noWindow;

        public bool elevate;

        public int timeoutMSec;

        public string input;

        public string outputFile;

        public TextWriter outputStream;

        public string currentDirectory;

        public Dictionary<string, string> environmentVariables;

        /// <summary>
        /// Can be assigned to the Timeout Property to indicate infinite timeout.
        /// </summary>
        public const int Infinite = System.Threading.Timeout.Infinite;

        /// <summary>
        /// CommanOptions holds a set of options that can be passed to the constructor
        /// to the Command Class as well as Command.Run*.
        /// </summary>
        public CmdProcessOptions()
        {
            timeoutMSec = 600000;
        }

        public CmdProcessOptions(TextWriter output)
            : this()
        {
            OutputStream = output;
        }

        /// <summary>
        /// Return a copy an existing set of command options.
        /// </summary>
        /// <returns>The copy of the command options.</returns>
        public CmdProcessOptions Clone()
        {
            return (CmdProcessOptions)MemberwiseClone();
        }

        /// <summary>
        /// Normally commands will throw if the subprocess returns a non-zero
        /// exit code.  NoThrow suppresses this.
        /// </summary>
        public bool NoThrow
        {
            get => noThrow;
            set => noThrow = value;
        }

        /// <summary>
        /// Updates the NoThrow property and returns the updated commandOptions.
        /// <returns>Updated command options</returns>
        /// </summary>
        public CmdProcessOptions AddNoThrow()
        {
            noThrow = true;
            return this;
        }

        /// <summary>
        /// ShortHand for UseShellExecute and NoWait.
        /// </summary>
        public bool Start
        {
            get => useShellExecute;
            set
            {
                useShellExecute = value;
            }
        }

        /// <summary>
        /// Updates the Start property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddStart()
        {
            Start = true;
            return this;
        }

        /// <summary>
        /// Normally commands are launched with CreateProcess.  However it is
        /// also possible use the Shell Start API.  This causes Command to look
        /// up the executable differently.
        /// </summary>
        public bool UseShellExecute
        {
            get => useShellExecute;
            set => useShellExecute = value;
        }

        /// <summary>
        /// Updates the Start property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddUseShellExecute()
        {
            useShellExecute = true;
            return this;
        }

        /// <summary>
        /// Indicates that you want to hide any new window created.
        /// </summary>
        public bool NoWindow
        {
            get => noWindow;
            set => noWindow = value;
        }

        /// <summary>
        /// Updates the NoWindow property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddNoWindow()
        {
            noWindow = true;
            return this;
        }


        /// <summary>
        /// Gets or sets a value indicating whether the command must run at elevated Windows privledges (causes a new command window).
        /// </summary>
        public bool Elevate
        {
            get => elevate;
            set => elevate = value;
        }

        /// <summary>
        /// Updates the Elevate property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddElevate()
        {
            elevate = true;
            return this;
        }

        /// <summary>
        /// By default commands have a 10 minute timeout (600,000 msec), If this
        /// is inappropriate, the Timeout property can change this.  Like all
        /// timouts in .NET, it is in units of milliseconds, and you can use
        /// CommandOptions.Infinite to indicate no timeout.
        /// </summary>
        public int Timeout
        {
            get => timeoutMSec;
            set => timeoutMSec = value;
        }

        /// <summary>
        /// Updates the Timeout property and returns the updated commandOptions.
        /// CommandOptions.Infinite can be used for infinite.
        /// </summary>
        public CmdProcessOptions AddTimeout(int milliseconds)
        {
            timeoutMSec = milliseconds;
            return this;
        }

        /// <summary>
        /// Indicates the string will be sent to Console.In for the subprocess.
        /// </summary>
        public string Input
        {
            get => input;
            set => input = value;
        }

        /// <summary>
        /// Updates the Input property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddInput(string input)
        {
            this.input = input;
            return this;
        }

        /// <summary>
        /// Indicates the current directory the subProcess will have.
        /// </summary>
        public string CurrentDirectory
        {
            get => currentDirectory;
            set => currentDirectory = value;
        }

        /// <summary>
        /// Updates the CurrentDirectory property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddCurrentDirectory(string directoryPath)
        {
            currentDirectory = directoryPath;
            return this;
        }

        // TODO add a capability to return a enumerator of output lines. (and/or maybe a delegate callback)

        /// <summary>
        /// Indicates the standard output and error of the command should be redirected
        /// to a archiveFile rather than being stored in Memory in the 'Output' property of the
        /// command.
        /// </summary>
        public string OutputFile
        {
            get => outputFile;
            set
            {
                if (outputStream != null)
                    throw new Exception("OutputFile and OutputStream can not both be set");

                outputFile = value;
            }
        }

        /// <summary>
        /// Updates the OutputFile property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddOutputFile(string outputFile)
        {
            OutputFile = outputFile;
            return this;
        }

        /// <summary>
        /// Indicates the standard output and error of the command should be redirected
        /// to a a TextWriter rather than being stored in Memory in the 'Output' property
        /// of the command.
        /// </summary>
        public TextWriter OutputStream
        {
            get => outputStream;
            set
            {
                if (outputFile != null)
                    throw new Exception("OutputFile and OutputStream can not both be set");

                outputStream = value;
            }
        }

        /// <summary>
        /// Updates the OutputStream property and returns the updated commandOptions.
        /// </summary>
        public CmdProcessOptions AddOutputStream(TextWriter outputStream)
        {
            OutputStream = outputStream;
            return this;
        }

        /// <summary>
        /// Gets the Environment variables that will be set in the subprocess that
        /// differ from current process's environment variables.  Any time a string
        /// of the form %VAR% is found in a value of a environment variable it is
        /// replaced with the value of the environment variable at the time the
        /// command is launched.  This is useful for example to update the PATH
        /// environment variable eg. "%PATH%;someNewPath".
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get
            {
                environmentVariables ??= new Dictionary<string, string>();
                return environmentVariables;
            }
        }

        /// <summary>
        /// Adds the environment variable with the give value to the set of
        /// environment variables to be passed to the sub-process and returns the
        /// updated commandOptions.   Any time a string
        /// of the form %VAR% is found in a value of a environment variable it is
        /// replaced with the value of the environment variable at the time the
        /// command is launched.  This is useful for example to update the PATH
        /// environment variable eg. "%PATH%;someNewPath".
        /// </summary>
        public CmdProcessOptions AddEnvironmentVariable(string variable, string value)
        {
            EnvironmentVariables[variable] = value;
            return this;
        }
    }
}