// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace SOS
{
    using System;
    using System.Runtime.InteropServices;

    using static SOSCallbackDelegates;
    using static SymbolReader;

    public readonly struct SOSCallbackDelegates
    {
        public delegate bool InitializeSymbolStoreDelegate(
            bool logging,
            bool msdl,
            bool symweb,
            string tempDirectory,
            string symbolServerPath,
            string authToken,
            int timeoutInMintues,
            string symbolCachePath,
            string symbolDirectoryPath,
            string windowsSymbolPath);

        public delegate void DisplaySymbolStoreDelegate(WriteLine writeLine);

        public delegate void DisableSymbolStoreDelegate();

        public delegate void LoadNativeSymbolsDelegate(
            SymbolFileCallback callback,
            IntPtr parameter,
            RuntimeConfiguration config,
            string moduleFilePath,
            ulong address,
            int size,
            ReadMemoryDelegate readMemory);

        public delegate void LoadNativeSymbolsFromIndexDelegate(
            SymbolFileCallback callback,
            IntPtr parameter,
            RuntimeConfiguration config,
            string moduleFilePath,
            bool specialKeys,
            int moduleIndexSize,
            IntPtr moduleIndex);

        public delegate IntPtr LoadSymbolsForModuleDelegate(
            string assemblyPath,
            bool isFileLayout,
            ulong loadedPeAddress,
            int loadedPeSize,
            ulong inMemoryPdbAddress,
            int inMemoryPdbSize,
            ReadMemoryDelegate readMemory);

        public delegate void DisposeDelegate(
            IntPtr symbolReaderHandle);

        public delegate bool ResolveSequencePointDelegate(
            IntPtr symbolReaderHandle,
            string filePath,
            int lineNumber,
            out int methodToken,
            out int ilOffset);

        public delegate bool GetLineByILOffsetDelegate(
            IntPtr symbolReaderHandle,
            int methodToken,
            long ilOffset,
            out int lineNumber,
            out IntPtr fileName);

        public delegate bool GetLocalVariableNameDelegate(
            IntPtr symbolReaderHandle,
            int methodToken,
            int localIndex,
            out IntPtr localVarName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate ulong GetExpressionDelegate(
            [In, MarshalAs(UnmanagedType.LPStr)] string expression);

        public delegate int GetMetadataLocatorDelegate(
            [MarshalAs(UnmanagedType.LPWStr)] string imagePath,
            uint imageTimestamp,
            uint imageSize,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 16)] byte[] mvid,
            uint mdRva,
            uint flags,
            uint bufferSize,
            IntPtr buffer,
            IntPtr dataSize);

        public delegate int GetICorDebugMetadataLocatorDelegate(
            [MarshalAs(UnmanagedType.LPWStr)] string imagePath,
            uint imageTimestamp,
            uint imageSize,
            uint pathBufferSize,
            IntPtr pPathBufferSize,
            IntPtr pPathBuffer);
    }

    /// <summary>
    /// Symbol service callback table
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SOSNetCoreCallbacks
    {
        public static SOSNetCoreCallbacks create() => new SOSNetCoreCallbacks {
            InitializeSymbolStoreDelegate = SymbolReader.InitializeSymbolStore,
            DisplaySymbolStoreDelegate = SymbolReader.DisplaySymbolStore,
            DisableSymbolStoreDelegate = SymbolReader.DisableSymbolStore,
            LoadNativeSymbolsDelegate = SymbolReader.LoadNativeSymbols,
            LoadNativeSymbolsFromIndexDelegate = SymbolReader.LoadNativeSymbolsFromIndex,
            LoadSymbolsForModuleDelegate = SymbolReader.LoadSymbolsForModule,
            DisposeDelegate = SymbolReader.Dispose,
            ResolveSequencePointDelegate = SymbolReader.ResolveSequencePoint,
            GetLineByILOffsetDelegate = SymbolReader.GetLineByILOffset,
            GetLocalVariableNameDelegate = SymbolReader.GetLocalVariableName,
            GetMetadataLocatorDelegate = MetadataHelper.GetMetadataLocator,
            GetExpressionDelegate = SymbolReader.GetExpression,
            GetICorDebugMetadataLocatorDelegate = MetadataHelper.GetICorDebugMetadataLocator
        };

        public InitializeSymbolStoreDelegate InitializeSymbolStoreDelegate;

        public DisplaySymbolStoreDelegate DisplaySymbolStoreDelegate;

        public DisableSymbolStoreDelegate DisableSymbolStoreDelegate;

        public LoadNativeSymbolsDelegate LoadNativeSymbolsDelegate;

        public LoadNativeSymbolsFromIndexDelegate LoadNativeSymbolsFromIndexDelegate;

        public LoadSymbolsForModuleDelegate LoadSymbolsForModuleDelegate;

        public DisposeDelegate DisposeDelegate;

        public ResolveSequencePointDelegate ResolveSequencePointDelegate;

        public GetLineByILOffsetDelegate GetLineByILOffsetDelegate;

        public GetLocalVariableNameDelegate GetLocalVariableNameDelegate;

        public GetMetadataLocatorDelegate GetMetadataLocatorDelegate;

        public GetExpressionDelegate GetExpressionDelegate;

        public GetICorDebugMetadataLocatorDelegate GetICorDebugMetadataLocatorDelegate;
    }
}