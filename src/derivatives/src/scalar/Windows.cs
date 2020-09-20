//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Pipes;
    using System.Linq;
    using System.Security.AccessControl;
    using System.Security.Principal;
    using System.ServiceProcess;
    using System.Text;
    using Microsoft.Win32;

    public class WindowsPlatform
    {
        public static WindowsPlatform Instance => new WindowsPlatform();

        const string WindowsVersionRegistryKey = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";

        const string BuildLabRegistryValue = "BuildLab";

        const string BuildLabExRegistryValue = "BuildLabEx";

        public NamedPipeServerStream CreatePipeByName(string pipeName)
        {
            PipeSecurity security = new PipeSecurity();
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), PipeAccessRights.ReadWrite | PipeAccessRights.CreateNewInstance, AccessControlType.Allow));
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.CreatorOwnerSid, null), PipeAccessRights.FullControl, AccessControlType.Allow));
            security.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null), PipeAccessRights.FullControl, AccessControlType.Allow));

            NamedPipeServerStream pipe = NamedPipeServerStreamEx.Create(
                pipeName,
                PipeDirection.InOut,
                NamedPipeServerStream.MaxAllowedServerInstances,
                PipeTransmissionMode.Byte,
                PipeOptions.WriteThrough | PipeOptions.Asynchronous,
                0, // default inBufferSize
                0, // default outBufferSize
                security,
                HandleInheritability.None);

            return pipe;
        }


        public WindowsPlatformConstants Constants { get; } = new WindowsPlatformConstants();

        public static string GetStringFromRegistry(string key, string valueName)
        {
            object value = GetValueFromRegistry(RegistryHive.LocalMachine, key, valueName);
            return value as string;
        }

        public static object GetValueFromRegistry(RegistryHive registryHive, string key, string valueName)
        {
            object value = GetValueFromRegistry(registryHive, key, valueName, RegistryView.Registry64);
            if (value == null)
            {
                value = GetValueFromRegistry(registryHive, key, valueName, RegistryView.Registry32);
            }

            return value;
        }

        static object GetValueFromRegistry(RegistryHive registryHive, string key, string valueName, RegistryView view)
        {
            RegistryKey localKey = RegistryKey.OpenBaseKey(registryHive, view);
            RegistryKey localKeySub = localKey.OpenSubKey(key);

            object value = localKeySub == null ? null : localKeySub.GetValue(valueName);
            return value;
        }

        public static bool TrySetDWordInRegistry(RegistryHive registryHive, string key, string valueName, uint value)
        {
            RegistryKey localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry64);
            RegistryKey localKeySub = localKey.OpenSubKey(key, writable: true);

            if (localKeySub == null)
            {
                localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry32);
                localKeySub = localKey.OpenSubKey(key, writable: true);
            }

            if (localKeySub == null)
            {
                return false;
            }

            localKeySub.SetValue(valueName, value, RegistryValueKind.DWord);
            return true;
        }

        public void StartBackgroundScalarProcess(ITracer tracer, string programName, string[] args)
        {
            string programArguments = string.Empty;
            try
            {
                programArguments = string.Join(" ", args.Select(arg => arg.Contains(' ') ? "\"" + arg + "\"" : arg));
                ProcessStartInfo processInfo = new ProcessStartInfo(programName, programArguments);
                processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processInfo.UseShellExecute = true;

                Process executingProcess = new Process();
                executingProcess.StartInfo = processInfo;
                executingProcess.Start();
            }
            catch (Exception ex)
            {
                EventMetadata metadata = new EventMetadata();
                metadata.Add(nameof(programName), programName);
                metadata.Add(nameof(programArguments), programArguments);
                metadata.Add("Exception", ex.ToString());
                tracer.RelatedError(metadata, "Failed to start background process.");
                throw;
            }
        }

        public class WindowsPlatformConstants
        {
            public string ExecutableExtension
            {
                get { return ".exe"; }
            }

            public string InstallerExtension
            {
                get { return ".exe"; }
            }

            public bool SupportsUpgradeWhileRunning => false;

            public string ScalarBinDirectoryPath
            {
                get
                {
                    return Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        this.ScalarBinDirectoryName);
                }
            }

            public string ScalarBinDirectoryName
            {
                get { return "Scalar"; }
            }

            public string ScalarExecutableName
            {
                get { return "Scalar" + this.ExecutableExtension; }
            }

            public string ProgramLocaterCommand
            {
                get { return "where"; }
            }

            public HashSet<string> UpgradeBlockingProcesses
            {
                get { return new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Scalar", "git", "ssh-agent", "wish", "bash" }; }
            }

            // Tests show that 250 is the max supported pipe name length
            public int MaxPipePathLength => 250;
        }

    }
}