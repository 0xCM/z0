//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ClrDynamic
    {
        /// <summary>
        /// https://github.com/dotnet/runtime/blob/bdc8e420aa75999021e06b85e2e1869962730a0f/src/coreclr/System.Private.CoreLib/src/System/RuntimeType.CoreCLR.cs
        /// </summary>
        internal class RuntimeType
        {

        }

        /// <summary>
        /// https://github.com/dotnet/runtime/blob/860518b0011e7f7faf556faaa862d95619446112/src/coreclr/System.Private.CoreLib/src/System/RuntimeHandles.cs
        /// </summary>
        internal abstract class Resolver
        {
            internal abstract RuntimeType? GetJitContext(out int securityControlFlags);

            internal abstract byte[] GetCodeInfo(out int stackSize, out int initLocals, out int EHCount);

            internal abstract byte[] GetLocalsSignature();

            internal abstract unsafe void GetEHInfo(int EHNumber, void* exception);

            internal abstract byte[]? GetRawEHInfo();

            internal abstract string? GetStringLiteral(int token);

            internal abstract void ResolveToken(int token, out IntPtr typeHandle, out IntPtr methodHandle, out IntPtr fieldHandle);

            internal abstract byte[]? ResolveSignature(int token, int fromMethod);

            internal abstract MethodInfo GetDynamicMethod();
        }
    }
}