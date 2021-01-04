// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Code adapted from https://blogs.msdn.microsoft.com/haibo_luo/2010/04/19/ilvisualizer-2010-solution

namespace Msil
{
    public interface IILProvider
    {
        byte[] GetByteArray();
        
        ExceptionInfo[] GetExceptionInfos();
        
        byte[] GetLocalSignature();
        
        int MaxStackSize { get; }
    }
}