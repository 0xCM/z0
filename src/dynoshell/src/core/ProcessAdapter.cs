//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct ProcessAdapter : IAdapter<ProcessAdapter,Process>
    {
        public Process Subject {get;}

        [MethodImpl(Inline)]
        public ProcessAdapter(Process subject)
            => Subject = subject;

        [MethodImpl(Inline)]
        public ProcessAdapter Adapt(Process subject)
            => new ProcessAdapter(subject);

        //
        // Summary:
        //     Gets the base priority of the associated process.
        //
        // Returns:
        //     The base priority, which is computed from the System.Diagnostics.Process.PriorityClass
        //     of the associated process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has exited. -or- The process has not started, so there is no process
        //     ID.
        public int BasePriority
        {
            [MethodImpl(Inline)]
            get => Subject.BasePriority;
        }

        //
        // Summary:
        //     Gets or sets whether the System.Diagnostics.Process.Exited event should be raised
        //     when the process terminates.
        //
        // Returns:
        //     true if the System.Diagnostics.Process.Exited event should be raised when the
        //     associated process is terminated (through either an exit or a call to System.Diagnostics.Process.Kill);
        //     otherwise, false. The default is false. Note that the System.Diagnostics.Process.Exited
        //     event is raised even if the value of System.Diagnostics.Process.EnableRaisingEvents
        //     is false when the process exits during or before the user performs a System.Diagnostics.Process.HasExited
        //     check.
        public bool EnableRaisingEvents
        {
            [MethodImpl(Inline)]
            get => Subject.EnableRaisingEvents;

            [MethodImpl(Inline)]
            set => Subject.EnableRaisingEvents = value;
        }

        //
        // Summary:
        //     Gets the value that the associated process specified when it terminated.
        //
        // Returns:
        //     The code that the associated process specified when it terminated.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has not exited. -or- The process System.Diagnostics.Process.Handle
        //     is not valid.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.ExitCode property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        public int ExitCode
        {
            [MethodImpl(Inline)]
            get => Subject.ExitCode;
        }

        //
        // Summary:
        //     Gets the time that the associated process exited.
        //
        // Returns:
        //     A System.DateTime that indicates when the associated process was terminated.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.ExitTime property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        public DateTime ExitTime
        {
            get => Subject.ExitTime;
        }

        //
        // Summary:
        //     Gets the native handle of the associated process.
        //
        // Returns:
        //     The handle that the operating system assigned to the associated process when
        //     the process was started. The system uses this handle to keep track of process
        //     attributes.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has not been started or has exited. The System.Diagnostics.Process.Handle
        //     property cannot be read because there is no process associated with this System.Diagnostics.Process
        //     instance. -or- The System.Diagnostics.Process instance has been attached to a
        //     running process but you do not have the necessary permissions to get a handle
        //     with full access rights.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.Handle property for a
        //     process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        public Ptr Handle
        {
            [MethodImpl(Inline)]
            get => Subject.Handle;
        }

        //
        // Summary:
        //     Gets the number of handles opened by the process.
        //
        // Returns:
        //     The number of operating system handles the process has opened.
        public int HandleCount
        {
            [MethodImpl(Inline)]
            get => Subject.HandleCount;
        }

        //
        // Summary:
        //     Gets a value indicating whether the associated process has been terminated.
        //
        // Returns:
        //     true if the operating system process referenced by the System.Diagnostics.Process
        //     component has terminated; otherwise, false.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     There is no process associated with the object.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     The exit code for the process could not be retrieved.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.HasExited property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        public bool HasExited
        {
            [MethodImpl(Inline)]
            get => Subject.HasExited;
        }

        //
        // Summary:
        //     Gets the unique identifier for the associated process.
        //
        // Returns:
        //     The system-generated unique identifier of the process that is referenced by this
        //     System.Diagnostics.Process instance.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process's System.Diagnostics.Process.Id property has not been set. -or- There
        //     is no process associated with this System.Diagnostics.Process object.
        public int Id
        {
            [MethodImpl(Inline)]
            get => Subject.Id;
        }

        //
        // Summary:
        //     Gets the name of the computer the associated process is running on.
        //
        // Returns:
        //     The name of the computer that the associated process is running on.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     There is no process associated with this System.Diagnostics.Process object.
        public string MachineName
        {
            [MethodImpl(Inline)]
            get => Subject.MachineName;
        }

        //
        // Summary:
        //     Gets the main module for the associated process.
        //
        // Returns:
        //     The System.Diagnostics.ProcessModule that was used to start the process.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainModule property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     A 32-bit process is trying to access the modules of a 64-bit process.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        public ProcessModule MainModule
        {
            [MethodImpl(Inline)]
            get => Subject.MainModule;
        }

        //
        // Summary:
        //     Gets the window handle of the main window of the associated process.
        //
        // Returns:
        //     The system-generated window handle of the main window of the associated process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.MainWindowHandle is not defined because the process
        //     has exited.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainWindowHandle property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        public Ptr MainWindowHandle
        {
            [MethodImpl(Inline)]
            get => Subject.MainWindowHandle;
        }

        //
        // Summary:
        //     Gets the caption of the main window of the process.
        //
        // Returns:
        //     The main window title of the process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.MainWindowTitle property is not defined because
        //     the process has exited.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainWindowTitle property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        public string MainWindowTitle
        {
            [MethodImpl(Inline)]
            get => Subject.MainWindowTitle;
        }

        //
        // Summary:
        //     Gets or sets the maximum allowable working set size, in bytes, for the associated
        //     process.
        //
        // Returns:
        //     The maximum working set size that is allowed in memory for the process, in bytes.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The maximum working set size is invalid. It must be greater than or equal to
        //     the minimum working set size.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     Working set information cannot be retrieved from the associated process resource.
        //     -or- The process identifier or process handle is zero because the process has
        //     not been started.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MaxWorkingSet property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        public ByteSize MaxWorkingSet
        {
            [MethodImpl(Inline)]
            get => Subject.MaxWorkingSet;

            [MethodImpl(Inline)]
            set => Subject.MaxWorkingSet = value;
        }

        //
        // Summary:
        //     Gets or sets the minimum allowable working set size, in bytes, for the associated
        //     process.
        //
        // Returns:
        //     The minimum working set size that is required in memory for the process, in bytes.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The minimum working set size is invalid. It must be less than or equal to the
        //     maximum working set size.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     Working set information cannot be retrieved from the associated process resource.
        //     -or- The process identifier or process handle is zero because the process has
        //     not been started.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MinWorkingSet property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        public ByteSize MinWorkingSet
        {
            [MethodImpl(Inline)]
            get => Subject.MinWorkingSet;

            [MethodImpl(Inline)]
            set => Subject.MinWorkingSet = value;
        }

        //
        // Summary:
        //     Gets the modules that have been loaded by the associated process.
        //
        // Returns:
        //     An array of type System.Diagnostics.ProcessModule that represents the modules
        //     that have been loaded by the associated process.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.Modules property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     You are attempting to access the System.Diagnostics.Process.Modules property
        //     for either the system process or the idle process. These processes do not have
        //     modules.
        public IndexedSeq<ProcessModule> Modules
        {
            [MethodImpl(Inline)]
            get => Subject.Modules.Cast<ProcessModule>().Array();
        }

        //
        // Summary:
        //     Gets the amount of nonpaged system memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of system memory, in bytes, allocated for the associated process that
        //     cannot be written to the virtual memory paging file.
        public ByteSize NonpagedSystemMemorySize64
        {
            [MethodImpl(Inline)]
            get => Subject.NonpagedSystemMemorySize64;
        }

        [MethodImpl(Inline)]
        public static implicit operator ProcessAdapter(Process subject)
            => new ProcessAdapter(subject);

        [MethodImpl(Inline)]
        public static implicit operator Process(ProcessAdapter src)
            => src.Subject;
    }
}