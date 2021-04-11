//     Copyright (c) Microsoft Corporation.  All rights reserved.
// Adapted from https://github.com/microsoft/perfview
namespace Windows
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Text;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// A MemoryNode represents a set of memory regions in a process.   MemoryNodes can have children and thus
    /// form trees.   Node also have names,
    /// </summary>
    public class MemoryNode
    {
        public string Name;

        public ulong Commit;        // Committed memory

        public ulong PrivateCommit;

        public ulong WorkingSet;

        public ulong PrivateWorkingSet;

        public ulong SharedWorkingSet;

        public List<MemoryNode> Children;

        public MemoryNode Parent;

        MEMORY_BASIC_INFORMATION BasicInfo;

        public ulong End
            => Address + Size;

        public ulong Address
            => BasicInfo.BaseAddress;

        public ulong AllocAddress
            => BasicInfo.AllocationBase;

        public ulong Size
            => BasicInfo.RegionSize;

        public PageProtection Protection
            => BasicInfo.Protect;

        public ulong SharableWorkingSet
            => WorkingSet - PrivateWorkingSet;

        public MemState MemState
            => BasicInfo.State;

        public MemType MemType
            => BasicInfo.Type;

        public static MemoryNode snapshot()
            => snapshot(Process.GetCurrentProcess().Id);

        /// <summary>
        /// This is the main entry point into the MemoryNode class.  Basically giving a process ID return
        /// a MemoryNode that represents the roll-up of all memory in the process.
        /// </summary>
        public static unsafe MemoryNode snapshot(int processID)
        {
            var root = Root();
            var process = Process.GetProcessById(processID);
            var name = new StringBuilder(260);
            long MaxAddress = long.MaxValue - 80000;
            long address = 0;
            var liberated = new List<IntPtr>();
            do
            {
                var child = new MemoryNode();
                int result = NativeMethods.VirtualQueryEx(process.Handle, (IntPtr)address, out child.BasicInfo, (uint)Marshal.SizeOf(child.BasicInfo));
                if (result == 0)
                    break;

                address = (long)child.BasicInfo.BaseAddress + (long)child.BasicInfo.RegionSize;

                if((long)child.BasicInfo.RegionSize < uint.MaxValue)
                {
                    if(NativeMethods.liberate(process.Handle, (IntPtr)address, (ulong)child.BasicInfo.RegionSize))
                    {
                        liberated.Add((IntPtr)address);
                    }
                }


                if (child.BasicInfo.Type == MemType.Image || child.BasicInfo.Type == MemType.Mapped)
                {
                    name.Clear();
                    var ret = NativeMethods.GetMappedFileName(process.Handle, (IntPtr)address, name, name.Capacity);
                    if (ret != 0)
                    {
                        child.Name = name.ToString();
                    }
                    else
                    {
                        Debug.WriteLine("Error, GetMappedFileName failed.");
                    }
                }
                root.Insert(child);
            } while (address <= MaxAddress);

            WORKING_SET_INFORMATION* WSInfo = stackalloc WORKING_SET_INFORMATION[1];
            NativeMethods.QueryWorkingSet(process.Handle, WSInfo, sizeof(WORKING_SET_INFORMATION));
            int buffSize = (int)(WSInfo->EntryCount) * 8 + 8 + 1024; // The 1024 is to allow for working set growth

            WSInfo = (WORKING_SET_INFORMATION*)Marshal.AllocHGlobal(buffSize);
            if (!NativeMethods.QueryWorkingSet(process.Handle, WSInfo, buffSize))
            {
                Marshal.FreeHGlobal((IntPtr)WSInfo);
                Marshal.ThrowExceptionForHR(Marshal.GetLastWin32Error());
            }

            // Copy the working set info to an array and sort the page addresses.
            int numBlocks = (int)WSInfo->EntryCount;
            ulong[] blocks = new ulong[numBlocks];
            for (var curWSIdx = 0; curWSIdx < numBlocks; curWSIdx++)
                blocks[curWSIdx] = WSInfo->Block(curWSIdx).Address;

            Array.Sort(blocks);
            Marshal.FreeHGlobal((IntPtr)WSInfo);

            // Attribute the working set to the regions of memory
            int curPageIdx = 0;
            foreach (var region in root.Children)
            {
                var end = region.End;
                while (curPageIdx < blocks.Length && blocks[curPageIdx] < end)
                {
                    curPageIdx++;
                    region.PrivateWorkingSet += 4; // TODO FIX NOW
                }
            }

            GC.KeepAlive(process);

            // foreach(var entry in liberated)
            //     Console.WriteLine($"Libarated {((ulong)entry).ToString("x")}");
            return root;
        }


        public override string ToString()
        {
            var sw = new StringWriter();
            ToCsv(sw);
            return sw.ToString();
        }

        public void ToCsv(TextWriter writer)
        {
            const string Header = "StartAddress | EndAddress | Size | Type | Protection | State | PrivateWs | Entity";
            const string Format= "{0:x} | {1:x} | {2:x} | {3} | {4} | {5} | {6} | {7}";
            if(Name == "[ROOT]")
                writer.WriteLine(Header);

            writer.WriteLine(string.Format(Format,  Address, Address+Size -1, Size, MemType,  Protection, MemState, PrivateWorkingSet, Name));
            if (Children != null)
            {
                foreach (var child in Children)
                    child.ToCsv(writer);
            }
        }


        private MemoryNode() { }

        private void Insert(MemoryNode newNode)
        {
            Debug.Assert(Address <= newNode.Address && newNode.End <= End);
            if (Children == null)
            {
                Children = new List<MemoryNode>();
            }

            // Search backwards for efficiency.
            for (int i = Children.Count; 0 < i;)
            {
                var child = Children[--i];
                if (child.Address <= newNode.Address && newNode.End <= child.End)
                {
                    child.Insert(newNode);
                    return;
                }
            }
            Children.Add(newNode);
            newNode.Parent = this;
        }

        static MemoryNode Root()
        {
            var ret = new MemoryNode();
            ret.BasicInfo.RegionSize = (ulong)unchecked(new IntPtr((long)ulong.MaxValue));
            ret.Name = "[ROOT]";
            return ret;
        }

        class NativeMethods
        {

            /// <summary>
            /// Enables an executable memory segment
            /// </summary>
            /// <param name="pMem">The leading cell pointer</param>
            /// <param name="length">The length of the segment, in bytes</param>
            public static bool liberate(IntPtr pProc, IntPtr pMem, ulong length)
            {
                if (!VirtualProtectEx(pProc, pMem, (UIntPtr)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                {
                    return false;
                    //Console.WriteLine($"Could not liberate {((ulong)pMem).ToString("x")}");
                }
                else
                    return true;
            }

            internal static void ThrowLiberationError(IntPtr pCode, int Length)
            {
                var start = (ulong)pCode;
                var end = start + (ulong)Length;
                throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");
            }

            [DllImport("psapi.dll", SetLastError = true), Free]
            public static extern unsafe bool QueryWorkingSet(IntPtr hProcess, WORKING_SET_INFORMATION* workingSetInfo, int workingSetInfoSize);

            [DllImport("psapi.dll", SetLastError = true), Free]
            public static extern int GetMappedFileName(IntPtr hProcess, IntPtr address, StringBuilder lpFileName, int nSize);

            [DllImport("kernel32.dll", SetLastError = true), Free]
            public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

            [DllImport("kernel32.dll"), Free]
            public static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, PageProtection flags, out PageProtection oldFlags);
        }
   }
}